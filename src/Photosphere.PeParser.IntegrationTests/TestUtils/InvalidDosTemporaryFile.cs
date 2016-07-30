namespace Photosphere.PeParser.IntegrationTests.TestUtils
{
    internal class InvalidDosTemporaryFile : RandomTemporaryFile
    {
        public InvalidDosTemporaryFile() : base(512, new byte[] { 0x4d, 0x5b }) {}
    }
}