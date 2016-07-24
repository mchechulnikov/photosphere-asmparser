using System.IO;

namespace Photosphere.PeParser.FileSystem
{
    internal class FileReader : IFileReader
    {
        public TargetFile Read(string filePath)
        {
            var content = File.ReadAllBytes(filePath);
            return new TargetFile(filePath, content);
        }
    }
}