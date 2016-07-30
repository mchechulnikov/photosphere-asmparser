using System;

namespace Photosphere.PeParser.IntegrationTests.Extensions
{
    internal static class ByteArrayExtensions
    {
        public static void FillArrayRandomly(this byte[] array) => new Random().NextBytes(array);
    }
}