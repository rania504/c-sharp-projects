using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class LibraryUser:User
    {
        public LibraryCard Card { get; set; }


        public void BrrowBook(Book book,Library library)
        {
            library.BorrowBook(book);
        }
    }
}
