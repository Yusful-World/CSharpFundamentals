using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshInt_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            var person = Person.Parse("Yusuf Oshioriamhe");
            person.Introduce("Mosh");
        }
    }
}
