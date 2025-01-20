namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Library System");
            Console.WriteLine("Are you -Librarian- or regular -User- (L/R)");
            char userType = Console.ReadLine().ToUpper()[0];
            Library library = new Library();
            bool exit = false;
            if (userType == 'L')
            {
                Console.WriteLine("enter your name :");
                String Name = Console.ReadLine();

                Librarian librarian = new Librarian(Name);
                Console.WriteLine($"Welcom {librarian.Name:)}");

                while (!exit)
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("A. Add a Book");
                    Console.WriteLine("R. Remove a Book");
                    Console.WriteLine("D. Display All Books");
                    Console.WriteLine("E. Exit");
                    Console.Write("Choose an option(A/R/D/E): ");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.Write("Enter Book Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            int year = int.Parse(Console.ReadLine());

                            Book book = new Book() { Title = title, Author = author, Year = year };
                            librarian.Add(book, library);
                            break;
                        case 'R':
                            Console.Write("Enter Book Title: ");
                            title = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            author = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            year = int.Parse(Console.ReadLine());
                            Book bookr = new Book() { Title = title, Author = author, Year = year };
                            librarian.Remove(bookr, library);
                            break;
                        case 'D':
                            librarian.DisplayBooks(library);
                            break;
                        case 'E':
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
            }
            else if (userType == 'R')
            {
                Console.WriteLine("enter your name :");
                String Name = Console.ReadLine();

                Customer customer = new Customer(Name);
                Console.WriteLine($"Welcom {customer.Name:)}");
                Console.WriteLine("Welcome User");
                while (!exit)
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("B. Borrow a Book");
                    Console.WriteLine("R. Return a Book");
                    Console.WriteLine("3. Display All Books");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option: ");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'B':
                            Console.Write("Enter Book Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            int year = int.Parse(Console.ReadLine());

                            Book book = new Book() { Title = title, Author = author, Year = year };
                            customer.Borrow(book, library);
                            break;
                        case 'R':
                            Console.Write("Enter Book Title: ");
                            title = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            author = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            year = int.Parse(Console.ReadLine());

                            Book book1 = new Book() { Title = title, Author = author, Year = year };
                            customer.Return(book1, library);
                            break;
                        case 'D':
                            customer.DisplayBooks(library);
                            break;
                        case 'E':
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }                           
            }
            else
            {
                Console.WriteLine("please enter valid choess");
            }
        }
    }
}
