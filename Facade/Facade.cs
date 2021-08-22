using System.IO;

namespace Facade
{
    public static class Facade
    {
        public static void CreateFile()
        {
            var Path = FilePathCreator.GetPath();
            var Hash = HashCreator.CreateHash();
            var combined = new FileInfo($"{Path}//{Hash}.txt");
            if (HashCreator.Validate(combined))
            {
                Write.CreateFile(combined);
            }
        }
    }
}
