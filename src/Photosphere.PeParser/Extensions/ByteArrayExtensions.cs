using System;

namespace Photosphere.PeParser.Extensions
{
    internal static class ByteArrayExtensions
    {
        public static void RepresentInDirectOrder(this byte[] bytes)
        {
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
        }
    }
}