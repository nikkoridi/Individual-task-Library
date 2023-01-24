namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ReaderModeBtn = new System.Windows.Forms.Button();
            this.LibrarianModeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кто вы?";
            // 
            // ReaderModeBtn
            // 
            this.ReaderModeBtn.Location = new System.Drawing.Point(63, 70);
            this.ReaderModeBtn.Name = "ReaderModeBtn";
            this.ReaderModeBtn.Size = new System.Drawing.Size(75, 23);
            this.ReaderModeBtn.TabIndex = 1;
            this.ReaderModeBtn.Text = "Читатель";
            this.ReaderModeBtn.UseVisualStyleBackColor = true;
            this.ReaderModeBtn.Click += new System.EventHandler(this.ReaderModeBtn_Click);
            // 
            // LibrarianModeBtn
            // 
            this.LibrarianModeBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.LibrarianModeBtn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.LibrarianModeBtn.FlatAppearance.BorderSize = 0;
            this.LibrarianModeBtn.Location = new System.Drawing.Point(43, 122);
            this.LibrarianModeBtn.Name = "LibrarianModeBtn";
            this.LibrarianModeBtn.Size = new System.Drawing.Size(116, 23);
            this.LibrarianModeBtn.TabIndex = 2;
            this.LibrarianModeBtn.Text = "Библиотекарь";
            this.LibrarianModeBtn.UseVisualStyleBackColor = false;
            this.LibrarianModeBtn.Click += new System.EventHandler(this.LibrarianModeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 188);
            this.Controls.Add(this.LibrarianModeBtn);
            this.Controls.Add(this.ReaderModeBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button ReaderModeBtn;
        private Button LibrarianModeBtn;
    }
}