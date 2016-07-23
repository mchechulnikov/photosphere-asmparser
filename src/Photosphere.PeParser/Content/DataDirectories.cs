namespace Photosphere.PeParser.Content
{
    internal class DataDirectories : IDataDirectories
    {
        public byte[] TextSectionHeader { get; set; }

        public byte[] RsrcSectionHeader { get; set; }

        public byte[] RelocSectionHeader { get; set; }

        public byte[] TextSection { get; set; }
    }
}