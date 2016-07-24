namespace Photosphere.PeParser.Extensions
{
    internal static class ByteArrayExtensions
    {
        public static short GetWord(this byte[] bytes, uint offcet)
        {
            return (short)(bytes[offcet] + bytes[offcet + 1]);
        }

        public static int GetDword(this byte[] bytes, uint offcet)
        {
            return bytes[offcet] + bytes[offcet + 1] + bytes[offcet + 2] + bytes[offcet + 3];
        }
    }
}