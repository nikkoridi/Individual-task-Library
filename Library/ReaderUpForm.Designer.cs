namespace Library
{
    partial class ReaderUpForm
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
            this.UpReaderFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.PatronymicField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneField)).BeginInit();
            this.SuspendLayout();
            // 
            // UpReaderFormBtn
            // 
            this.UpReaderFormBtn.Location = new System.Drawing.Point(61, 335);
            this.UpReaderFormBtn.Name = "UpReaderFormBtn";
            this.UpReaderFormBtn.Size = new System.Drawing.Size(124, 30);
            this.UpReaderFormBtn.TabIndex = 0;
            this.UpReaderFormBtn.Text = "button1";
            this.UpReaderFormBtn.UseVisualStyleBackColor = true;
            this.UpReaderFormBtn.Click += new System.EventHandler(this.UpReaderFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отчество";
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(50, 78);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(153, 23);
            this.SurnameField.TabIndex = 5;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(50, 122);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(153, 23);
            this.NameField.TabIndex = 6;
            // 
            // PatronymicField
            // 
            this.PatronymicField.Location = new System.Drawing.Point(50, 168);
            this.PatronymicField.Name = "PatronymicField";
            this.PatronymicField.Size = new System.Drawing.Size(153, 23);
            this.PatronymicField.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата рождения";
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(29, 224);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(200, 23);
            this.DateField.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер телефона";
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(61, 281);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(120, 23);
            this.PhoneField.TabIndex = 11;
            // 
            // ReaderUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 392);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatronymicField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpReaderFormBtn);
            this.Name = "ReaderUpForm";
            this.Text = "ReaderUpForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderUpForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpReaderFormBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SurnameField;
        private TextBox NameField;
        private TextBox PatronymicField;
        private Label label5;
        private DateTimePicker DateField;
        private Label label6;
        private NumericUpDown PhoneField;
    }
}