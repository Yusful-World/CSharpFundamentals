using System.IO;

namespace MoshFund_FileAndDirectory
{
    public class FileAndFileInfo
    {
        public string path = @"C:\Users\Admin\Downloads.jpg";

        public void FileMethods()
        {
            var newImages = File.Create(@"C:\Users\Public\DownloadedImages");

            File.Copy(path, @"C:\Users\Public\Downloads");
            File.Delete(path);
            if (File.Exists(path))
            {

            }

            var content = File.ReadAllText(path);
        }
        public void FileInfoMethods()
        {
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(path);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }

        }
    }
}
