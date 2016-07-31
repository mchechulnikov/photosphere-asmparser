using Photosphere.AssemblyParser.BinaryParsing.BinaryStructs;

namespace Photosphere.AssemblyParser.AssemblyStructure
{
    internal struct DataDirectory
    {
        public readonly Dword VirualAddress;
        public readonly uint Size;

        public DataDirectory(Dword virualAddress, uint size)
        {
            VirualAddress = virualAddress;
            Size = size;
        }
    }
}