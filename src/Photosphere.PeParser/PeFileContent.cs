using Photosphere.PeParser.PeContent;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    internal class PeFileContent : IPeFileContent
    {
        public DosHeader DosHeader { get; set; }
        public PeSignature PeSignature { get; set; }
        public PeHeader PeHeader { get; set; }
        public PeFields PeFields { get; set; }
        public IDataDirectories DataDirectories { get; set; }
    }
}