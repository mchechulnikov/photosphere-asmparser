namespace Photosphere.PeParser.IntegrationTests.TestUtils
{
    internal class InvalidPeTemporaryFile : RandomTemporaryFile
    {
        public InvalidPeTemporaryFile() : base(512, new byte[] { 0x4d, 0x5a }) { }
    }
}