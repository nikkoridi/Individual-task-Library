namespace Library
{
    partial class SearchForm
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
            this.AuthorCheck = new System.Windows.Forms.CheckBox();
            this.TitleCheck = new System.Windows.Forms.CheckBox();
            this.AuthorField = new System.Windows.Forms.TextBox();
            this.TitleField = new System.Windows.Forms.TextBox();
            this.FindBooksList = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.WishBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NotFoundPanel = new System.Windows.Forms.Panel();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.NotFoundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorCheck
            // 
            this.AuthorCheck.AutoSize = true;
            this.AuthorCheck.Location = new System.Drawing.Point(12, 31);
            this.AuthorCheck.Name = "AuthorCheck";
            this.AuthorCheck.Size = new System.Drawing.Size(121, 19);
            this.AuthorCheck.TabIndex = 0;
            this.AuthorCheck.Text = "Искать по автору";
            this.AuthorCheck.UseVisualStyleBackColor = true;
            this.AuthorCheck.CheckStateChanged += new System.EventHandler(this.AuthorCheck_CheckStateChanged);
            // 
            // TitleCheck
            // 
            this.TitleCheck.AutoSize = true;
            this.TitleCheck.Location = new System.Drawing.Point(12, 85);
            this.TitleCheck.Name = "TitleCheck";
            this.TitleCheck.Size = new System.Drawing.Size(138, 19);
            this.TitleCheck.TabIndex = 1;
            this.TitleCheck.Text = "Искать по названию";
            this.TitleCheck.UseVisualStyleBackColor = true;
            this.TitleCheck.CheckStateChanged += new System.EventHandler(this.TitleCheck_CheckStateChanged);
            // 
            // AuthorField
            // 
            this.AuthorField.Location = new System.Drawing.Point(12, 56);
            this.AuthorField.Name = "AuthorField";
            this.AuthorField.Size = new System.Drawing.Size(249, 23);
            this.AuthorField.TabIndex = 2;
            // 
            // TitleField
            // 
            this.TitleField.Location = new System.Drawing.Point(12, 108);
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(249, 23);
            this.TitleField.TabIndex = 3;
            // 
            // FindBooksList
            // 
            this.FindBooksList.FormattingEnabled = true;
            this.FindBooksList.ItemHeight = 15;
            this.FindBooksList.Location = new System.Drawing.Point(267, 12);
            this.FindBooksList.Name = "FindBooksList";
            this.FindBooksList.Size = new System.Drawing.Size(306, 259);
            this.FindBooksList.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Peru;
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchBtn.Location = new System.Drawing.Point(12, 137);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(129, 37);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Искать";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // WishBtn
            // 
            this.WishBtn.Location = new System.Drawing.Point(12, 239);
            this.WishBtn.Name = "WishBtn";
            this.WishBtn.Size = new System.Drawing.Size(105, 42);
            this.WishBtn.TabIndex = 6;
            this.WishBtn.Text = "Оформить запрос";
            this.WishBtn.UseVisualStyleBackColor = true;
            this.WishBtn.Click += new System.EventHandler(this.WishBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ничего не найдено";
            // 
            // NotFoundPanel
            // 
            this.NotFoundPanel.Controls.Add(this.RequestBtn);
            this.NotFoundPanel.Controls.Add(this.label1);
            this.NotFoundPanel.Location = new System.Drawing.Point(85, 180);
            this.NotFoundPanel.Name = "NotFoundPanel";
            this.NotFoundPanel.Size = new System.Drawing.Size(164, 101);
            this.NotFoundPanel.TabIndex = 8;
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(56, 56);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(105, 42);
            this.RequestBtn.TabIndex = 9;
            this.RequestBtn.Text = "Оформить заявку";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 288);
            this.Controls.Add(this.WishBtn);
            this.Controls.Add(this.NotFoundPanel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.FindBooksList);
            this.Controls.Add(this.TitleField);
            this.Controls.Add(this.AuthorField);
            this.Controls.Add(this.TitleCheck);
            this.Controls.Add(this.AuthorCheck);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.NotFoundPanel.ResumeLayout(false);
            this.NotFoundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox AuthorCheck;
        private CheckBox TitleCheck;
        private TextBox AuthorField;
        private TextBox TitleField;
        private ListBox FindBooksList;
        private Button SearchBtn;
        private Button WishBtn;
        private Label label1;
        private Panel NotFoundPanel;
        private Button RequestBtn;
    }
}