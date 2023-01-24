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
    }
}
