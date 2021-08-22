using System;
using System.IO;

namespace Facade
{
    public static class HashCreator
    {
        public static string CreateHash()
        {
            return DateTime.Now.GetHashCode().ToString("x");
        }

        public static bool Validate(FileInfo fileInfo)
        {
            if(File.Exists(fileInfo.FullName))
            {
                throw new Exception("Duplicate File name");
            }
            return true;
        }
    }
}
