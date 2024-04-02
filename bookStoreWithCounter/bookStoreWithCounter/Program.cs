using System;

namespace bookStoreWithCount
{
    class myStore
    {
        static void Main(string[] args)
        {
            // creates a new book object
            book book1 = new book();
            book1.SetId(101);
            book1.SetTitle("Neil Gaiman");
            book1.SetAuthor("American Gods");
            book1.SetTrans(); // Add transaction count

            book book2 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book's author: ");
            book2.SetAuthor(Console.ReadLine());
            book2.SetTrans(); // Add transaction count

            book book3 = new book(102, "A People's History of the United States", "Howard Zinn");
            book3.SetTrans(); // Add transaction count

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);
            book4.SetTrans(); // Add transaction count

            // Display book info
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);

            // Display total number of transactions
            Console.WriteLine($"Total transactions: {book.GetTrans()}");
        }

        // Method to display the book's info
        static void displayBooks(book book)
        {
            Console.WriteLine("Here's the book info");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Title: {book.GetTitle()}");
            Console.WriteLine($"Author: {book.GetAuthor()}");
        }
    }

    class book
    {
        // Private fields
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0; // Static field for transactions

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

        // Get and Set methods for the _Title field
        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        // Get and Set methods for the _Author field
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        // Get and Set methods for the _transactions field
        public static int GetTrans()
        {
            return _transactions;
        }

        public void SetTrans()
        {
            _transactions++;
        }
    }
}
