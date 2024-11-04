using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshAdvance_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            
            var book = new Book() { Isbn = "1234", Title = "C# Advanced" };

            var numbers = new List();
            numbers.Add(10);

            var books = new BookList();
            books.Add(book);

            var numbers2 = new GenericList<int>();
            numbers2.Add(10);

            var books2 = new GenericList<Book>();
            books2.Add(book);

            var dictionary = new Dictionary<string, Book>();
            dictionary.Add("1234", new Book());

        }
    }
}
