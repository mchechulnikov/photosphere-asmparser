using System.IO;

namespace Photosphere.PeParser.FileSystem
{
    internal class TargetFile
    {
        public TargetFile(string path, byte[] content)
        {
            FilePath = path;
            Name = Path.GetFileName(path);
            Content = content;
        }

        public string FilePath { get; }

        public string Name { get; }

        public byte[] Content { get; }
    }
}