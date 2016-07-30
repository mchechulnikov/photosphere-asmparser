using System;

namespace Photosphere.AssemblyParser.Extensions
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