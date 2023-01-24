namespace Library
{
    partial class RequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RequestField = new System.Windows.Forms.TextBox();
            this.SendRequestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст заявки:";
            // 
            // RequestField
            // 
            this.RequestField.Location = new System.Drawing.Point(7, 46);
            this.RequestField.Multiline = true;
            this.RequestField.Name = "RequestField";
            this.RequestField.Size = new System.Drawing.Size(283, 250);
            this.RequestField.TabIndex = 1;
            // 
            // SendRequestBtn
            // 
            this.SendRequestBtn.Location = new System.Drawing.Point(103, 312);
            this.SendRequestBtn.Name = "SendRequestBtn";
            this.SendRequestBtn.Size = new System.Drawing.Size(75, 23);
            this.SendRequestBtn.TabIndex = 2;
            this.SendRequestBtn.Text = "Отправить";
            this.SendRequestBtn.UseVisualStyleBackColor = true;
            this.SendRequestBtn.Click += new System.EventHandler(this.SendRequestBtn_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 350);
            this.Controls.Add(this.SendRequestBtn);
            this.Controls.Add(this.RequestField);
            this.Controls.Add(this.label1);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox RequestField;
        private Button SendRequestBtn;
    }
}