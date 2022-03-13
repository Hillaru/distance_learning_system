namespace DLS
{
    partial class TextMethod
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(512, 20);
            this.tbTitle.TabIndex = 0;
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 53);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(511, 360);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(12, 419);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(98, 28);
            this.butOk.TabIndex = 2;
            this.butOk.Text = "Сохранить";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(117, 419);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(95, 28);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // TextMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TextMethod";
            this.Text = "Добавить Текстовую форму";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
    }
}