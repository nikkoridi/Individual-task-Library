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
    public partial class ReaderForm : Form
    {
        Reader current;

        public ReaderForm()
        {
            InitializeComponent();
            OnInit();
        }

        // Добавление данных формы при загрузке
        private void OnInit()
        {
            ShowBooks();
            GetCurrentReader();
            ShowMyBooks();
            ShowRetBooks();

            MyCardCodeLabel.Text = "Номер читательского билета: " + current.CardCode.ToString();
        }

        // Установка текущего пользователя
        private void GetCurrentReader()
        {
            current = LibraryData.FindReaderByCode(LibraryData.CurrentReaderCode);
            if (current == null )
            {
                MessageBox.Show("Читатель не найден");
            }
        }

        // Дублирует частью BookCodeFromString из LibraryData - todo: заменить
        private int GetSelectedBookCode(ListBox list)
        {
            if (list.SelectedIndices.Count > 0)
            {
                string s = (list.SelectedItem.ToString().Split(' ', ';')[0]).Substring(1);
                int code = Convert.ToInt32(s);
                return code;
            }
            return -1;
        }

        // Вернуть книгу
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (MyBooksList.SelectedIndices.Count > 0)
            {
                int index = MyBooksList.SelectedIndex;
                current.ReturnBook(index);
                ShowMyBooks();
                ShowRetBooks();
                ShowBooks();
                LibraryData.ToFile();
            }
        }

        // Взять книгу
        private void GetBookBtn_Click(object sender, EventArgs e)
        {
            if (LibraryBooksList.SelectedIndices.Count > 0)
            {
                int code = GetSelectedBookCode(LibraryBooksList);
                // Если код книги найден
                if (code != -1)
                {
                    Book book = LibraryData.FindBookByCode(code);
                    // Если книга найдена
                    if (book != null)
                    {
                        current.GetBook(book);
                        book.ChangeStatus();
                    }
                }
                ShowMyBooks();
                ShowBooks();
                LibraryData.ToFile();
            }
        }

        // Показать доступные книги в списке
        private void ShowBooks()
        {
            if (LibraryBooksList != null && LibraryBooksList.Items.Count > 0)
            {
                LibraryBooksList.Items.Clear();

            }
            foreach (string s in LibraryData.GetAvailableBooks())
                LibraryBooksList.Items.Add(s);
        }

        // Показать книги читателя в списке
        private void ShowMyBooks()
        {
            if (MyBooksList != null && MyBooksList.Items.Count > 0)
            {
                MyBooksList.Items.Clear();

            }
            foreach (string s in current.GetBooks())
                MyBooksList.Items.Add(s);
        }

        // Показать книги, которые читатель вернул
        private void ShowRetBooks()
        {
            if (RetBooksList != null && RetBooksList.Items.Count > 0)
            {
                RetBooksList.Items.Clear();

            }
            foreach (string s in current.GetReturnedBooks())
                RetBooksList.Items.Add(s);
        }

        // Закрытие всего приложения
        private void ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Открыть форму поиска
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Form search = new SearchForm();
            search.Show();
        }

        // Вернуться на первую форму
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ReaderForm.ActiveForm.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
