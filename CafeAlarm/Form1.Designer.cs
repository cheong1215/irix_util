namespace CafeAlarm
{
   partial class FormMain
   {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
         this.timerWork = new System.Windows.Forms.Timer(this.components);
         this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.timerAutoStart = new System.Windows.Forms.Timer(this.components);
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.timerHideChrome = new System.Windows.Forms.Timer(this.components);
         this.panel1 = new System.Windows.Forms.Panel();
         this.button2 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.buttonTest1 = new System.Windows.Forms.Button();
         this.panelStateAwakening = new System.Windows.Forms.Panel();
         this.label9 = new System.Windows.Forms.Label();
         this.panelStateRepeatBell = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.panelStateSearching = new System.Windows.Forms.Panel();
         this.label7 = new System.Windows.Forms.Label();
         this.panelStateNone = new System.Windows.Forms.Panel();
         this.label6 = new System.Windows.Forms.Label();
         this.textBoxDebug = new System.Windows.Forms.TextBox();
         this.timerWorkflow = new System.Windows.Forms.Timer(this.components);
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
         this.buttonMonitoringStart = new System.Windows.Forms.Button();
         this.labelArticleID = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.linkLabelNewText = new System.Windows.Forms.LinkLabel();
         this.label1 = new System.Windows.Forms.Label();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.buttonSetMusicFilename = new System.Windows.Forms.Button();
         this.textBoxMusicFilename = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.comboBoxRepeatCount = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.buttonSetSoundFile = new System.Windows.Forms.Button();
         this.textBoxSoundfilename = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.timerMusic = new System.Windows.Forms.Timer(this.components);
         this.buttonSkip = new System.Windows.Forms.Button();
         this.contextMenuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.panelStateAwakening.SuspendLayout();
         this.panelStateRepeatBell.SuspendLayout();
         this.panelStateSearching.SuspendLayout();
         this.panelStateNone.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.SuspendLayout();
         // 
         // timerWork
         // 
         this.timerWork.Interval = 1000;
         this.timerWork.Tick += new System.EventHandler(this.TimerWork_Tick);
         // 
         // notifyIcon1
         // 
         this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
         this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
         this.notifyIcon1.Text = "카페 새 글 알리미";
         this.notifyIcon1.Visible = true;
         this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
         this.toolStripMenuItem1.Text = "종료";
         this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
         // 
         // timerAutoStart
         // 
         this.timerAutoStart.Tick += new System.EventHandler(this.TimerAutoStart_Tick);
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // timerHideChrome
         // 
         this.timerHideChrome.Tick += new System.EventHandler(this.TimerHideChrome_Tick);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.button2);
         this.panel1.Controls.Add(this.button1);
         this.panel1.Controls.Add(this.buttonTest1);
         this.panel1.Controls.Add(this.panelStateAwakening);
         this.panel1.Controls.Add(this.panelStateRepeatBell);
         this.panel1.Controls.Add(this.panelStateSearching);
         this.panel1.Controls.Add(this.panelStateNone);
         this.panel1.Controls.Add(this.textBoxDebug);
         this.panel1.Location = new System.Drawing.Point(12, 250);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(670, 145);
         this.panel1.TabIndex = 17;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(219, 122);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 14;
         this.button2.Text = "button2";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.Button2_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(109, 123);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(99, 23);
         this.button1.TabIndex = 13;
         this.button1.Text = "벨소리 중지";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.Button1_Click_1);
         // 
         // buttonTest1
         // 
         this.buttonTest1.Location = new System.Drawing.Point(28, 123);
         this.buttonTest1.Name = "buttonTest1";
         this.buttonTest1.Size = new System.Drawing.Size(75, 23);
         this.buttonTest1.TabIndex = 12;
         this.buttonTest1.Text = "button1";
         this.buttonTest1.UseVisualStyleBackColor = true;
         this.buttonTest1.Click += new System.EventHandler(this.ButtonTest1_Click);
         // 
         // panelStateAwakening
         // 
         this.panelStateAwakening.BackColor = System.Drawing.Color.LightGray;
         this.panelStateAwakening.Controls.Add(this.label9);
         this.panelStateAwakening.Location = new System.Drawing.Point(519, 59);
         this.panelStateAwakening.Name = "panelStateAwakening";
         this.panelStateAwakening.Size = new System.Drawing.Size(141, 40);
         this.panelStateAwakening.TabIndex = 11;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(35, 13);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(75, 17);
         this.label9.TabIndex = 1;
         this.label9.Text = "Awakening";
         // 
         // panelStateRepeatBell
         // 
         this.panelStateRepeatBell.BackColor = System.Drawing.Color.LightGray;
         this.panelStateRepeatBell.Controls.Add(this.label8);
         this.panelStateRepeatBell.Location = new System.Drawing.Point(372, 59);
         this.panelStateRepeatBell.Name = "panelStateRepeatBell";
         this.panelStateRepeatBell.Size = new System.Drawing.Size(141, 40);
         this.panelStateRepeatBell.TabIndex = 10;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(35, 13);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(70, 17);
         this.label8.TabIndex = 1;
         this.label8.Text = "RepeatBell";
         // 
         // panelStateSearching
         // 
         this.panelStateSearching.BackColor = System.Drawing.Color.LightGray;
         this.panelStateSearching.Controls.Add(this.label7);
         this.panelStateSearching.Location = new System.Drawing.Point(526, 13);
         this.panelStateSearching.Name = "panelStateSearching";
         this.panelStateSearching.Size = new System.Drawing.Size(141, 40);
         this.panelStateSearching.TabIndex = 9;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(35, 12);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(67, 17);
         this.label7.TabIndex = 1;
         this.label7.Text = "Searching";
         // 
         // panelStateNone
         // 
         this.panelStateNone.BackColor = System.Drawing.Color.LightGray;
         this.panelStateNone.Controls.Add(this.label6);
         this.panelStateNone.Location = new System.Drawing.Point(372, 13);
         this.panelStateNone.Name = "panelStateNone";
         this.panelStateNone.Size = new System.Drawing.Size(141, 40);
         this.panelStateNone.TabIndex = 8;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(46, 13);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(41, 17);
         this.label6.TabIndex = 0;
         this.label6.Text = "None";
         // 
         // textBoxDebug
         // 
         this.textBoxDebug.Location = new System.Drawing.Point(28, 13);
         this.textBoxDebug.Multiline = true;
         this.textBoxDebug.Name = "textBoxDebug";
         this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBoxDebug.Size = new System.Drawing.Size(333, 104);
         this.textBoxDebug.TabIndex = 7;
         // 
         // timerWorkflow
         // 
         this.timerWorkflow.Enabled = true;
         this.timerWorkflow.Interval = 1000;
         this.timerWorkflow.Tick += new System.EventHandler(this.TimerWorkflow_Tick);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Location = new System.Drawing.Point(7, 8);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(665, 121);
         this.tabControl1.TabIndex = 18;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.buttonSkip);
         this.tabPage1.Controls.Add(this.metroTrackBar1);
         this.tabPage1.Controls.Add(this.buttonMonitoringStart);
         this.tabPage1.Controls.Add(this.labelArticleID);
         this.tabPage1.Controls.Add(this.label2);
         this.tabPage1.Controls.Add(this.linkLabelNewText);
         this.tabPage1.Controls.Add(this.label1);
         this.tabPage1.Location = new System.Drawing.Point(4, 26);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(657, 91);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "모니터링";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // metroTrackBar1
         // 
         this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
         this.metroTrackBar1.Location = new System.Drawing.Point(502, 55);
         this.metroTrackBar1.Name = "metroTrackBar1";
         this.metroTrackBar1.Size = new System.Drawing.Size(145, 23);
         this.metroTrackBar1.TabIndex = 25;
         this.metroTrackBar1.Text = "metroTrackBar1";
         this.metroTrackBar1.ValueChanged += new System.EventHandler(this.MetroTrackBar1_ValueChanged);
         // 
         // buttonMonitoringStart
         // 
         this.buttonMonitoringStart.Location = new System.Drawing.Point(502, 11);
         this.buttonMonitoringStart.Name = "buttonMonitoringStart";
         this.buttonMonitoringStart.Size = new System.Drawing.Size(145, 34);
         this.buttonMonitoringStart.TabIndex = 24;
         this.buttonMonitoringStart.Text = "모니터링 시작";
         this.buttonMonitoringStart.UseVisualStyleBackColor = true;
         this.buttonMonitoringStart.Click += new System.EventHandler(this.ButtonMonitoringStart_Click_1);
         // 
         // labelArticleID
         // 
         this.labelArticleID.AutoSize = true;
         this.labelArticleID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.labelArticleID.Location = new System.Drawing.Point(101, 52);
         this.labelArticleID.Name = "labelArticleID";
         this.labelArticleID.Size = new System.Drawing.Size(49, 20);
         this.labelArticleID.TabIndex = 23;
         this.labelArticleID.Text = "00000";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label2.Location = new System.Drawing.Point(12, 52);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 20);
         this.label2.TabIndex = 22;
         this.label2.Text = "글번호";
         // 
         // linkLabelNewText
         // 
         this.linkLabelNewText.AutoSize = true;
         this.linkLabelNewText.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.linkLabelNewText.LinkColor = System.Drawing.Color.Gray;
         this.linkLabelNewText.Location = new System.Drawing.Point(101, 19);
         this.linkLabelNewText.Name = "linkLabelNewText";
         this.linkLabelNewText.Size = new System.Drawing.Size(0, 20);
         this.linkLabelNewText.TabIndex = 21;
         this.linkLabelNewText.Click += new System.EventHandler(this.LinkLabelNewText_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label1.Location = new System.Drawing.Point(12, 19);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(69, 20);
         this.label1.TabIndex = 20;
         this.label1.Text = "최근새글";
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.buttonSetMusicFilename);
         this.tabPage2.Controls.Add(this.textBoxMusicFilename);
         this.tabPage2.Controls.Add(this.label5);
         this.tabPage2.Controls.Add(this.comboBoxRepeatCount);
         this.tabPage2.Controls.Add(this.label4);
         this.tabPage2.Controls.Add(this.buttonSetSoundFile);
         this.tabPage2.Controls.Add(this.textBoxSoundfilename);
         this.tabPage2.Controls.Add(this.label3);
         this.tabPage2.Location = new System.Drawing.Point(4, 26);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(657, 91);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "설정";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // buttonSetMusicFilename
         // 
         this.buttonSetMusicFilename.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.buttonSetMusicFilename.Location = new System.Drawing.Point(454, 50);
         this.buttonSetMusicFilename.Name = "buttonSetMusicFilename";
         this.buttonSetMusicFilename.Size = new System.Drawing.Size(27, 29);
         this.buttonSetMusicFilename.TabIndex = 37;
         this.buttonSetMusicFilename.Text = "...";
         this.buttonSetMusicFilename.UseVisualStyleBackColor = true;
         this.buttonSetMusicFilename.Click += new System.EventHandler(this.ButtonSetMusicFilename_Click);
         // 
         // textBoxMusicFilename
         // 
         this.textBoxMusicFilename.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.textBoxMusicFilename.Location = new System.Drawing.Point(109, 51);
         this.textBoxMusicFilename.Name = "textBoxMusicFilename";
         this.textBoxMusicFilename.Size = new System.Drawing.Size(342, 27);
         this.textBoxMusicFilename.TabIndex = 36;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label5.Location = new System.Drawing.Point(18, 54);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(77, 20);
         this.label5.TabIndex = 35;
         this.label5.Text = "음악파일 :";
         // 
         // comboBoxRepeatCount
         // 
         this.comboBoxRepeatCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBoxRepeatCount.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.comboBoxRepeatCount.FormattingEnabled = true;
         this.comboBoxRepeatCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "계속반복"});
         this.comboBoxRepeatCount.Location = new System.Drawing.Point(575, 15);
         this.comboBoxRepeatCount.Name = "comboBoxRepeatCount";
         this.comboBoxRepeatCount.Size = new System.Drawing.Size(57, 28);
         this.comboBoxRepeatCount.TabIndex = 34;
         this.comboBoxRepeatCount.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRepeatCount_SelectedIndexChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label4.Location = new System.Drawing.Point(500, 18);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(69, 20);
         this.label4.TabIndex = 33;
         this.label4.Text = "반복횟수";
         // 
         // buttonSetSoundFile
         // 
         this.buttonSetSoundFile.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.buttonSetSoundFile.Location = new System.Drawing.Point(454, 13);
         this.buttonSetSoundFile.Name = "buttonSetSoundFile";
         this.buttonSetSoundFile.Size = new System.Drawing.Size(27, 29);
         this.buttonSetSoundFile.TabIndex = 32;
         this.buttonSetSoundFile.Text = "...";
         this.buttonSetSoundFile.UseVisualStyleBackColor = true;
         this.buttonSetSoundFile.Click += new System.EventHandler(this.ButtonSetSoundFile_Click);
         // 
         // textBoxSoundfilename
         // 
         this.textBoxSoundfilename.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.textBoxSoundfilename.Location = new System.Drawing.Point(109, 15);
         this.textBoxSoundfilename.Name = "textBoxSoundfilename";
         this.textBoxSoundfilename.Size = new System.Drawing.Size(342, 27);
         this.textBoxSoundfilename.TabIndex = 31;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label3.Location = new System.Drawing.Point(15, 18);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(87, 20);
         this.label3.TabIndex = 30;
         this.label3.Text = "알람벨소리:";
         // 
         // timerMusic
         // 
         this.timerMusic.Interval = 55000;
         this.timerMusic.Tick += new System.EventHandler(this.TimerMusic_Tick);
         // 
         // buttonSkip
         // 
         this.buttonSkip.Location = new System.Drawing.Point(411, 46);
         this.buttonSkip.Name = "buttonSkip";
         this.buttonSkip.Size = new System.Drawing.Size(75, 34);
         this.buttonSkip.TabIndex = 26;
         this.buttonSkip.Text = "Skip";
         this.buttonSkip.UseVisualStyleBackColor = true;
         this.buttonSkip.Click += new System.EventHandler(this.ButtonSkip_Click);
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(679, 135);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.MaximizeBox = false;
         this.Name = "FormMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "아이릭스 카페 새 글 알리미";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
         this.Resize += new System.EventHandler(this.FormMain_Resize);
         this.contextMenuStrip1.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panelStateAwakening.ResumeLayout(false);
         this.panelStateAwakening.PerformLayout();
         this.panelStateRepeatBell.ResumeLayout(false);
         this.panelStateRepeatBell.PerformLayout();
         this.panelStateSearching.ResumeLayout(false);
         this.panelStateSearching.PerformLayout();
         this.panelStateNone.ResumeLayout(false);
         this.panelStateNone.PerformLayout();
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Timer timerWork;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.Timer timerAutoStart;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Timer timerHideChrome;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panelStateAwakening;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Panel panelStateRepeatBell;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Panel panelStateSearching;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Panel panelStateNone;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox textBoxDebug;
      private System.Windows.Forms.Button buttonTest1;
      private System.Windows.Forms.Timer timerWorkflow;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.Button buttonMonitoringStart;
      private System.Windows.Forms.Label labelArticleID;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.LinkLabel linkLabelNewText;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Button buttonSetMusicFilename;
      private System.Windows.Forms.TextBox textBoxMusicFilename;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox comboBoxRepeatCount;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button buttonSetSoundFile;
      private System.Windows.Forms.TextBox textBoxSoundfilename;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Timer timerMusic;
      private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
      public System.Windows.Forms.NotifyIcon notifyIcon1;
      private System.Windows.Forms.Button buttonSkip;
   }
}

