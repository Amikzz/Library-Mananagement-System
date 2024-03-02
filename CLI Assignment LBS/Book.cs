using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Assignment_LBS
{
    internal class Book
    {
        private string bookTitle;
        private string bookAuthor;
        private int bookISBN;
        private bool bookAvailbility;

        public Book(string title, string author, int ISBN, bool availability)
        {
            bookTitle = title;
            bookAuthor = author;
            bookISBN = ISBN;
            bookAvailbility = availability;
        }

        public Book(string title, int ISBN)
        {
            bookTitle = title;
            bookISBN = ISBN;
        }

        public string BookTitle()
        {
            return bookTitle;
        }
    }
}
