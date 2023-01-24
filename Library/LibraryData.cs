using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Library
{
    //[Serializable]

    /* Статический класс, который хранит все данные между формами */
    internal static class LibraryData
    {
        // Название библиотеки
        public static string name = "Библиотека";
        // Список всех книг
        private static List<Book> books;
        // Список всех читателей
        private static List<Reader> readers;
        // Книги, которые читатели вернули, но библиотекарь еще не оформил
        private static List<Book> returned;
        // Запросы на новые, недоступные книги
        private static List<string> requests;
        
        private static string readersFile = "readers.txt"; // Файл читателей
        private static string booksFile = "books.txt"; // Файл книг
        private static string returnedFile = "return.txt"; // Файл возвращенных книг
        private static string requestsFile = "requests.txt"; // Файл заявок

        // Номер билета текущего читателя
        private static int currentReaderCode = 0;

        static LibraryData()
        {
            books = new List<Book>();
            readers = new List<Reader>();
            returned = new List<Book>();
            requests = new List<string>();
        }

        // Получить/установить номер билета текущего читателя
        public static int CurrentReaderCode
        {
            get { return currentReaderCode; }
            set { currentReaderCode = value; }
        }

        // Положить книгу к возвращенным
        public static void AddReturn(Book book)
        {
            returned.Add(book);
        }

        // Убрать книгу из возвращенных, переложить ее ко всем (просто меняем ее статус)
        public static void ReturnBook(int index)
        {
            Book book = returned[index];
            DelReturn(index);
            Book book2 = FindBookByCode(BookCodeFromString(book.ToString()));
            book2.ChangeStatus();

        }

        // Удалить книгу из списка возвращенных (по ее индексу)
        public static void DelReturn(int index)
        {
            returned.RemoveAt(index);
        }

        // Добавить читатаеля
        public static void AddReader(Reader reader)
        {
            readers.Add(reader);
        }

        // Найти читателя по его номеру билета
        public static Reader FindReaderByCode(int code)
        {
            foreach (Reader reader in readers)
            {
                if (reader.GetCardCode() == code)
                {
                    return reader;
                }
            }
            return null;
        }

        // Получить код книги из строки книги
        public static int BookCodeFromString(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                string s = (text.Substring(0).Split(' ', ';', '-')[0]).Substring(1);
                int code = Convert.ToInt32(s);
                return code;
            }
            return -1;
        }

        // Поиск книги с 3 вариантами
        public static List<Book> FindBookByString(int mode, string[] text)
        {
            /*
             0 - поиск по автору
             1 - по названию
             2 - по автору и названию
             */
            List<Book> finded = new List<Book>();
            switch (mode)
            {
                case 0:
                    {
                        foreach (Book book in books)
                        {
                            if (book.Author.ToLower().Contains(text[0].ToLower()))
                            {
                                finded.Add(book);
                            }
                        }
                        return finded;
                    }
                case 1:
                    {
                        foreach (Book book in books)
                        {
                            if (book.Title.ToLower().Contains(text[0].ToLower()))
                            {
                                finded.Add(book);
                            }
                        }
                        return finded;
                    }
                case 2:
                    {
                        foreach (Book book in books)
                        {
                            if (book.Author.ToLower().Contains(text[0].ToLower()) && book.Title.ToLower().Contains(text[1].ToLower()))
                            {
                                finded.Add(book);
                            }
                        }
                        return finded;
                    }
            }
            return finded;
        }

        // Найти книгу по ее номеру
        public static Book FindBookByCode(int code)
        {
            // Тут должен быть хороший алгоритм поиска
            // Но пока линейный
            foreach (Book book in books)
            {
                if (code == book.GetBookCode())
                    return book;
            }
            return null;
        }

        // Изменить статус книги
        public static void ChangeBookStatus(int index)
        {
            books[index].ChangeStatus();
        }

        // Добавить новую книгу
        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        // Получить книгу по ее индексу в списке книг
        public static Book GetBook(int index)
        {
            books[index].ChangeStatus();
            return books[index];
        }

        // Изменить параметры книги - у книги по индексу, данные беруться у второго объекта
        public static void EditBook(int index, Book book)
        {
            books[index].IsAvailable = book.IsAvailable;
            books[index].Title = book.Title;
            books[index].Author = book.Author;
            books[index].Description = book.Description;
        }

        // Удалить книгу
        public static void DelBook(int index)
        {
            books.RemoveAt(index);
        }

        // Добавить заявку
        public static void AddRequest(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                requests.Add(text);
            }
        }

        // Удалить заявку
        public static void RemoveRequest(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                requests.Remove(text);
            }
        }

        // Получить текст заявки (по ее индексу)
        public static string GetRequestMessage(int index)
        {
            return requests[index];
        }

        // Получить список заявок - строками
        public static List<string> GetRequests()
        {
            return requests;
        }

        // Получить список читателей - строками
        public static List<string> GetReaders()
        {
            List<string> list = new List<string>();
            foreach (Reader reader in readers)
                list.Add(reader.ToFileString());
            return list;
        }

        // Получить список книг - строками
        public static List<string> GetBooks()
        {
            List<string> list = new List<string>();
            foreach (Book book in books)
                list.Add(book.ToString());
            return list;
        }

        // Получить список возвращенных книг - строками
        public static List<string> GetReturned()
        {
            List<string> list = new List<string>();
            foreach (Book book in returned)
                list.Add(book.ToString());
            return list;
        }

        // Получить список только доступных книг - строками
        public static List<string> GetAvailableBooks()
        {
            List<string> list = new List<string>();
            foreach (Book book in books)
            {
                if(book.IsAvailable)
                    list.Add(book.ToString());
            }
            return list;
        }

        // Восстановить данные из файлов
        public static void FromFile()
        {
            try
            {
                if (!String.IsNullOrEmpty(readersFile))
                {
                    BinaryFormatter bf = new BinaryFormatter();

                    // Читатели
                    using (FileStream fs = new FileStream(readersFile, FileMode.Open))
                    {
                        List<Reader> reader = (List<Reader>)bf.Deserialize(fs);
                        readers = reader;
                    }
                    int index = (readers.Count - 1 >= 0) ? readers.Count - 1 : 0;
                    readers[0].SetNextCode(readers[index].GetCardCode() + 1);

                    // Книги
                    using (FileStream fs = new FileStream(booksFile, FileMode.Open))
                    {
                        List<Book> book = (List<Book>)bf.Deserialize(fs);
                        books = book;
                    }
                    index = (books.Count - 1 >= 0) ? books.Count - 1 : 0;
                    books[0].SetNextCode(books[index].GetBookCode() + 1);

                    // Возвращенные книги
                    using (FileStream fs = new FileStream(returnedFile, FileMode.Open))
                    {
                        List<Book> returnedBooks = (List<Book>)bf.Deserialize(fs);
                        returned = returnedBooks;
                    }

                    // Заявки
                    using (FileStream fs = new FileStream(requestsFile, FileMode.Open))
                    {
                        requests = (List<string>)bf.Deserialize(fs);
                    }
                }
                else
                    Console.WriteLine("Один или несколько файлов не найдены/повреждены");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Сохранить данные в файлы.
        public static void ToFile()
        {
            if (!String.IsNullOrEmpty(readersFile) && !String.IsNullOrEmpty(booksFile))
            {
                BinaryFormatter bf = new BinaryFormatter();
                // Читатели
                using (FileStream fs = new FileStream(readersFile, FileMode.Create))
                {
                    bf.Serialize(fs, readers);
                }

                // Книги
                using (FileStream fs = new FileStream(booksFile, FileMode.Create))
                {
                    bf.Serialize(fs, books);
                }

                // Возвращенные книги
                using (FileStream fs = new FileStream(returnedFile, FileMode.Create))
                {
                    bf.Serialize(fs, returned);
                }

                // Заявки
                using (FileStream fs = new FileStream(requestsFile, FileMode.Create))
                {
                    bf.Serialize(fs, requests);
                }
            }
                else
                    Console.WriteLine("Строка пустая");
        }
    }
}
