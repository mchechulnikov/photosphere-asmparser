namespace Photosphere.PeParser.PeContent
{
    public interface IDataDirectories
    {
        byte[] TextSectionHeader { get; set; }
        byte[] RsrcSectionHeader { get; set; }
        byte[] RelocSectionHeader { get; set; }
        byte[] TextSection { get; set; }
    }
}