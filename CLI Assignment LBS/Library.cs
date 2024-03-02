using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Assignment_LBS
{
    internal class Library
    {
        private List<Book> books;
        private List<Member> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public void addBook(Book book)
        {
            books.Add(book);
        }

        public void removeBook(Book book)
        {
            books.Remove(book);
        }

        public void addMember(Member member)
        {
            members.Add(member);
        }

        public void removeMember(Member member)
        {
            members.Remove(member);
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
