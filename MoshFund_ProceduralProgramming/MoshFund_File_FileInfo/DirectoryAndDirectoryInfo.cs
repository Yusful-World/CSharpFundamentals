using System;
using System.IO;

namespace MoshFund_FileAndDirectory
{
    public class DirectoryAndDirectoryInfo
    {
        public void DirectoryMethods()
        {
            Directory.CreateDirectory(@"C:\Users\Public\Downloads\TempFolder");

            var files = Directory.GetFiles(@"C:\Users\Admin\source\repos\", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\Admin\source\repos\", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("");
            Directory.EnumerateFiles("");
            Directory.Delete("");
        }

        public void DirectoryInfoMethods()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Admin\source\repos\");
            directoryInfo.GetDirectories(@"C:\Users\Admin\source\repos\", SearchOption.AllDirectories);
            directoryInfo.GetFiles();
        }
    }
}
