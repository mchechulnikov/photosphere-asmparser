using System;

namespace Photosphere.PeParser
{
    public class PeFile
    {
        public PeFile(string path, byte[] content)
        {
            Path = path;
            Name = ParserName(path);
            Content = content;
        }

        public string Path { get; }

        public string Name { get; }

        public byte[] Content { get;  }

        private static string ParserName(string path)
        {
            throw new NotImplementedException();
        }
    }
}