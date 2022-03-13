namespace DLS
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.butCabinet = new System.Windows.Forms.Button();
            this.butCourses = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.butOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 28);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(643, 404);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // butCabinet
            // 
            this.butCabinet.Location = new System.Drawing.Point(677, 28);
            this.butCabinet.Name = "butCabinet";
            this.butCabinet.Size = new System.Drawing.Size(111, 42);
            this.butCabinet.TabIndex = 1;
            this.butCabinet.Text = "Личный кабинет";
            this.butCabinet.UseVisualStyleBackColor = true;
            this.butCabinet.Click += new System.EventHandler(this.butCabinet_Click);
            // 
            // butCourses
            // 
            this.butCourses.Location = new System.Drawing.Point(675, 76);
            this.butCourses.Name = "butCourses";
            this.butCourses.Size = new System.Drawing.Size(111, 41);
            this.butCourses.TabIndex = 3;
            this.butCourses.Text = "Курсы";
            this.butCourses.UseVisualStyleBackColor = true;
            this.butCourses.Click += new System.EventHandler(this.butCourses_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(677, 241);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(110, 52);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(677, 299);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(109, 49);
            this.butDelete.TabIndex = 5;
            this.butDelete.Text = "delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(677, 354);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(109, 51);
            this.butEdit.TabIndex = 6;
            this.butEdit.Text = "edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(12, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "label1";
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(677, 186);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(110, 49);
            this.butOpen.TabIndex = 8;
            this.butOpen.Text = "Просмотреть курс";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butCourses);
            this.Controls.Add(this.butCabinet);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "Система Дистанционного Обучения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button butCabinet;
        private System.Windows.Forms.Button butCourses;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button butOpen;
    }
}

