using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Oshios");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        static void StreamReaderException()
        {
            try
            {
                using (var streamReader = new StreamReader("@c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry! an unexpected error occured");
            }
}
        static void Calculate()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured");
            }
        }
    }
}
