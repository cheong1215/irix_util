using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Reflection;
//using System.Windows.Media;
using System.Windows.Threading;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace CafeAlarm
{
   public enum CurrentState { csNone, csSearching, csRepeatBell, csAwakening };

   struct NewTailInfo
   {
      public int id;
      public string title;
      public bool newTail;
   };


   public partial class FormMain : Form
   {
      [DllImport("user32.dll")]
      [return: MarshalAs(UnmanagedType.Bool)]
      static extern bool SetForegroundWindow(IntPtr hWnd);

      [DllImport("user32.dll")]
      static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

      [DllImport("user32.dll")]
      static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

      [DllImport("winmm.dll")]
      public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

      [DllImport("winmm.dll")]
      public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);


      const int SW_HIDE = 0;
      const int SW_SHOW = 5;


      public string newTextTitle;
      public int newArticleID = 0;
      public string newURL = "";
      public static int repeatCount = 3;
      public static int curCount = -1;
      public bool isFirst = true;
      public static string soundFilename = "sound.wav";
      public static string musicFilename = "music.wav";
      public bool musicPlaying = false;

      NewTailInfo newTailInfo;

      Dictionary<int, ArticleInfo> ArticleInfos = new Dictionary<int, ArticleInfo>();

      ChromeDriverService service = ChromeDriverService.CreateDefaultService();
      ChromeOptions chromeOption = new ChromeOptions();

      //System.Media.SoundPlayer mplayer;

      public CurrentState CS = CurrentState.csNone;

      Thread threadBell;

      public void SetCS(CurrentState cs)
      {
         CS = cs;

         switch (cs)
         {
            case CurrentState.csNone:

               panelStateNone.BackColor = System.Drawing.Color.LightGray;
               panelStateSearching.BackColor = System.Drawing.Color.LightGray;
               panelStateRepeatBell.BackColor = System.Drawing.Color.LightGray;
               panelStateAwakening.BackColor = System.Drawing.Color.LightGray;
               break;
            case CurrentState.csSearching:
               panelStateNone.BackColor = System.Drawing.Color.LightGray;
               panelStateSearching.BackColor = System.Drawing.Color.Yellow;
               panelStateRepeatBell.BackColor = System.Drawing.Color.LightGray;
               panelStateAwakening.BackColor = System.Drawing.Color.LightGray;
               break;
            case CurrentState.csRepeatBell:
               panelStateNone.BackColor = System.Drawing.Color.LightGray;
               panelStateSearching.BackColor = System.Drawing.Color.LightGray;
               panelStateRepeatBell.BackColor = System.Drawing.Color.Yellow;
               panelStateAwakening.BackColor = System.Drawing.Color.LightGray;
               break;
            case CurrentState.csAwakening:
               panelStateNone.BackColor = System.Drawing.Color.LightGray;
               panelStateSearching.BackColor = System.Drawing.Color.LightGray;
               panelStateRepeatBell.BackColor = System.Drawing.Color.LightGray;
               panelStateAwakening.BackColor = System.Drawing.Color.Yellow;
               break;
            default:
               panelStateNone.BackColor = System.Drawing.Color.LightGray;
               panelStateSearching.BackColor = System.Drawing.Color.LightGray;
               panelStateRepeatBell.BackColor = System.Drawing.Color.LightGray;
               panelStateAwakening.BackColor = System.Drawing.Color.LightGray;
               break;
         }
      }

      private static void SetVolume(ushort volume)
      {
         try
         {
            int value = (int)((double)volume * ushort.MaxValue / 100);
            uint leftChannelValue = ((uint)value & 0x0000ffff);
            uint rightChannelValue = ((uint)value << 16);
            waveOutSetVolume(IntPtr.Zero, leftChannelValue | rightChannelValue);
         }
         catch
         {
            //
         }
      }


      private static int GetVolume()
      {
         try
         {
            uint value;
            waveOutGetVolume(IntPtr.Zero, out value);
            ushort leftChannelValue = (ushort)(value & 0x0000ffff);
            ushort rightChannelValue = (ushort)(value >> 16);
            int volume = (int)(leftChannelValue * 100.0 / ushort.MaxValue + 0.5);
            return volume;
         }
         catch
         {
            return 0;
         }
      }


      public FormMain()
      {
         service.HideCommandPromptWindow = true;
         //chromeOption.AddArgument("--window-position=-32000,-32000");
         chromeOption.AddArgument("--headless");
         InitializeComponent();

         newTailInfo.newTail = false;
         newTailInfo.id = 0;
         newTailInfo.title = "";

         comboBoxRepeatCount.SelectedIndex = 1;

         soundFilename = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Sound.wav";
         musicFilename = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Music.mp3";

         // 벨소리 재생 쓰레드
         threadBell = new Thread(PlayBell);
         threadBell.Start();
         threadBell.Suspend();

         //metroTrackBar1.Value = WinVolume.GetMasterVolume();
         metroTrackBar1.Value = GetVolume();

         if (File.Exists(soundFilename))
         {
            textBoxSoundfilename.Text = soundFilename;
         }
         else
         {
            soundFilename = "";
            textBoxSoundfilename.Text = "사운드 파일을 지정해 주세요.";
         }

         if (File.Exists(musicFilename))
         {
            textBoxMusicFilename.Text = musicFilename;
         }
         else
         {
            musicFilename = "";
            textBoxMusicFilename.Text = "음악 파일을 지정해 주세요.";
         }
      }

      private void PlayBell()
      {
         while (true)
         {
            if ((curCount < repeatCount) && (curCount != -1))
            {
               this.Visible = true;
               this.WindowState = FormWindowState.Normal;
               SetForegroundWindow(this.Handle);
               this.TopMost = true;

               using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
               {
                  player.SoundLocation = soundFilename;
                  player.Play();
               }

               curCount++;
            }

            Thread.Sleep(59000);
         }
      }

      private void PlayMusic(string musicFile, bool loop)    // 처음 지점부터 재생
      {
         if (MediaControl.Status() == "playing" || MediaControl.Status() == "paused")
         {
            MediaControl.Close();
         }

         MediaControl.Open(musicFile);
         MediaControl.Play(loop);
      }

      private void StopMusic()     // 정지 버튼을 눌렀을 때
      {
         MediaControl.Stop();
      }

      private async void TimerWork_Tick(object sender, EventArgs e)
      {
         (sender as System.Windows.Forms.Timer).Interval = 60000;
         wlog("TimerWork");
         int oldID = newArticleID;

         await Task.Run(() =>
         {
            checkNewDocument();
         });

         if ((newTailInfo.newTail) || (oldID != newArticleID))
         {
            linkLabelNewText.LinkColor = System.Drawing.Color.Blue;

            if (newTailInfo.newTail)
            {
               linkLabelNewText.Text = "새 댓글 : " + newTailInfo.title;
               linkLabelNewText.Refresh();
            }
            else if (oldID != newArticleID)
            {
               linkLabelNewText.Text = newTextTitle;
               labelArticleID.Text = newArticleID.ToString();
               linkLabelNewText.Refresh();
               labelArticleID.Refresh();
            }

            newTailInfo.newTail = false;
            newTailInfo.id = 0;
            newTailInfo.title = "";
            newTailInfo.title = "";

            if (isFirst)
            {
               isFirst = false;
            }
            else
            {
               curCount = 0;
               threadBell.Suspend();
               threadBell.Resume();

               wlog("새로운 글/댓글이 모니터되었으므로 벨소리를 재생합니다.(" + curCount + "/" + repeatCount);
            }
         }
         else if (curCount == repeatCount)
         {
            if (musicPlaying == false)
            {
               wlog("1분후 음악 실행됨");
               timerMusic.Enabled = true;
            }
         }
      }

      private void wlog(string msg)
      {
         var curTime = '[' + DateTime.Now.ToString("hh:mm:ss") + ']';
         msg = curTime + msg + Environment.NewLine;

         if (textBoxDebug.InvokeRequired)
         {
            textBoxDebug.BeginInvoke(new Action(() => textBoxDebug.AppendText(msg)));
         }
         else
         {
            textBoxDebug.AppendText(msg);
         }
      }

      private void checkNewDocument()
      {
         using (var driver = new ChromeDriver(service, chromeOption))
         {

            string boardName = "";
            string articleTitle = "";
            //string articleID = "";
            int articleID = 0;
            string URL = "";
            int tailCount = 0;
            string tailCountString = "0";

            driver.Navigate().GoToUrl("https://cafe.naver.com/irix?iframe_url=/ArticleList.nhn%3Fsearch.clubid=21389965%26search.boardtype=L");

            // 게시글 리스트의 iframe 으로 전환
            driver.SwitchTo().Frame("cafe_main");

            var articleList = driver.FindElementsByCssSelector("td.td_article");

            foreach (var article in articleList)
            {
               try
               {
                  var td = article.FindElement(By.ClassName("inner_name"));

                  boardName = td.Text;
                  articleTitle = article.FindElement(By.ClassName("article")).Text;

                  URL = article.FindElement(By.ClassName("article")).GetAttribute("href");

                  if (Int32.TryParse(URL.Substring(URL.IndexOf("articleid=") + 10, 5), out articleID) == false)
                  {
                     articleID = 0;
                  }

                  try
                  {
                     tailCountString = article.FindElement(By.ClassName("cmt")).Text;
                     tailCountString = tailCountString.Replace("[", String.Empty);
                     tailCountString = tailCountString.Replace("]", String.Empty);

                     if (Int32.TryParse(tailCountString, out tailCount) == false)
                     {
                        tailCount = 0;
                     }
                  }
                  catch
                  {
                     tailCount = 0;
                  }

                  // 댓글수 비교
                  if (ArticleInfos.ContainsKey(articleID))
                  {
                     ArticleInfo ai = new ArticleInfo("", 0, "", 0);
                     ArticleInfos.TryGetValue(articleID, out ai);

                     if (tailCount > ai.TailCount)
                     {
                        newTailInfo.id = ai.ID;
                        newTailInfo.title = ai.Title;
                        newTailInfo.newTail = true;

                        ai.TailCount = tailCount;
                        newURL = ai.Url;
                     }
                  }


                  if (!ArticleInfos.ContainsKey(articleID))
                  {
                     // 딕셔너리에 추가
                     var ar = new ArticleInfo(articleTitle, articleID, URL, tailCount);

                     if (!ArticleInfos.ContainsKey(articleID))
                     {
                        ArticleInfos.Add(articleID, ar);
                        wlog("게시글 정보 추가함 : " + articleID + "/" + tailCount);
                     }
                  }

                  if (articleID > newArticleID)
                  {
                     newTextTitle = articleTitle;
                     newArticleID = articleID;
                     newURL = URL;
                  }
               }
               catch// (Exception ex)
               {
                  //MessageBox.Show(ex.Message);
               }
            }

            driver.Close();
         }
      }


      private void Button1_Click(object sender, EventArgs e)
      {
         PlayMusic(@"D:\WORK\C#\CafeAlarm\CafeAlarm\bin\Release\SAMPLE_2.wav", true);
      }

      private void FormMain_Resize(object sender, EventArgs e)
      {
         //윈도우 상태가 Minimized일 경우

         if (this.WindowState == FormWindowState.Minimized)
         {
            //this.Visible = false; //창을 보이지 않게 한다.
            //this.ShowIcon = true; //작업표시줄에서 제거.
            //notifyIcon1.Visible = true; //트레이 아이콘을 표시한다.
         }
      }


      private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (e.CloseReason == CloseReason.UserClosing) //유저가 종료 하려 할때
         {
            e.Cancel = true;//종료를 취소하고 
            //this.Visible = false;//어플리케이션을 숨긴다. 
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
         }
         else //아니면
         {
            notifyIcon1.Visible = false;   //NotifyIcon을 숨기고 종료
         }
      }

      private void ToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("종료하시겠습니까?", "아이릭스 카페글 알리미", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
         {
            try
            {
               this.notifyIcon1.Visible = false;
               //threadBell.Suspend();
               Process.Start("taskkill.exe", "/f /im CafeAlarm.exe");
            }
            catch
            {
               Process.Start("taskkill.exe", "/f /im CafeAlarm.exe");
            }
         }
      }


      private void ComboBoxRepeatCount_SelectedIndexChanged(object sender, EventArgs e)
      {
         if ((sender as ComboBox).SelectedIndex < 10)
         {
            repeatCount = (sender as ComboBox).SelectedIndex + 1;
         }
         else
         {
            repeatCount = 100;
         }
      }

      private void TimerAutoStart_Tick(object sender, EventArgs e)
      {
         timerAutoStart.Enabled = false;
         PlayMusic(musicFilename, true);
      }

      private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         //Notify Icon을 더블 클릭했을때 일어나는 이벤트.

         this.Visible = true;
         this.ShowIcon = true;
         this.WindowState = FormWindowState.Normal;
         this.Show();
      }

      // 글 확인 했을 때 실행되는 메소드
      private void ReadDone(bool openBrowser)
      {
         curCount = -1;
         musicPlaying = false;

         linkLabelNewText.LinkColor = System.Drawing.Color.Gray;

         this.TopMost = false;

         threadBell.Suspend();
         StopMusic();

         if (openBrowser)
            Process.Start(newURL);

         if (!timerWork.Enabled)
            timerWork.Start();
      }

      private void ButtonSetSoundFile_Click(object sender, EventArgs e)
      {
         openFileDialog1.InitialDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
         openFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
         openFileDialog1.FilterIndex = 1;
         openFileDialog1.RestoreDirectory = true;

         if (openFileDialog1.ShowDialog() != DialogResult.OK)
            return;

         soundFilename = openFileDialog1.FileName;
         textBoxSoundfilename.Text = soundFilename;
      }

      private void ButtonMonitoringStart_Click(object sender, EventArgs e)
      {

      }

      private void ButtonSetMusicFilename_Click(object sender, EventArgs e)
      {
         openFileDialog1.InitialDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
         openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
         openFileDialog1.FilterIndex = 1;
         openFileDialog1.RestoreDirectory = true;

         if (openFileDialog1.ShowDialog() != DialogResult.OK)
            return;

         musicFilename = openFileDialog1.FileName;
         textBoxMusicFilename.Text = musicFilename;
      }

      private void LinkLabelNewText_Click(object sender, EventArgs e)
      {
         ReadDone(true);

         //curCount = -1;
         //musicPlaying = false;

         //this.TopMost = false;

         //threadBell.Suspend();
         //StopMusic();

         //Process.Start(newURL);

         //if (!timerWork.Enabled)
         //   timerWork.Start();
      }

      private void TimerHideChrome_Tick(object sender, EventArgs e)
      {
         timerHideChrome.Enabled = false;
         IntPtr hWnd = FindWindow(null, "data:, - Chrome");

         if (hWnd != IntPtr.Zero)
         {
            ShowWindow(hWnd, SW_HIDE); // Hide the window
         }
         else
         {
            timerHideChrome.Enabled = true;
         }
      }

      private void ButtonTest1_Click(object sender, EventArgs e)
      {
         //SetCS(CurrentState.csRepeatBell);
         curCount = 0;
         repeatCount = 2;
         threadBell.Resume();

      }

      private void TimerWorkflow_Tick(object sender, EventArgs e)
      {
         timerWorkflow.Interval = 10000;
         wlog("timerWorkFlow");
      }

      private void Button1_Click_1(object sender, EventArgs e)
      {
         threadBell.Suspend();
      }

      private void Button2_Click(object sender, EventArgs e)
      {
         threadBell.Resume();
      }

      private void ButtonMonitoringStart_Click_1(object sender, EventArgs e)
      {
         if (!File.Exists(soundFilename))
         {
            MessageBox.Show("알람벨소리 파일이 존재하지 않습니다.");
            return;
         }

         if (!File.Exists(musicFilename))
         {
            MessageBox.Show("음악 파일이 존재하지 않습니다.");
            return;
         }

         timerWork.Enabled = true;
         (sender as Button).Enabled = false;
      }

      private void LinkLabelNewText_Click_1(object sender, EventArgs e)
      {

      }

      private void TimerMusic_Tick(object sender, EventArgs e)
      {
         this.Visible = true;
         this.WindowState = FormWindowState.Normal;
         SetForegroundWindow(this.Handle);

         timerMusic.Enabled = false;
         timerWork.Enabled = false;
         musicPlaying = true;
         PlayMusic(musicFilename, true);
      }

      private void MetroTrackBar1_ValueChanged(object sender, EventArgs e)
      {
         //WinVolume.SetMasterVolume((Int32)metroTrackBar1.Value);
         SetVolume((ushort)metroTrackBar1.Value);
      }

      private void ButtonSkip_Click(object sender, EventArgs e)
      {
         ReadDone(false);
      }
   }
}
