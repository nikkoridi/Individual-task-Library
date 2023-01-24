namespace Library
{
    partial class ReaderForm
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
            this.MyBooksList = new System.Windows.Forms.ListBox();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.LibraryBooksList = new System.Windows.Forms.ListBox();
            this.RetBooksList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetBookBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.MyCardCodeLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyBooksList
            // 
            this.MyBooksList.FormattingEnabled = true;
            this.MyBooksList.ItemHeight = 15;
            this.MyBooksList.Location = new System.Drawing.Point(12, 62);
            this.MyBooksList.Name = "MyBooksList";
            this.MyBooksList.Size = new System.Drawing.Size(210, 244);
            this.MyBooksList.TabIndex = 0;
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.Location = new System.Drawing.Point(67, 324);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBookBtn.TabIndex = 1;
            this.ReturnBookBtn.Text = "Вернуть";
            this.ReturnBookBtn.UseVisualStyleBackColor = true;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // LibraryBooksList
            // 
            this.LibraryBooksList.FormattingEnabled = true;
            this.LibraryBooksList.ItemHeight = 15;
            this.LibraryBooksList.Location = new System.Drawing.Point(228, 62);
            this.LibraryBooksList.Name = "LibraryBooksList";
            this.LibraryBooksList.Size = new System.Drawing.Size(303, 244);
            this.LibraryBooksList.TabIndex = 2;
            // 
            // RetBooksList
            // 
            this.RetBooksList.FormattingEnabled = true;
            this.RetBooksList.ItemHeight = 15;
            this.RetBooksList.Location = new System.Drawing.Point(537, 62);
            this.RetBooksList.Name = "RetBooksList";
            this.RetBooksList.Size = new System.Drawing.Size(217, 244);
            this.RetBooksList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Библиотека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Возвращенные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Мои Книги";
            // 
            // GetBookBtn
            // 
            this.GetBookBtn.Location = new System.Drawing.Point(342, 324);
            this.GetBookBtn.Name = "GetBookBtn";
            this.GetBookBtn.Size = new System.Drawing.Size(75, 23);
            this.GetBookBtn.TabIndex = 7;
            this.GetBookBtn.Text = "Взять";
            this.GetBookBtn.UseVisualStyleBackColor = true;
            this.GetBookBtn.Click += new System.EventHandler(this.GetBookBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(342, 353);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Искать";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // MyCardCodeLabel
            // 
            this.MyCardCodeLabel.AutoSize = true;
            this.MyCardCodeLabel.Location = new System.Drawing.Point(288, 9);
            this.MyCardCodeLabel.Name = "MyCardCodeLabel";
            this.MyCardCodeLabel.Size = new System.Drawing.Size(38, 15);
            this.MyCardCodeLabel.TabIndex = 10;
            this.MyCardCodeLabel.Text = "label4";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(679, 354);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 389);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MyCardCodeLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.GetBookBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RetBooksList);
            this.Controls.Add(this.LibraryBooksList);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.MyBooksList);
            this.Name = "ReaderForm";
            this.Text = "ReaderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MyBooksList;
        private Button ReturnBookBtn;
        private ListBox LibraryBooksList;
        private ListBox RetBooksList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button GetBookBtn;
        private Button SearchBtn;
        private Label MyCardCodeLabel;
        private Button ExitBtn;
    }
}