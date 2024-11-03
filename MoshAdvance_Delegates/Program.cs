using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshAdvance_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilter();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            var processor2 = new PhotoProcessor2();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor2.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove red eye effect.");
        }
    }
}
