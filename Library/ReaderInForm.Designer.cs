namespace Library
{
    partial class ReaderInForm
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
            this.InToReaderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CardCodeField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CardCodeField)).BeginInit();
            this.SuspendLayout();
            // 
            // InToReaderBtn
            // 
            this.InToReaderBtn.Location = new System.Drawing.Point(61, 147);
            this.InToReaderBtn.Name = "InToReaderBtn";
            this.InToReaderBtn.Size = new System.Drawing.Size(106, 41);
            this.InToReaderBtn.TabIndex = 0;
            this.InToReaderBtn.Text = "Войти";
            this.InToReaderBtn.UseVisualStyleBackColor = true;
            this.InToReaderBtn.Click += new System.EventHandler(this.InToReaderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вход";
            // 
            // CardCodeField
            // 
            this.CardCodeField.Location = new System.Drawing.Point(37, 96);
            this.CardCodeField.Name = "CardCodeField";
            this.CardCodeField.Size = new System.Drawing.Size(151, 23);
            this.CardCodeField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер билета";
            // 
            // ReaderInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardCodeField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InToReaderBtn);
            this.Name = "ReaderInForm";
            this.Text = "ReaderInForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderInForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CardCodeField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button InToReaderBtn;
        private Label label1;
        private NumericUpDown CardCodeField;
        private Label label2;
    }
}