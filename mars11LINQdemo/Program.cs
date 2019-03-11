using System;
using System.Linq;

namespace mars11LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new[]
            {
                new Book { Title = "Simarillion", PageCount = 365 },
                new Book { Title = "Sagan om Ringen", PageCount = 700 },
                new Book { Title = "Bilbo", PageCount = 250 },
            };
            //Array.Sort(books);
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Title);
            //}

            //Query syntax
            var longBooks = from b in books
                            where b.PageCount > 300
                            orderby b.Title
                            select b.PageCount;

            //method syntax
            var longbooks2 = books.Where(b => b.PageCount > 300).OrderBy(b => b.Title).ToList();

            //summa
            var sum = books.Sum(b => b.PageCount).ToString();
            Console.WriteLine(sum);

            foreach (var item in longBooks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in longbooks2)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
    }
}
