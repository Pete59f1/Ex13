using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Allan
    {
        public void Start()
        {
            Book book1 = new Book("Hej Verden");
            Book book2 = new Book("Hej Eal");
            Book book3 = new Book("Hej Allan");

            Kontroller kon = new Kontroller();
            kon.addBook(book1);
            kon.addBook(book2);
            kon.addBook(book3);

            kon.getBook(0);
            kon.getBook(1);
            kon.getBook(2);

            Print(book1);
            Print(book2);
            Print(book3);
        }

        public void Print(Book book)
        {
            Console.WriteLine(book.Title);
        }
    }
}
