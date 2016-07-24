using Photosphere.PeParser.FileSystem;

namespace Photosphere.PeParser.Parsers
{
    internal interface IParser<out T>
    {
        T Parse(TargetFile file, uint offset = 0);
    }
}