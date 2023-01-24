namespace Library
{
    partial class LibrarianForm
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
            this.BooksList = new System.Windows.Forms.ListBox();
            this.LibraryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RequestList = new System.Windows.Forms.ListBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.DelBookBtn = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AuthorField = new System.Windows.Forms.TextBox();
            this.DescriptionField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadersList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvailableСheck = new System.Windows.Forms.CheckBox();
            this.ViewDescription = new System.Windows.Forms.Button();
            this.ViewWishing = new System.Windows.Forms.Button();
            this.ReturnedBooksList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoneRequestBtn = new System.Windows.Forms.Button();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.GetToNextBtn = new System.Windows.Forms.Button();
            this.ChangeBookStatusBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ViewRequestBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksList
            // 
            this.BooksList.FormattingEnabled = true;
            this.BooksList.ItemHeight = 15;
            this.BooksList.Location = new System.Drawing.Point(12, 39);
            this.BooksList.Name = "BooksList";
            this.BooksList.Size = new System.Drawing.Size(345, 424);
            this.BooksList.TabIndex = 0;
            // 
            // LibraryLabel
            // 
            this.LibraryLabel.AutoSize = true;
            this.LibraryLabel.Location = new System.Drawing.Point(12, 9);
            this.LibraryLabel.Name = "LibraryLabel";
            this.LibraryLabel.Size = new System.Drawing.Size(72, 15);
            this.LibraryLabel.TabIndex = 1;
            this.LibraryLabel.Text = "Библиотека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заявки";
            // 
            // RequestList
            // 
            this.RequestList.FormattingEnabled = true;
            this.RequestList.ItemHeight = 15;
            this.RequestList.Location = new System.Drawing.Point(560, 37);
            this.RequestList.Name = "RequestList";
            this.RequestList.Size = new System.Drawing.Size(227, 394);
            this.RequestList.TabIndex = 2;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(377, 299);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(126, 23);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Добавить книгу";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(377, 328);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(100, 23);
            this.EditBookBtn.TabIndex = 5;
            this.EditBookBtn.Text = "Редактировать";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // DelBookBtn
            // 
            this.DelBookBtn.Location = new System.Drawing.Point(377, 357);
            this.DelBookBtn.Name = "DelBookBtn";
            this.DelBookBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBookBtn.TabIndex = 6;
            this.DelBookBtn.Text = "Удалить";
            this.DelBookBtn.UseVisualStyleBackColor = true;
            this.DelBookBtn.Click += new System.EventHandler(this.DelBookBtn_Click);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(377, 56);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 23);
            this.NameField.TabIndex = 7;
            // 
            // AuthorField
            // 
            this.AuthorField.Location = new System.Drawing.Point(377, 102);
            this.AuthorField.Name = "AuthorField";
            this.AuthorField.Size = new System.Drawing.Size(100, 23);
            this.AuthorField.TabIndex = 8;
            // 
            // DescriptionField
            // 
            this.DescriptionField.Location = new System.Drawing.Point(377, 205);
            this.DescriptionField.Multiline = true;
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(163, 88);
            this.DescriptionField.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Автор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Описание";
            // 
            // ReadersList
            // 
            this.ReadersList.FormattingEnabled = true;
            this.ReadersList.ItemHeight = 15;
            this.ReadersList.Location = new System.Drawing.Point(1058, 37);
            this.ReadersList.Name = "ReadersList";
            this.ReadersList.Size = new System.Drawing.Size(247, 424);
            this.ReadersList.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Библиотека";
            // 
            // AvailableСheck
            // 
            this.AvailableСheck.AutoSize = true;
            this.AvailableСheck.Location = new System.Drawing.Point(377, 142);
            this.AvailableСheck.Name = "AvailableСheck";
            this.AvailableСheck.Size = new System.Drawing.Size(78, 19);
            this.AvailableСheck.TabIndex = 17;
            this.AvailableСheck.Text = "Доступна";
            this.AvailableСheck.UseVisualStyleBackColor = true;
            // 
            // ViewDescription
            // 
            this.ViewDescription.Location = new System.Drawing.Point(374, 438);
            this.ViewDescription.Name = "ViewDescription";
            this.ViewDescription.Size = new System.Drawing.Size(75, 23);
            this.ViewDescription.TabIndex = 19;
            this.ViewDescription.Text = "Описание";
            this.ViewDescription.UseVisualStyleBackColor = true;
            this.ViewDescription.Click += new System.EventHandler(this.ViewDescription_Click);
            // 
            // ViewWishing
            // 
            this.ViewWishing.Location = new System.Drawing.Point(455, 438);
            this.ViewWishing.Name = "ViewWishing";
            this.ViewWishing.Size = new System.Drawing.Size(84, 23);
            this.ViewWishing.TabIndex = 20;
            this.ViewWishing.Text = "Очередь";
            this.ViewWishing.UseVisualStyleBackColor = true;
            this.ViewWishing.Click += new System.EventHandler(this.ViewWishing_Click);
            // 
            // ReturnedBooksList
            // 
            this.ReturnedBooksList.FormattingEnabled = true;
            this.ReturnedBooksList.ItemHeight = 15;
            this.ReturnedBooksList.Location = new System.Drawing.Point(791, 37);
            this.ReturnedBooksList.Name = "ReturnedBooksList";
            this.ReturnedBooksList.Size = new System.Drawing.Size(261, 394);
            this.ReturnedBooksList.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(791, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Возвращенные книги";
            // 
            // DoneRequestBtn
            // 
            this.DoneRequestBtn.Location = new System.Drawing.Point(560, 440);
            this.DoneRequestBtn.Name = "DoneRequestBtn";
            this.DoneRequestBtn.Size = new System.Drawing.Size(137, 23);
            this.DoneRequestBtn.TabIndex = 23;
            this.DoneRequestBtn.Text = "Отметить готовой";
            this.DoneRequestBtn.UseVisualStyleBackColor = true;
            this.DoneRequestBtn.Click += new System.EventHandler(this.DoneRequestBtn_Click);
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.Location = new System.Drawing.Point(804, 440);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(81, 23);
            this.ReturnBookBtn.TabIndex = 24;
            this.ReturnBookBtn.Text = "Вернуть";
            this.ReturnBookBtn.UseVisualStyleBackColor = true;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // GetToNextBtn
            // 
            this.GetToNextBtn.Location = new System.Drawing.Point(891, 440);
            this.GetToNextBtn.Name = "GetToNextBtn";
            this.GetToNextBtn.Size = new System.Drawing.Size(153, 23);
            this.GetToNextBtn.TabIndex = 25;
            this.GetToNextBtn.Text = "Передать желающему";
            this.GetToNextBtn.UseVisualStyleBackColor = true;
            this.GetToNextBtn.Click += new System.EventHandler(this.GetToNextBtn_Click);
            // 
            // ChangeBookStatusBtn
            // 
            this.ChangeBookStatusBtn.Location = new System.Drawing.Point(377, 386);
            this.ChangeBookStatusBtn.Name = "ChangeBookStatusBtn";
            this.ChangeBookStatusBtn.Size = new System.Drawing.Size(148, 23);
            this.ChangeBookStatusBtn.TabIndex = 26;
            this.ChangeBookStatusBtn.Text = "Изменить доступность";
            this.ChangeBookStatusBtn.UseVisualStyleBackColor = true;
            this.ChangeBookStatusBtn.Click += new System.EventHandler(this.ChangeBookStatusBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1246, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(59, 23);
            this.ExitBtn.TabIndex = 27;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ViewRequestBtn
            // 
            this.ViewRequestBtn.Location = new System.Drawing.Point(703, 440);
            this.ViewRequestBtn.Name = "ViewRequestBtn";
            this.ViewRequestBtn.Size = new System.Drawing.Size(84, 23);
            this.ViewRequestBtn.TabIndex = 28;
            this.ViewRequestBtn.Text = "Посмотреть";
            this.ViewRequestBtn.UseVisualStyleBackColor = true;
            this.ViewRequestBtn.Click += new System.EventHandler(this.ViewRequestBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1058, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Читатели";
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ViewRequestBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ChangeBookStatusBtn);
            this.Controls.Add(this.GetToNextBtn);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.DoneRequestBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReturnedBooksList);
            this.Controls.Add(this.ViewWishing);
            this.Controls.Add(this.ViewDescription);
            this.Controls.Add(this.AvailableСheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReadersList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionField);
            this.Controls.Add(this.AuthorField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.DelBookBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestList);
            this.Controls.Add(this.LibraryLabel);
            this.Controls.Add(this.BooksList);
            this.Name = "LibrarianForm";
            this.Text = "LibrarianForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibrarianForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox BooksList;
        private Label LibraryLabel;
        private Label label2;
        private ListBox RequestList;
        private Button AddBookBtn;
        private Button EditBookBtn;
        private Button DelBookBtn;
        private TextBox NameField;
        private TextBox AuthorField;
        private TextBox DescriptionField;
        private Label label1;
        private Label label4;
        private Label label5;
        private ListBox ReadersList;
        private Label label6;
        private CheckBox AvailableСheck;
        private Button ViewDescription;
        private Button ViewWishing;
        private ListBox ReturnedBooksList;
        private Label label7;
        private Button DoneRequestBtn;
        private Button ReturnBookBtn;
        private Button GetToNextBtn;
        private Button ChangeBookStatusBtn;
        private Button ExitBtn;
        private Button ViewRequestBtn;
        private Label label3;
    }
}