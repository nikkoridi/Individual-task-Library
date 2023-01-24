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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            OnInit();
        }

        private void OnInit()
        {
            AuthorField.Enabled = false;
            TitleField.Enabled = false;
            SearchBtn.Enabled = false;
            NotFoundPanel.Visible = false;
            SearchButtonEnable();
        }

        // Отображение найденных книг в списке
        private void ShowFindBooks(List<Book> books)
        {
            if (FindBooksList.Items.Count > 0)
                FindBooksList.Items.Clear();
            if (books.Count > 0)
            {
                foreach (Book book in books)
                {
                    FindBooksList.Items.Add(book.ToString());
                }
            }
        }

        // Переключение активности кнопки поиска
        // Если ни один из чекбоксов не выбран, то она неактивна
        private void SearchButtonEnable()
        {
            SearchBtn.Enabled = AuthorCheck.Checked || TitleCheck.Checked;
        }

        // Активность поля ввода автора
        private void AuthorCheck_CheckStateChanged(object sender, EventArgs e)
        {
            AuthorField.Enabled = AuthorCheck.Checked;
            SearchButtonEnable();
        }

        // Активность поля ввода названия
        private void TitleCheck_CheckStateChanged(object sender, EventArgs e)
        {
            TitleField.Enabled = TitleCheck.Checked;
            SearchButtonEnable();
        }

        // Кнопка запуска поиска
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int mode = Convert.ToInt16(AuthorCheck.Checked) + Convert.ToInt16(TitleCheck.Checked);
            List<Book> b = null;
            if (AuthorCheck.Checked && !TitleCheck.Checked)
            {
                b = LibraryData.FindBookByString(0, new string[] { AuthorField.Text });
            }
            else if (TitleCheck.Checked && !AuthorCheck.Checked)
            {
                b = LibraryData.FindBookByString(1, new string[] { TitleField.Text });
            }
            else if (AuthorCheck.Checked && TitleCheck.Checked)
            {
                b = LibraryData.FindBookByString(2, new string[] { AuthorField.Text, TitleField.Text });
                
            }

            if (b != null && b.Count > 0)
            {
                ShowFindBooks(b);
                if (NotFoundPanel.Visible)
                    NotFoundPanel.Visible = false;
            }
            else
            {
                NotFoundPanel.Visible = true;
            }
        }

        // Добавиться в список желающих книгу
        private void WishBtn_Click(object sender, EventArgs e)
        {
            if (FindBooksList.SelectedItems.Count > 0)
            {
                int code = LibraryData.BookCodeFromString(FindBooksList.SelectedItem.ToString());
                // Если код книги верен
                if (code != -1)
                {
                    Book book = LibraryData.FindBookByCode(code);

                    // Если книга найдена
                    if (book != null)
                    {

                        // Если она недоступна
                        if (!book.IsAvailable)
                        {
                            // Может ли быть тут CurrentReader = null? Я думаю, что проверка в ReaderInForm этого не допустит

                            // Исключение: если читатель уже в очереди
                            try
                            {
                                book.AddReader(LibraryData.FindReaderByCode(LibraryData.CurrentReaderCode));
                                LibraryData.ToFile();
                                MessageBox.Show("Запрос оформлен! \n (Книга пока на руках.)");
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            
                        }
                        else
                            MessageBox.Show("Книга доступна, не нужно вставать в очередь", "Книга доступна");
                    }
                }
            }
            else
            {
                // Книги нет в этой библиотеке
                // Предложим читателю написать текст заявки, она попадет в список таких заявок в LibraryData
                // Дальше уже библотекарь будет создавать книгу и добавлять ее в библиотеку
                ToRequestForm();
            }
        }

        // Переход на форму заявки 
        private void ToRequestForm()
        {
            RequestForm requestForm = new RequestForm();
            requestForm.Show();
        }

        // Кнопка перехода на форму заявки
        private void RequestBtn_Click(object sender, EventArgs e)
        {
            ToRequestForm();
        }
    }
}
