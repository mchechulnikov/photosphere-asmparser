using Photosphere.PeParser.FileSystem;
using Photosphere.PeParser.Parsers;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    internal class PeFileParser : IPeFileParser
    {
        private readonly IFileReader _fileReader;
        private readonly IParser<DosHeader> _dosHeaderParser;

        public PeFileParser()
        {
            _fileReader = new FileReader();
            _dosHeaderParser = new DosHeaderParser();
        }

        public IPeFileContent Parse(string filePath)
        {
            var file = _fileReader.Read(filePath);
            // TODO
            return new PeFileContent
            {
                DosHeader = _dosHeaderParser.Parse(file),
            };
        }
    }
}