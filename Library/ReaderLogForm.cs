using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ReaderLogForm : Form
    {
        public ReaderLogForm()
        {
            InitializeComponent();
        }

        private void ReaderLogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Переход на форму входа
        private void RLogIn_Click(object sender, EventArgs e)
        {
            ReaderLogForm.ActiveForm.Hide();
            Form form = new ReaderInForm();
            form.Show();
        }

        // Переход на форму регистрации
        private void RLogOn_Click(object sender, EventArgs e)
        {
            ReaderLogForm.ActiveForm.Hide();
            Form form = new ReaderUpForm();
            form.Show();
        }
    }
}
