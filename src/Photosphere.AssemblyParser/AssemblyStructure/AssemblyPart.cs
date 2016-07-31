using Photosphere.AssemblyParser.BinaryParsing.BinaryStructs;

namespace Photosphere.AssemblyParser.AssemblyStructure
{
    internal class AssemblyPart
    {
        public AssemblyPart(string name)
        {
            Name = name;
        }

        public AssemblyPart(string name, IBinaryStruct obligatoryValue)
        {
            Name = name;
            ObligatoryValue = obligatoryValue;
        }

        public AssemblyPart(string name, ushort bytesCount, ushort? bytesCount64 = null)
        {
            Name = name;
            BytesCount = bytesCount;
            BytesCount64 = bytesCount64 ?? 0;
        }

        public AssemblyPart(string name, BinarySize bytesCount, BinarySize? bytesCount64 = null)
        {
            Name = name;
            BytesCount = (ushort) bytesCount;
            BytesCount64 = (ushort) (bytesCount64 ?? 0);
        }

        public string Name { get; }

        public ushort BytesCount { get; }

        public ushort BytesCount64 { get; }

        public IBinaryStruct ObligatoryValue { get; }
    }
}