using Photosphere.PeParser.Content;
using Photosphere.PeParser.Content.Headers;

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