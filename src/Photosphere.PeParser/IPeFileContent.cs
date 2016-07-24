using Photosphere.PeParser.PeContent;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    public interface IPeFileContent
    {
        DosHeader DosHeader { get; }
        string DosStub { get; }
        PeSignature PeSignature { get; }
        PeFileHeader PeFileHeader { get; }
        PeFields PeFields { get; }
        IDataDirectories DataDirectories { get; }
    }
}