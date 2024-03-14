using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            // Create book objects as per instructions
            book book1 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book1.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book1.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book1.SetAuthor(Console.ReadLine());

            book book2 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book2.SetAuthor(Console.ReadLine());

            book book3 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book3.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book3.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book3.SetAuthor(Console.ReadLine());

            book book4 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book4.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book4.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book4.SetAuthor(Console.ReadLine());

            // Call displayBooks method for each book
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        // Method to display book information
        static void displayBooks(book book)
        {
            Console.WriteLine("Here's your book information:");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
            Console.WriteLine();
        }
    }

    class book
    {
        // Private fields
        private int _Id;
        private string _Title;
        private string _Author;

        // Default constructor
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        // Parameterized constructor
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        // Get and Set methods for _Id field
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        // Get and Set methods for _Title field
        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        // Get and Set methods for _Author field
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
}




