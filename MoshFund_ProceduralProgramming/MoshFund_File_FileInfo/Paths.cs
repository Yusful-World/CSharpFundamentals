using System;
using System.IO;

namespace MoshFund_FileAndDirectory
{
    public class Paths
    { 
        public void PathMethods()
        {
            var path = @"C:\Users\Admin\source\repos\MoshFund_Arrays\MoshFund_Arrays.sln";

            //low level programming is to
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine("Extension is: " + extension);

            //what you should do is
            Console.WriteLine("File name is: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("File name extension: " + Path.GetExtension(path));
            Console.WriteLine("Directory name is: " + Path.GetDirectoryName(path));
        }
    }
}
