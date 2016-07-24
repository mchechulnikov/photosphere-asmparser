using Photosphere.PeParser.PeContent;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    public interface IPeFileContent
    {
        DosHeader DosHeader { get; }
        string DosStub { get; }
        PeSignature PeSignature { get; }
        PeHeader PeHeader { get; }
        PeFields PeFields { get; }
        IDataDirectories DataDirectories { get; }
    }
}