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

        // Загрузка данных из файлов и вывод возможных ошибок
        private void LoadData()
        {
            try
            {
                LibraryData.FromFile();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + '\n' + "Проблема с файлами данных, данные (все или некоторые) не будут считаны.");
            }
        }

        // Переход на форму регистрации или входа читателя
        private void ReaderModeBtn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form readerLog = new ReaderLogForm();
            readerLog.Show();
        }

        // Переход на форму Библиотекаря
        private void LibrarianModeBtn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form librarian = new LibrarianForm();
            librarian.Show();
        }

        // При закрытии формы - закрывать все приложение
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}