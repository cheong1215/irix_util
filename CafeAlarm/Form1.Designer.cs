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
         this.label1 = new System.Windows.Forms.Label();
         this.linkLabelNewText = new System.Windows.Forms.LinkLabel();
         this.label2 = new System.Windows.Forms.Label();
         this.labelNum = new System.Windows.Forms.Label();
         this.timerWork = new System.Windows.Forms.Timer(this.components);
         this.label3 = new System.Windows.Forms.Label();
         this.labelTime = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label1.Location = new System.Drawing.Point(12, 18);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(88, 25);
         this.label1.TabIndex = 0;
         this.label1.Text = "최근새글";
         // 
         // linkLabelNewText
         // 
         this.linkLabelNewText.AutoSize = true;
         this.linkLabelNewText.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.linkLabelNewText.Location = new System.Drawing.Point(130, 18);
         this.linkLabelNewText.Name = "linkLabelNewText";
         this.linkLabelNewText.Size = new System.Drawing.Size(126, 25);
         this.linkLabelNewText.TabIndex = 1;
         this.linkLabelNewText.TabStop = true;
         this.linkLabelNewText.Text = "최근새글제목";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label2.Location = new System.Drawing.Point(12, 55);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(69, 25);
         this.label2.TabIndex = 2;
         this.label2.Text = "글번호";
         // 
         // labelNum
         // 
         this.labelNum.AutoSize = true;
         this.labelNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.labelNum.Location = new System.Drawing.Point(130, 55);
         this.labelNum.Name = "labelNum";
         this.labelNum.Size = new System.Drawing.Size(67, 25);
         this.labelNum.TabIndex = 3;
         this.labelNum.Text = "00000";
         // 
         // timerWork
         // 
         this.timerWork.Enabled = true;
         this.timerWork.Interval = 500;
         this.timerWork.Tick += new System.EventHandler(this.TimerWork_Tick);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label3.Location = new System.Drawing.Point(12, 89);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(88, 25);
         this.label3.TabIndex = 4;
         this.label3.Text = "작성시간";
         // 
         // labelTime
         // 
         this.labelTime.AutoSize = true;
         this.labelTime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.labelTime.Location = new System.Drawing.Point(130, 89);
         this.labelTime.Name = "labelTime";
         this.labelTime.Size = new System.Drawing.Size(157, 25);
         this.labelTime.TabIndex = 5;
         this.labelTime.Text = "00월 00일 00:00";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(13, 148);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox1.Size = new System.Drawing.Size(607, 451);
         this.textBox1.TabIndex = 6;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(632, 611);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.labelTime);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.labelNum);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.linkLabelNewText);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.MaximizeBox = false;
         this.Name = "FormMain";
         this.Text = "아이릭스 카페 새 글 알리미";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.LinkLabel linkLabelNewText;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label labelNum;
      private System.Windows.Forms.Timer timerWork;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label labelTime;
      private System.Windows.Forms.TextBox textBox1;
   }
}

