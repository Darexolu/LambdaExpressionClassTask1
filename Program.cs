namespace LambdaExpressionClassTask1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            IList<Book> books = new List<Book>
            {
                new Book{
                Title = "Bromance",
                Author = "Chinua Achebe",
                Price = 900m,
                StockQuantity = 16
                },

                new Book{
                Title = "Gifted",
                Author = "Chinua Achebe",
                Price = 700m,
                StockQuantity = 15
                },

                new Book{
                Title = "Melinda",
                Author = "Chimamanda Adichie",
                Price = 500m,
                StockQuantity = 0
                },
                 new Book{
                Title = "The promise",
                Author = "Amtabh bachan",
                Price = 600m,
                StockQuantity = 0
                }
            };
            Book.ViewAllBooks(books);
            //Book.ViewBooksByAuthor(books);
            //Book.ViewBooksByPrice(books);
            //Book.ViewOutOfStocksBooks(books);



        }
       
    }
}