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
    public partial class ReaderInForm : Form
    {
        // Верен ли введенный номер билета
        bool isValidCard = false;

        public ReaderInForm()
        {
            InitializeComponent();
        }

        private void ReaderInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Поиск читателя в списке
        // Если нашли, меняем переменную-флаг: isValidCard
        private void FindReader()
        {
            // Возможно нужно добавить проверку на длину кода, сделав билет фиксированной длины
            if (CardCodeField.Value >= 0)
            {
                Reader r = LibraryData.FindReaderByCode(Convert.ToInt32(CardCodeField.Value));
                if (r != null)
                {
                    isValidCard = true;
                    LibraryData.CurrentReaderCode = r.CardCode;
                }
                else
                {
                    MessageBox.Show("Читатель не найден");
                }
            }
        }

        // Смена формы
        private void ChangeForm()
        {
            ReaderUpForm.ActiveForm.Hide();
            Form form = new ReaderForm();
            form.Show();
        }

        // Если билет корректный, переходим на форму дальше
        private void InToReaderBtn_Click(object sender, EventArgs e)
        {
            FindReader();
            if (isValidCard)
                ChangeForm();
        }
    }
}
