using System;

namespace MoshFund_Iterations
{
    public class RanadomClass
    {
        public static void RandomNumbers()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
                Console.Write("Random Numbers: " + random.Next(1, 10) + ", ");
            Console.WriteLine();
        }

        public static void RandomAlphabets()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
                Console.Write("RandomAlphabets: " + (char)random.Next(97, 122));
            Console.WriteLine();
        }
        public static void RandomPassWord()
        {
            int passwordLength = 10;
            var random = new Random();
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine("Random Password: " + password);
            Console.WriteLine();
        }

        public static string GeneratePassword()
        {
            const int passwordLength = 10;
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var password = new char[passwordLength];
            Random random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                int index = random.Next(validChars.Length);
                password[i] = validChars[index];
            }

            return new string(password);
        }
    }
}
