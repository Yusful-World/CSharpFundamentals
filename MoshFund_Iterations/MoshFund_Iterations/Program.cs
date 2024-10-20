using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_Iterations
{

    public class Program
    {
        static void Main(string[] args)
        {
            ForLoops.GetEvenNumbers();
            ForEachLoop.PrintCharacters();
            ForEachLoop.PrintNumbers();
            WhileLoops.PrintEvenNUmbers();
            WhileLoops.EchoName();
            RanadomClass.RandomNumbers();
            RanadomClass.RandomAlphabets();
            RanadomClass.RandomPassWord();
            Console.WriteLine("Generated Password: " + RanadomClass.GeneratePassword());
        }
    }
}
