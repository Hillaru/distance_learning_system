namespace DLS
{
    partial class EditTestMethod
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Location = new System.Drawing.Point(26, 54);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(444, 334);
            this.rtbQuestion.TabIndex = 0;
            this.rtbQuestion.Text = "";
            this.rtbQuestion.TextChanged += new System.EventHandler(this.rtbQuestion_TextChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(26, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(642, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // butLeft
            // 
            this.butLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butLeft.Location = new System.Drawing.Point(482, 347);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(42, 40);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "<-";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butRight
            // 
            this.butRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRight.Location = new System.Drawing.Point(644, 344);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(41, 43);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "->";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(550, 352);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(70, 26);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "label1";
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAdd.Location = new System.Drawing.Point(510, 62);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(157, 55);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "Добавить вопрос";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelete.Location = new System.Drawing.Point(513, 139);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(153, 56);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Удалить вопрос";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(27, 401);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(196, 38);
            this.butSave.TabIndex = 7;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancel.Location = new System.Drawing.Point(281, 401);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(189, 36);
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // EditTestMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.butRight);
            this.Controls.Add(this.butLeft);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.rtbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditTestMethod";
            this.Text = "Редактор тестов";
            this.Load += new System.EventHandler(this.EditTestMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
    }
}