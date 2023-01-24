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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                LibraryData.FromFile();
            }
            catch
            {
                MessageBox.Show("�������� � ������ ������, ������ �� ����� �������.");
            }
        }

        private void ReaderModeBtn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form readerLog = new ReaderLogForm();
            readerLog.Show();
        }

        private void LibrarianModeBtn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form librarian = new LibrarianForm();
            librarian.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}