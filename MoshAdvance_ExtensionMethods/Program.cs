using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoshAdvance_ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string post = "Extension methods allows you to add methods to an existing class without changing it's source code or creating new classes that inherit from it.";

            var shortenedPost = post.Shorten(12);

            Console.WriteLine(shortenedPost);
        }
    }
}
