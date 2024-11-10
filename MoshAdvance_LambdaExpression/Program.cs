using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshAdvance_LambdaExpression
{
    public class Books
    {
        public string Title;
        public double Price;
    }
    public class BookRepository
    {
        public List<Books> GetBooks()
        {
            return new List<Books>()
            {
                new Books { Title = "Book 1", Price = 5 },
                new Books { Title = "Book 2", Price = 7 },
                new Books { Title = "Book 3", Price = 15 }
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // () => ...    no argument
            // x => ...     single argument
            // (x, y, z) => multiple arg should be in parenthesis

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title);
            }
            


        }

        //static bool IsCheaperThan10Dollars(Books books)     //Predicate method
        //{
        //    return books.Price < 10;
        //}

        static void Square()
        {
            int square(int x) => x * x;
            Console.WriteLine(square(5));
        }

        static void Multiplier()
        {
            const int factor = 5;
            Func<int, int> multiplier = n => n / factor;
            Console.WriteLine(multiplier(40));
        }
    }
}
