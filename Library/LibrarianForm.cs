using System;
using System.Collections.Generic;

namespace Library
{
    public partial class LibrarianForm : Form
    {
        Librarian l;
        public LibrarianForm()
        {
            InitializeComponent();
            OnInit();
        }

        // Добавление данных формы при загрузке
        private void OnInit()
        {
            ShowBooks();
            ShowReturnedBooks();
            ShowRequests();
            ShowReaders();
            l = new Librarian();
        }

        private void ShowReaders()
        {
            foreach (string s in LibraryData.GetReaders())
                ReadersList.Items.Add(s);
        }

        // Состояние чекбокса доступности книги
        private bool GetCheckAvailable()
        {
            return AvailableСheck.Checked;
        }

        // Вывод всех книг из библиотеки
        private void ShowBooks()
        {
            if (BooksList != null && BooksList.Items.Count > 0)
                BooksList.Items.Clear();
            foreach (string s in LibraryData.GetBooks())
                BooksList.Items.Add(s);
        }

        // Вывод возвращенных книг
        private void ShowReturnedBooks()
        {
            if (ReturnedBooksList != null && ReturnedBooksList.Items.Count > 0)
                ReturnedBooksList.Items.Clear();
            foreach (string s in LibraryData.GetReturned())
                ReturnedBooksList.Items.Add(s);
        }

        // Вывод заявок
        private void ShowRequests()
        {
            if (RequestList != null && RequestList.Items.Count > 0)
                RequestList.Items.Clear();
            foreach (string s in LibraryData.GetRequests())
                RequestList.Items.Add(s);
        }

        // Добавление новой книги - кнопка
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddNewBook();
        }

        // Добавление новой книги - метод
        private void AddNewBook()
        {
            bool textFieldsCheck = NameField.Text.Length > 0 && AuthorField.Text.Length > 0 && DescriptionField.Text.Length > 0;
            try
            {
                if (!textFieldsCheck)
                    MessageBox.Show("Необходио ввести название, автора и описание", "Ошибка");
                else
                {
                    Book book = new Book(NameField.Text, AuthorField.Text, DescriptionField.Text, true);
                    l.AddBook(book);
                    ShowBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Непредвиденая ошибка");
            }
        }

        // Правка книги
        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksList.SelectedItems.Count > 0)
            {
                bool textFieldsCheck = NameField.Text.Length > 0 && AuthorField.Text.Length > 0 && DescriptionField.Text.Length > 0;
                if (!textFieldsCheck)
                    MessageBox.Show("Необходио ввести название, автора и описание", "Ошибка");
                else
                {
                    Book book = new Book(NameField.Text, AuthorField.Text, DescriptionField.Text, GetCheckAvailable());
                    l.EditBook(BooksList.SelectedIndex, book);
                }
                ShowBooks();
            }
        }

        // Удаление книги
        private void DelBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksList.SelectedItems.Count > 0)
            {
                l.DelBook(BooksList.SelectedIndex);
            }
        }

        // Посмотреть описание книги
        private void ViewDescription_Click(object sender, EventArgs e)
        {
            if (BooksList.SelectedItems.Count > 0)
            {
                Book book = LibraryData.FindBookByCode(BooksList.SelectedIndex);
                if (book != null)
                    MessageBox.Show(book.Description);
            }
        }

        // Посмотреть список читателей из очереди к книге
        private void ViewWishing_Click(object sender, EventArgs e)
        {
            if (BooksList.SelectedItems.Count > 0)
            {
                Book book = LibraryData.FindBookByCode(BooksList.SelectedIndex);
                if (book != null)
                {
                    string list = "";
                    foreach (string s in book.GetWishing())
                    {
                        list += s + "\n";
                    }
                    MessageBox.Show(list);
                }
                    
            }
        }

        // Вернуть книгу в библиотеку
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (ReturnedBooksList.SelectedItems.Count > 0)
            {
                l.ReturnBook(ReturnedBooksList.SelectedIndex);
                ShowBooks();
                ShowReturnedBooks();
            }
        }

        // Изменить доступность книги
        private void ChangeBookStatusBtn_Click(object sender, EventArgs e)
        {
            if (BooksList.SelectedItems.Count > 0)
            {
                LibraryData.ChangeBookStatus(BooksList.SelectedIndex);
                ShowBooks();
                LibraryData.ToFile();
            }
        }

        // Передать книгу первому читателю в очереди
        private void GetToNextBtn_Click(object sender, EventArgs e)
        {
            if (ReturnedBooksList.SelectedItems.Count > 0)
            {
                Book book = LibraryData.FindBookByCode(LibraryData.BookCodeFromString(ReturnedBooksList.SelectedItem.ToString()));
                if (book.WishingCount() > 0)
                {
                    Reader reader = book.GetFirstWishes();
                    reader.GetBook(book);
                    book.DelReader(reader);
                    LibraryData.DelReturn(ReturnedBooksList.SelectedIndex);
                    LibraryData.ToFile();
                    ShowBooks();
                    ShowReturnedBooks();
                }
                else
                    MessageBox.Show("Нет желающих получить книгу", "Ошибка");
            }
        }

        // Отметить заявку как выполненную
        private void DoneRequestBtn_Click(object sender, EventArgs e)
        {
            if (RequestList.SelectedItems.Count > 0)
            {
                LibraryData.RemoveRequest(RequestList.SelectedItem.ToString());
                ShowRequests();
                LibraryData.ToFile();
            }
        }

        // Посмотреть текст заявки
        private void ViewRequestBtn_Click(object sender, EventArgs e)
        {
            if (RequestList.SelectedItems.Count > 0)
            {
                MessageBox.Show(LibraryData.GetRequestMessage(RequestList.SelectedIndex), "Текст запроса");
            }
        }

        // Возврат на первую форму
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            LibrarianForm.ActiveForm.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        // Выход из приложения
        private void LibrarianForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
