using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Kontroller
    {
        private List<Book> bookTitles = new List<Book>();

        public void addBook(Book book)
        {
            bookTitles.Add(book);
        }

        public Book getBook(int index)
        {
            return bookTitles[index];
        }
    }
}
