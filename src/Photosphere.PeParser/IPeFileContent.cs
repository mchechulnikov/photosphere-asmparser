using System.Collections.Generic;

namespace Photosphere.PeParser
{
    public interface IPeFileContent
    {
        IEnumerable<byte> DosHeader { get; }
        IEnumerable<byte> PeHeader { get; }
    }
}