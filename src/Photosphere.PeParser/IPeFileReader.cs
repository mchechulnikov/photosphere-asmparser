namespace Photosphere.PeParser
{
    public interface IPeFileReader
    {
        byte[] Read(string filePath);
    }
}