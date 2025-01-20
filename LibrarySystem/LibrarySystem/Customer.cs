using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Customer : User
    {
        public Customer(String Name) { this.Name = Name; }
        public LibraryCard Card { get; set; }
        public void Borrow(Book book,Library library)
        {
            library.Borrow(book);
        }
        public void Return(Book book,Library library)
        {
            library.Borrow(book);
        }


    }
}
