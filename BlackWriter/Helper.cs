using System.IO;


namespace BlackWriter
{
    public static class Helper
    {
        public static void DeleteAllFilesAndSubfolders(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                return;
            }

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public static void CopyAllFiles(string src, string dest)
        {
            if (!Directory.Exists(src))
            {
                return;
            }

            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }

            var directory = new DirectoryInfo(src);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                file.CopyTo(Path.Combine(dest, file.Name), false);
            }

            foreach (DirectoryInfo subdir in directory.GetDirectories())
            {
                string temppath = Path.Combine(dest, subdir.Name);
                CopyAllFiles(subdir.FullName, temppath);
            }
        }
    }
}
