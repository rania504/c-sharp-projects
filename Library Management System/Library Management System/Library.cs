using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<Book> borrowedBooks = new List<Book>();
        private const string FilePath = "books.json";

        // Constructor to load books from file when the library is created
        public Library()
        {
            LoadBooks();
        }
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            SaveBooks(); // Save the updated list to the file
            Console.WriteLine($"Book added successfully: {book.Title}");
        }
        public void RemoveBook(Book book)
        {
            if (books.Remove(book))
            {
                SaveBooks(); // Save the updated list to the file
                Console.WriteLine($"Book removed successfully: {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }
        }
        public void BorrowBook(Book book)
        {
            if (books.Contains(book))
            {
                borrowedBooks.Add(book);
                books.Remove(book);
                SaveBooks(); // Save the updated list to the file
                Console.WriteLine($"Book borrowed successfully: {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not available in the library.");
            }
        }
        // Method to save books to a JSON file
        private void SaveBooks()
        {
            try
            {
                string json = JsonSerializer.Serialize(books);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving books: {ex.Message}");
            }
        }
        // Method to load books from a JSON file
        private void LoadBooks()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    string json = File.ReadAllText(FilePath);
                    books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading books: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No existing book data found. Starting with an empty library.");
            }
        }
    }
}
