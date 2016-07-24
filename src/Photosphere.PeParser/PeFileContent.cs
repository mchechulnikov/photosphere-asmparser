using Photosphere.PeParser.PeContent;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    internal class PeFileContent : IPeFileContent
    {
        public DosHeader DosHeader { get; }
        public string DosStub { get; }
        public PeSignature PeSignature { get; }
        public PeFileHeader PeFileHeader { get; }
        public PeFields PeFields { get; }
        public IDataDirectories DataDirectories { get; }
    }
}