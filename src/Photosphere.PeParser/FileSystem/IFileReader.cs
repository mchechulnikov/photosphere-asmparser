namespace Photosphere.PeParser.FileSystem
{
    internal interface IFileReader
    {
        TargetFile Read(string filePath);
    }
}