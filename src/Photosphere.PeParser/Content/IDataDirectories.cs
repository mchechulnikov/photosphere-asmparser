namespace Photosphere.PeParser.Content
{
    public interface IDataDirectories
    {
        byte[] TextSectionHeader { get; set; }
        byte[] RsrcSectionHeader { get; set; }
        byte[] RelocSectionHeader { get; set; }
        byte[] TextSection { get; set; }
    }
}