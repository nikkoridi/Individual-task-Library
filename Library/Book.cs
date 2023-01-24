using System;
using System.Collections.Generic;

namespace Library
{
    [Serializable]
    internal class Book
    {
        int bookCode; // Код книги.
        public static int nextCode = 0; // Код для следующей книги
        string title; // Название
        string author; // Автор
        string description; // Описание
        bool isAvailable; // Есть ли в наличии

        // Очередь желающих
        List<Reader> wishing;

        public Book(string title = "Без_названия", string author = "Неизвестен",
            string description = "нет описания", bool available = true)
        {
            wishing = new List<Reader>();
            this.title = title;
            this.author = author;
            this.description = description;
            isAvailable = available;
            SetBookCode();
        }

        //// Свойства
        
        // Название
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // Автор
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // Описание
        public string Description
        {
            get { return description; }
            set { description = value; }   
        }

        // Доступность
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable= value; }
        }


        // Добавить читателя в очередь желающих
        public void AddReader(Reader reader)
        {
            if (!wishing.Contains(reader))
            {
                wishing.Add(reader);
            }
            else
                throw new Exception("Читатель уже в очереди на книгу");
        }

        // Удалить читателя из очереди желающих
        public void DelReader(Reader reader)
        {
            if (wishing.Contains(reader))
            {
                int index = wishing.IndexOf(reader);
                wishing.RemoveAt(index);
            }
        }

        // Изменить статус книги - доступна она или нет
        public void ChangeStatus()
        {
            isAvailable = !isAvailable;
        }

        // Сравнить две книги по их номерам-кодам
        public static bool CompareBooks(Book book1, Book book2)
        {
            return book1.GetBookCode() == book2.GetBookCode();
        }

        // Установить код книги
        public void SetBookCode()
        {
            bookCode = nextCode;
            nextCode++;
        }

        // Установить (начальный) код следующей книги
        public void SetNextCode(int n)
        {
            nextCode = n;
        }

        // Получить код книги
        public int GetBookCode()
        {
            return bookCode;
        }

        // Получить количество читателей из списка желающих
        public int WishingCount()
        {
            return wishing.Count;
        }

        // Получить первого читателя в очереди желающих
        public Reader GetFirstWishes()
        {
            return wishing.First();
        }

        // Получить список желающих - строками
        public List<string> GetWishing()
        {
            List<string> list = new List<string>();
            foreach (Reader reader in wishing)
            {
                list.Add(reader.ToString());
            }
            return list;
        }

        // Строка для записи в файл
        public String ToFileString()
        {
            return $"{GetBookCode()}; {title}; {author}; {description}; {isAvailable}";
        }

        // Строка - для интерфейса
        public override String ToString()
        {
            return $"№{GetBookCode()}; \n {title} - {author}; \n {(isAvailable ? "+" : "-")}";
        }

        // Строка, все данные - для интерфейса
        public String ToStringAllData()
        {
            return $"№{GetBookCode()}; \n {title} - {author}; \n Описание: {description}; \n {isAvailable}";
        }
    }
}
