using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoshInt_Indexers;

namespace MoshInt_Properties
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Yusuf";
            Console.WriteLine(cookie["name"]);

            //var person = new Person(new DateTime(2000, 04, 17));
            //Console.WriteLine(person.Age);
        }
    }
}
