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
using Microsoft.Speech;
using Microsoft.Speech.Synthesis;
using System.Threading;

namespace CafeAlarm
{
   public partial class FormMain : Form
   {
      public string newTextTitle;
      public int newTextNum;
      string url = "https://cafe.naver.com/irix?iframe_url=/ArticleList.nhn%3Fsearch.clubid=21389965%26search.boardtype=L";

      bool isFirst = true;
      string newTitle = "";

      public FormMain()
      {
         InitializeComponent();
      }

      private void TimerWork_Tick(object sender, EventArgs e)
      {
         (sender as System.Windows.Forms.Timer).Stop();
         (sender as System.Windows.Forms.Timer).Interval = 30000;

         checkNewText();
         (sender as System.Windows.Forms.Timer).Start();
      }

      private async void SoundPlay()
      {
         using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
         {
            await Task.Run(() =>
            {
               player.SoundLocation = "Sound.wav";
               player.Play();
            
            });
         }
      }

      private async void ReadNewTitle()
      {
         await Task.Run(() =>
         {
            SpeechSynthesizer ts = new SpeechSynthesizer();
            ts.SetOutputToDefaultAudioDevice();
            ts.Speak(newTitle);
         });
      }

      private async void AlarmRepeat(int repeatCount)
      {
         for (int i = 0; i < repeatCount; i++)
         {
            SoundPlay();

            await Task.Run(() =>
            {
               Thread.Sleep(3000);
            });

            ReadNewTitle();

            await Task.Run(() =>
            {
               Thread.Sleep(5000);
            });
         }
      }

      private async void checkNewText()
      {
         WebClient web = new WebClient();
         web.Encoding = Encoding.Default;
         int num = 0;
         int startPosition, endPosition;
         string numString;

         string html = await web.DownloadStringTaskAsync(url);

         string[] seperStrings = { "\r\n", "\n\r", "\n" };
         string[] lines = html.Split(seperStrings, System.StringSplitOptions.RemoveEmptyEntries);

         textBox1.Text = html;

         //foreach(var line in lines)
         for(int i = 0; i < lines.Length - 1; i++)
         {
            string line = lines[i];

            if (line.Contains("articleid="))
            {
               startPosition = line.IndexOf("articleid=") + 10;
               endPosition = line.IndexOf("\" target = \"");
               numString = line.Substring(startPosition, 5);
               //string newTitle = "";

               if (Int32.TryParse(numString, out num) == false)
                  num = 0;

               if (num > newTextNum)
               {
                  newTextNum = num;
                  labelNum.Text = num.ToString();

                  if (i < lines.Length)
                  {
                     newTitle = lines[i + 1];
                     newTitle = newTitle.Replace(@"<div class=""ellipsis tcol-c"">", "");
                     newTitle = newTitle.Replace("</div>", "");
                  }

                  linkLabelNewText.Text = newTitle;
                  linkLabelNewText.Refresh();

                  labelTime.Text = DateTime.Now.ToString("MM월 dd일 hh:mm");
                  labelTime.Refresh();

                  
                  if (isFirst)
                  {
                     // 첫 저장일 때
                     isFirst = false;
                     AlarmRepeat(3);
                  }
                  else
                  {
                  //
                  }

                  break;
               }
            }

         }

      }
   }
}
