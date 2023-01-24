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
    public partial class ReaderUpForm : Form
    {
        bool created = false;

        public ReaderUpForm()
        {
            InitializeComponent();
        }

        // Создание нового читателя
        private void CreateNewReader()
        {
            bool SNPCheck = SurnameField.Text.Length > 0 && NameField.Text.Length > 0 && PatronymicField.Text.Length > 0;
            bool dateCheck = DateField.Text.Length > 0;
            bool dateCheckNow = DateField.Value <= DateTime.Now;
            bool phoneCheck = PhoneField.Text.Length > 0;
            try
            {
                if (!SNPCheck)
                    MessageBox.Show("Необходио ввести фамилию, имя и отчество", "Ошибка");
                else if (!dateCheck)
                    MessageBox.Show("Необходио ввести дату рождения", "Ошибка");
                else if (!dateCheckNow)
                    MessageBox.Show("Дата рождения не может быть больше текущей", "Ошибка");
                else if (!phoneCheck)
                    MessageBox.Show("Необходио ввести телефон", "Ошибка");
                else
                {
                    Reader reader = new Reader(SurnameField.Text, NameField.Text, PatronymicField.Text, DateField.Value, PhoneField.Value.ToString());
                    LibraryData.AddReader(reader);
                    // Передаем номер билета в статический класс - чтобы следующая форма нашла этого читателя и его данные
                    LibraryData.CurrentReaderCode = reader.CardCode;
                    LibraryData.ToFile();
                    created = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Непредвиденая ошибка");
            }
        }

        // Смена формы
        private void ChangeForm()
        {
            ReaderUpForm.ActiveForm.Hide();
            Form form = new ReaderForm();
            form.Show();
        }

        // Переход на форму данных самого читателя, если новый читатель успешно создан
        private void UpReaderFormBtn_Click(object sender, EventArgs e)
        {
            CreateNewReader();
            if (created)
            {
                ChangeForm();
            }
        }

        private void ReaderUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
