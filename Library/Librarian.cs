using System;
using System.Collections.Generic;

namespace Library
{
    internal class Librarian
    {

        // Добавить книгу
        public void AddBook(Book book)
        {
            LibraryData.AddBook(book);
            LibraryData.ToFile();
        }

        // Править книгу
        public void EditBook(int index, Book book)
        {
            LibraryData.EditBook(index, book);
            LibraryData.ToFile();
        }

        // Удалить книгу
        public void DelBook(int index)
        {
            LibraryData.DelBook(index);
            LibraryData.ToFile();
        }

        // Вернуть книгу в библиотеку
        public void ReturnBook(int index)
        {
            LibraryData.ReturnBook(index);
            LibraryData.ToFile();
        }

        // Передать книгу следующему читателю
        public void GetToNextReader(int indexReturn, string bookString)
        {
            Book book = LibraryData.FindBookByCode(LibraryData.BookCodeFromString(bookString));
            if (book.WishingCount() > 0)
            {
                Reader reader = LibraryData.FindReaderByCode(book.GetFirstWishes().GetCardCode());
                reader.GetBook(book);
                book.DelReader(reader);
                LibraryData.DelReturn(indexReturn);
                LibraryData.ToFile();
            }
            else
                throw new Exception("Нет желающих получить книгу");
        }

        // Изменить статус книги
        public void ChangeBookStatus(int index)
        {
            LibraryData.ChangeBookStatus(index);
            LibraryData.ToFile();
        }

        // Отметить заявку как выполненную (она удалится)
        public void DoneRequest(string request)
        {
            LibraryData.RemoveRequest(request);
            LibraryData.ToFile();
        }
    }
}
