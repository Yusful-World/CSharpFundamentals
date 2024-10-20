using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_Strings
{

    public class Program
    {
        static void Main(string[] args)
        {
            //StringMethods stringMethods = new StringMethods();
            
            string sentence = "The replace method requires both parameters to be of same type i.e. a string replace a string and a character is made to replace a character";

            var summarizeSentence = SummarizingText.SummarizeText(sentence, 65);
            Console.WriteLine(summarizeSentence);

        }
    }
}
