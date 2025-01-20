using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : User
    {
        public Librarian(string Name) 
        { 
            this.Name = Name; 
        }
        public int EmploeeyNum { get; set; }
        public void Add(Book book,Library library)
        {
            library.Add(book);
        }
        public void Remove(Book book, Library library)
        {
            library.Remove(book);
        }
    }
}
