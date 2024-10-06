using System;

namespace MoshFund_CreatingClasses
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Title;
        public string Origin;
        public DateTime DateOfBirth;

        public void Introduce()
        {
            Console.WriteLine("My name is " + Title + " " + FirstName + " " + LastName + "\n I am from " + Origin);
        }

        public int Age()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.DateOfBirth.Year;
            if (this.DateOfBirth > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
