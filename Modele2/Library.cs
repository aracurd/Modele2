using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele2
{
    class Library: ILibraryUser
    {
        public List<Book> LibraryBooks { get; set; }
        public Library()
        {
            LibraryBooks = new List<Book>()
            {
                new Book() {BookName = "Book1", BookWriter = "Writer1", Count = 3},
                new Book() {BookName = "Book3", BookWriter = "Writer4", Count = 1 },
                new Book() {BookName = "Book2", BookWriter = "Writer2", Count = 2 },
            };
        }

        public void AddBook(string name, string author, int bookCounts)
        {
            LibraryBooks.Add(new Book() {BookName = name, BookWriter = author});
        }

        public void RemoveBook(string name)
        {
            var book = LibraryBooks.Find(book1 => book1.BookName.Contains(name));
            LibraryBooks.Remove(book);
        }

        public void BookInfo(string name)
        {

            var book = LibraryBooks.Find(book1 => book1.BookName.Contains(name));

            Console.WriteLine($"Название: {book.BookName} Автор: {book.BookWriter} Количество книг: {book.Count}");
        }

        public void BookCount(string name) 
        {
            var book = LibraryBooks.Find(book1 => book1.BookName.Contains(name));
            Console.WriteLine($"Название: {book.BookName} В наличии: {book.Count}");
        }

        public void ShoveAllBookInLib()
        {
            foreach (var book in LibraryBooks)
                Console.WriteLine($"Название: {book.BookName} Автор: {book.BookWriter} Количество книг: {book.Count}");
        }

        public Book this[int i]
        {
            get { return LibraryBooks[i]; }
            set { LibraryBooks[i] = value; }
        }
        EnvironmentVariableTarget lile = new 
    }
}
