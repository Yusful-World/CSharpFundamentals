using System;

namespace MoshFund_Strings
{
    public class StringMethods
    {
        private string FullName = "Abdullahi Yusuf  ";
        public void TrimMethod()
        {
            Console.WriteLine("Trimmed string: {0}", FullName.Trim());
        }
        public void CaseMethod()
        {
            Console.WriteLine("Lower case: " + FullName.ToLower());
            Console.WriteLine("Upper case: " + FullName.ToUpper());
        }
        public void SubStringMethod()
        {
            var index = FullName.IndexOf(' ');
            var firstName = FullName.Substring(0, index);
            var lastName = FullName.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
        public void SplitMethod()
        {
            var names = FullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);
        }
        public void ReplaceMethod()
        {
            Console.WriteLine("Replace: " + FullName.Replace("Yusuf", "Oshioriamhe"));
        }
        public void NullOrWhiteSpaceMethod()
        {
            if (string.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");
            
            if (string.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");
            
            if (string.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

        }
        public void ToStringMethod()
        {
            var age = "25";
            Console.WriteLine("Age is: " + Convert.ToInt32(age));

            var price = 26.89f;
            Console.WriteLine("Price is " + price.ToString("C"));
            Console.WriteLine("Price without decimal" + price.ToString("C0"));
        }
        public bool ContainsMethod()
        {
            var containlastName = FullName.Contains("");
            return containlastName;
        }
    }
}
