namespace Photosphere.PeParser.PeContent.Headers
{
    internal class DataDirectories
    {
        public byte[] TextSectionHeader { get; set; }

        public byte[] RsrcSectionHeader { get; set; }

        public byte[] RelocSectionHeader { get; set; }

        public byte[] TextSection { get; set; }
    }
}