using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        // Кнопка создания заявки
        private void SendRequestBtn_Click(object sender, EventArgs e)
        {
            if (RequestField != null && !String.IsNullOrEmpty(RequestField.Text))
            {
                LibraryData.AddRequest(RequestField.Text);
                LibraryData.ToFile();
                MessageBox.Show("Заявка отправлена!");
            }
        }
    }
}
