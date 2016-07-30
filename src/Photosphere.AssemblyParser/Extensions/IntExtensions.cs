namespace Photosphere.AssemblyParser.Extensions
{
    internal static class IntExtensions
    {
        public static string ToHex(this int value) => "0x" + value.ToString("X");

        public static string ToHex(this uint value) => "0x" + value.ToString("X");
    }
}