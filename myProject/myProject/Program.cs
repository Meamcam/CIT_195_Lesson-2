using System;

namespace myProject
{
    class myComicShop
    {
        static void Main(string[] args)
        {
            Comic book1 = new Comic();
            Console.WriteLine("Please enter a comic book series title: ");
            book1.SetSeries(Console.ReadLine());
            Console.WriteLine("Please enter the issue #: ");
            book1.SetIssueNum(Console.ReadLine());
            Console.WriteLine("Please enter the comic author: ");
            book1.SetAuthor(Console.ReadLine());
            Console.WriteLine("Please enter the comic artist: ");
            book1.SetArtist(Console.ReadLine());

            Comic book2 = new Comic();
            Console.WriteLine("Please enter a comic book series title: ");
            book2.SetSeries(Console.ReadLine());
            Console.WriteLine("Please enter the issue #: ");
            book2.SetIssueNum(Console.ReadLine());
            Console.WriteLine("Please enter the comic author: ");
            book2.SetAuthor(Console.ReadLine());
            Console.WriteLine("Please enter the comic artist: ");
            book2.SetArtist(Console.ReadLine());

            Comic book3 = new Comic();
            Console.WriteLine("Please enter a comic book series title: ");
            book3.SetSeries(Console.ReadLine());
            Console.WriteLine("Please enter the issue #: ");
            book3.SetIssueNum(Console.ReadLine());
            Console.WriteLine("Please enter the comic author: ");
            book3.SetAuthor(Console.ReadLine());
            Console.WriteLine("Please enter the comic artist: ");
            book3.SetArtist(Console.ReadLine());

            Comic book4 = new Comic();
            Console.WriteLine("Please enter a comic book series title: ");
            book4.SetSeries(Console.ReadLine());
            Console.WriteLine("Please enter the issue #: ");
            book4.SetIssueNum(Console.ReadLine());
            Console.WriteLine("Please enter the comic author: ");
            book4.SetAuthor(Console.ReadLine());
            Console.WriteLine("Please enter the comic artist: ");
            book4.SetArtist(Console.ReadLine());

            // Call displayBooks method for each comic
            DisplayBooks(book1);
            DisplayBooks(book2);
            DisplayBooks(book3);
            DisplayBooks(book4);
        }

        // Method to display comic information
        static void DisplayBooks(Comic book)
        {
            Console.WriteLine("Here's your comic information:");
            Console.WriteLine($"Comic Series Title: {book.GetSeries()}");
            Console.WriteLine($"Issue #: {book.GetIssueNum()}");
            Console.WriteLine($"Comic Author: {book.GetAuthor()}");
            Console.WriteLine($"Comic Artist: {book.GetArtist()}");
            Console.WriteLine();
        }
    }

    class Comic
    {
        // Private fields
        private string _Series;
        private string _IssueNum;
        private string _Author;
        private string _Artist;

        // Default constructor
        public Comic()
        {
            _Series = "";
            _IssueNum = "";
            _Author = "";
            _Artist = "";
        }

        // Get and Set methods for Series field
        public string GetSeries()
        {
            return _Series;
        }

        public void SetSeries(string series)
        {
            _Series = series;
        }

        // Get and Set methods for IssueNum field
        public string GetIssueNum()
        {
            return _IssueNum;
        }

        public void SetIssueNum(string issueNum)
        {
            _IssueNum = issueNum;
        }

        // Get and Set methods for Author field
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        // Get and Set methods for Artist field
        public string GetArtist()
        {
            return _Artist;
        }

        public void SetArtist(string artist)
        {
            _Artist = artist;
        }
    }
}
