namespace Photosphere.PeParser
{
    public interface IPeFileParser
    {
        IPeFileContent Parse(string filePath);
    }
}