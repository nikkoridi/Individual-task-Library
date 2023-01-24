namespace Library
{
    partial class ReaderLogForm
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
            this.RLogIn = new System.Windows.Forms.Button();
            this.RLogOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RLogIn
            // 
            this.RLogIn.Location = new System.Drawing.Point(33, 38);
            this.RLogIn.Name = "RLogIn";
            this.RLogIn.Size = new System.Drawing.Size(89, 23);
            this.RLogIn.TabIndex = 0;
            this.RLogIn.Text = "Вход";
            this.RLogIn.UseVisualStyleBackColor = true;
            this.RLogIn.Click += new System.EventHandler(this.RLogIn_Click);
            // 
            // RLogOn
            // 
            this.RLogOn.Location = new System.Drawing.Point(33, 89);
            this.RLogOn.Name = "RLogOn";
            this.RLogOn.Size = new System.Drawing.Size(89, 23);
            this.RLogOn.TabIndex = 1;
            this.RLogOn.Text = "Регистрация";
            this.RLogOn.UseVisualStyleBackColor = true;
            this.RLogOn.Click += new System.EventHandler(this.RLogOn_Click);
            // 
            // ReaderLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 155);
            this.Controls.Add(this.RLogOn);
            this.Controls.Add(this.RLogIn);
            this.Name = "ReaderLogForm";
            this.Text = "ReaderLogForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderLogForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button RLogIn;
        private Button RLogOn;
    }
}