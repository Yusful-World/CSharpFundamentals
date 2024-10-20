using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshInt_Upcasting_DownCasting
{

    public class Program
    {
        static void Main(string[] args)
        {
            //DownCasting
            Shape shape = new Text();
            Text text = (Text) shape; 
            
            //UPCASTING
            var streamReader = new StreamReader(new MemoryStream());
            var list = new ArrayList();
            list.Add(1);
            list.Add("Yusuf");
            list.Add(new Text());

            var text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
        }
    }
}
