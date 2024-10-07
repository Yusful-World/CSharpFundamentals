using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_NonPrimitiveDataType
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            IntroToArrays introToArrays = new IntroToArrays();
            introToArrays.ArrayIndex();
            
            var person = new IntroToStrings();
            person.ConcatenatedString();
            Console.WriteLine();
            
            person.StringFormat();
            Console.WriteLine();
            
            IntroToStrings.StringJoin();
            Console.WriteLine();
            
            IntroToStrings.VerbatimString();
        }
    }
}
