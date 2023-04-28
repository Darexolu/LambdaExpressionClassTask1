using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LambdaExpressionClassTask1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public static void ViewAllBooks(IList<Book> books)
        {
            var viewallbooks = books.Where(s => s.Title != null && s.Author != null && s.Price != null && 
            s.StockQuantity != null).ToList();

            foreach (var book in viewallbooks)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }
        }
        public static void ViewBooksByAuthor(IList<Book> books)
        {
            Console.Write("Enter name of author: ");
            var authorName = Console.ReadLine();
            var bookbyauthor = books.Where(s => s.Author == authorName).ToList();
            foreach(var author in bookbyauthor)
            {
                Console.WriteLine(author);
                Console.WriteLine();

            }

        }

        public static void ViewBooksByPrice(IList<Book> books)
        {
            Console.Write("Enter min price of book: ");
            var minPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter max price of book: ");
            var maxPrice = Convert.ToDecimal(Console.ReadLine());

            var bookbyprice = books.Where(s => s.Price >= minPrice && s.Price <= maxPrice).ToList();
            foreach (var price in bookbyprice)
            {
                Console.WriteLine(price);
                Console.WriteLine();

            }

        }
        public static void ViewOutOfStocksBooks(IList<Book> books)
        {

            var outofstocks = books.Where(s => s.StockQuantity == 0).ToList();
            foreach (var stock in outofstocks)
            {
                Console.WriteLine(stock);
                Console.WriteLine();

            }

        }

        public override string ToString()
        {
            return $"FirstName: {Title}\nLastName: {Author}\nAge: {Price:C}\nStockQuantity: {StockQuantity}";
        }

    }

}
