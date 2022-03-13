namespace DLS
{
    partial class TestMethod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.butAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Location = new System.Drawing.Point(25, 52);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(501, 239);
            this.rtbQuestion.TabIndex = 0;
            this.rtbQuestion.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 20);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вопрос№";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(298, 34);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(13, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "0";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(25, 305);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(500, 20);
            this.tbAnswer.TabIndex = 4;
            // 
            // butAnswer
            // 
            this.butAnswer.Location = new System.Drawing.Point(201, 338);
            this.butAnswer.Name = "butAnswer";
            this.butAnswer.Size = new System.Drawing.Size(154, 31);
            this.butAnswer.TabIndex = 5;
            this.butAnswer.Text = "Ответить";
            this.butAnswer.UseVisualStyleBackColor = true;
            this.butAnswer.Click += new System.EventHandler(this.butAnswer_Click);
            // 
            // TestMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 386);
            this.Controls.Add(this.butAnswer);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rtbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TestMethod";
            this.Text = "Тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button butAnswer;
    }
}