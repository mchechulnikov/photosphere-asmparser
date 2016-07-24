using Photosphere.PeParser.FileSystem;
using Photosphere.PeParser.Parsers;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    internal class PeFileParser : IPeFileParser
    {
        private readonly IFileReader _fileReader;
        private readonly IParser<DosHeader> _dosHeaderParser;
        private readonly IParser<PeHeader> _peHeaderParser;

        public PeFileParser()
        {
            _fileReader = new FileReader();
            _dosHeaderParser = new DosHeaderParser();
            _peHeaderParser = new PeHeaderParser();
        }

        public IPeFileContent Parse(string filePath)
        {
            var file = _fileReader.Read(filePath);
            // TODO
            var dosHeader = _dosHeaderParser.Parse(file);
            return new PeFileContent
            {
                DosHeader = dosHeader,
                PeHeader = _peHeaderParser.Parse(file, dosHeader.PeOffcet),
            };
        }
    }
}