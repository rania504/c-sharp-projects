namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Welcome To The Library System!");
            Console.Write("Are you a Librarian or Regular user (L / R): ");
            char userType = Console.ReadLine().ToUpper()[0];

            if (userType == 'L')
            {
                Console.Write("Please enter your name: ");
                string librarianName = Console.ReadLine();

                Librarian librarian = new Librarian(librarianName);

                Console.WriteLine($"Welcome {librarian.Name}");
                while (true)
                {
                    Console.WriteLine("Add books (A) / Remove books (R) / Display books (D) / Exit (E)");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details:");
                            Console.Write("Title: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Book year: ");
                            int bookYear = int.Parse(Console.ReadLine());

                            Book book = new Book { Title = bookName, Author = bookAuthor, Year = bookYear };
                            librarian.AddBook(book, library);
                            break;
                        case 'R':
                            Console.WriteLine("Enter book details to remove:");
                            Console.Write("Title: ");
                            bookName = Console.ReadLine();
                            Console.Write("Author: ");
                            bookAuthor = Console.ReadLine();
                            Console.Write("Book year: ");
                            bookYear = int.Parse(Console.ReadLine());

                            book = new Book { Title = bookName, Author = bookAuthor, Year = bookYear };
                            librarian.RemoveBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The book list:");
                            librarian.DisplayBooks(library);
                            break;
                        case 'E':
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            else if (userType == 'R')
            {
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();

                LibraryUser user = new LibraryUser { Name = userName };
                Console.WriteLine($"Welcome {user.Name}");
                while (true)
                {
                    Console.WriteLine("Display books (D) / Borrow books (B) / Exit (E)");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'B':
                            Console.WriteLine("Enter book details to borrow:");
                            Console.Write("Title: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Author: ");
                            string bookAuthor = Console.ReadLine();
                            

                            Book book = new Book { Title = bookName, Author = bookAuthor };
                            user.BrrowBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The book list:");
                            user.DisplayBooks(library);
                            break;
                        case 'E':
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You must enter 'L' for Librarian or 'R' for Regular user.");
            }

        }
    }
}
