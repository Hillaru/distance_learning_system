namespace DLS
{
    partial class VideoMethod
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
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLink.LinkArea = new System.Windows.Forms.LinkArea(0, 100);
            this.lblLink.Location = new System.Drawing.Point(9, 58);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(124, 17);
            this.lblLink.TabIndex = 0;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "https://www.google.com/";
            this.lblLink.UseCompatibleTextRendering = true;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(297, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Text = "Название";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(22, 81);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(197, 20);
            this.tbLink.TabIndex = 2;
            this.tbLink.Text = "Ссылка";
            this.tbLink.TextChanged += new System.EventHandler(this.tbLink_TextChanged);
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(48, 35);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(83, 20);
            this.tbDuration.TabIndex = 3;
            this.tbDuration.Text = "Длительность";
            this.tbDuration.TextChanged += new System.EventHandler(this.tbDuration_TextChanged);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(234, 35);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 36);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(234, 77);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 35);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "секунд";
            // 
            // VideoMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VideoMethod";
            this.Text = "Видео";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label1;
    }
}