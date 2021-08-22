using System.IO;

namespace Facade
{
    public static class FilePathCreator
    {
        public static FileInfo GetPath()
        {
            return new FileInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        }
    }
}
