using System.IO;

namespace Facade
{
    public class Write
    {
        public static void CreateFile(FileInfo pathOfOutputfile)
        {
            using (StreamWriter streamWriter = new StreamWriter(pathOfOutputfile.FullName))
            {
                streamWriter.WriteLine("Hello World");
            }
        }
    }
}
