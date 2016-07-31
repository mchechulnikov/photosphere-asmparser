namespace Photosphere.AssemblyParser.AssemblyStructure
{
    internal class PeHeader
    {
        // 20 offset 2 byte
        public bool IsPe64 { get; }

        public DataDirectory Cli { get; }
    }
}