using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt
{
    internal class Library
    {
        private List<Book> books;

        public Library() 
        {
            books = new List<Book>();
        }

        public void addBook(Book book)
        { 
            books.Add(book); 
        }

        public void removeBook(Book book) 
        {
            books.Remove(book);
        }

        public void viewBooks() 
        {
            foreach (var book in books) 
            {
                Console.WriteLine(book.BookTitle());
            }
        }
    }
}
