using System;
using System.Collections.Generic;

namespace Library
{
    [Serializable]
    internal class Reader
    {
        public static int nextCode = 0; // Номер следующего билета
        string name; // Имя
        string patronymic; // Отчество
        string surname; // Фамилия
        int cardCode; // Номер билета
        DateTime birthDate; // Дата рождения
        string phoneNumber; // Номер телефона

        // Список книг, которые в данный момент у читателя
        List<Book> curBooks;

        // Список книг, которые читатель вернул
        List<Book> retBooks;

        public Reader(string surname, string name, string patronymic, DateTime birth, string phone)
        {
            curBooks = new List<Book>();
            retBooks = new List<Book>();
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            birthDate = birth;
            phoneNumber = phone;
            SetCardCode();
        }

        // Узнать номер билета
        public int CardCode
        {
            get { return cardCode; }
        }

        // Вернуть книгу
        public void ReturnBook(int index)
        {
            Book book = curBooks[index];
            LibraryData.AddReturn(book);
            curBooks.RemoveAt(index);
            // Если книгу еще ни разу не возвращал - добавить ее в список возвращенных
            bool isNewBook = true;
            foreach (Book b in retBooks)
            {
                if(Book.CompareBooks(b, book))
                    isNewBook = false;
            }
            if (isNewBook)
            {
                retBooks.Add(book);
            }
        }

        // Взять книгу
        public void GetBook(Book book)
        {
            if (!curBooks.Contains(book))
                curBooks.Add(book);
        }

        // Задать/создать id
        public void SetCardCode()
        {
            cardCode = nextCode;
            nextCode++;
        }

        // Получить список книг читателя - строками
        public List<string> GetBooks()
        {
            List<string> list = new List<string>();
            foreach (Book book in curBooks)
                list.Add(book.ToString());
            return list;
        }

        // Получить список возвращенных книг - строками
        public List<string> GetReturnedBooks()
        {
            List<string> list = new List<string>();
            foreach (Book book in retBooks)
                list.Add(book.ToString());
            return list;
        }

        // Установить (начальный) номер билета следующего читателя
        public void SetNextCode(int n)
        {
            nextCode = n;
        }

        // Задать номер билета
        public int GetCardCode()
        {
            return cardCode;
        }

        // Строка для записи в файл
        public String ToFileString()
        {
            return $"{GetCardCode()}; {surname}; {name}; {patronymic}; {birthDate.Date}; {phoneNumber}";
        }

        // Строка для вывода на интерфейс
        public override String ToString()
        {
            return $"{GetCardCode()}: {surname} {name} {patronymic}";
        }
    }

}
