using System;

namespace MoshFund_NonPrimitiveDataType
{
    public class IntroToStrings
    {
        public string firstName = "Yusuf";
        public string lastName = "Abdullahi";
        public void ConcatenatedString()
        {
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
        public void StringFormat()
        {
            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);
        }
        public static void StringJoin()
        {
            var names = new string[3] { "Abdullahi", "Yusuf", "Oshioriamhe" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);
        }
        public static void VerbatimString()
        {
            var text = "Hello Alex! Look into the following paths \nc:folder1\\folder2 \nfolder3\\folder4";
            Console.WriteLine(text); 

            var verbatimText = @"Hello Alex! Look into the following paths
c:folder1\folder2
folder3\folder4";
            Console.WriteLine(verbatimText);
        }
    }
}
