using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Librarian:User
    {
        public int EmployeeNumber {  get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void AddBook(Book newBook, Library library)
        {
            library.AddBook(newBook);
        }
        public void RemoveBook(Book book, Library library)
        {
            library.RemoveBook(book);
        }
    }
}
