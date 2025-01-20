using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        public Book[] books = new Book[100];
        private Book[] Borrowbooks = new Book[75];
        public int Count =0;
        public int CountB =0;

        public void Add(Book book)
        {
            if (Count < books.Length)
            {
                books[Count++] = book;
                Console.WriteLine("Book successfully added to the library.");
            }
            else
            {
                Console.WriteLine("Library is full, cannot add more books.");
            }
        }
        public void Remove(Book book)
        {
                int i= Array.IndexOf(books, book);
            if (i == -1)
            {
                Console.WriteLine("The book is not available in the library.");
            }
            else
            {
                books[i] = null;
                Count--;
                Console.WriteLine("Book successfully removed from the library.");

            }
        }
        public void DisplayBooks()
        {
            if (Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            Console.WriteLine("Books in the Library:");
            for (int i=0;i< Count; i++)
            {
                Console.WriteLine(books[0].Title );
            }
        }
        public void Borrow(Book book)
        {
            int i = Array.IndexOf(Borrowbooks, book);
            if (i == -1)
            {
                Console.WriteLine("The book is not available in the library.");
            }
            else
            {
                {
                    if (CountB < Borrowbooks.Length)
                    {
                        Borrowbooks[CountB++] = book;
                        Remove(book);
                        Console.WriteLine($"You have successfully borrowed the book: {book.Title}");
                    }
                    else
                    {
                        Console.WriteLine("Borrow limit reached. Cannot borrow more books.");
                    }
                }
            }
        }
        public void Return(Book book)
        {
            int i = Array.IndexOf(books, book);
            if (i != -1)
            {
                Console.WriteLine("The book is not borrowed or already returned.");
            }
            else
            {
                this.Add(book);
                books[i] = null;
                Count--;
                Console.WriteLine($"You have successfully returned the book: {book.Title}");
            }
        }

    }
}
