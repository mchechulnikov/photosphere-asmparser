using Photosphere.AssemblyParser.IntegrationTests.Extensions;

namespace Photosphere.AssemblyParser.IntegrationTests.TestUtils
{
    internal class RandomTemporaryFile : TemporaryFile
    {
        public RandomTemporaryFile(int length) : base(GetRandomBytes(length)) {}

        protected RandomTemporaryFile(int length, byte[] startBytes) : base(GetRandomBytes(length, startBytes)) { }

        private static byte[] GetRandomBytes(int count, byte[] startBytes = null)
        {
            var bytes = new byte[count];
            bytes.FillArrayRandomly();
            if (startBytes.IsNotEmpty())
            {
                bytes.PutFromBegining(startBytes);
            }
            return bytes;
        }
    }
}