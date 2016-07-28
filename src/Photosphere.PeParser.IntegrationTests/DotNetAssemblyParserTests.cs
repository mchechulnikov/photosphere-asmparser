using System;
using Photosphere.PeParser.IntegrationTests.TestUtils;
using Xunit;

namespace Photosphere.PeParser.IntegrationTests
{
    public class DotNetAssemblyParserTests
    {
        private const string FilePath = "Photosphere.PeParser.TestAssembly.dll";

        [Fact]
        internal void Parse_ValidFile_ValidResult()
        {
            using (var parser = new DotNetAssemblyParser(FilePath))
            {
                Assert.NotNull(parser);
            }
        }

        [Fact]
        public void Parse_NotDosFile_Exception()
        {
            using (new TemporaryFile(new byte[] { 0x4d, 0x5b }))
            {
                Assert.Throws<InvalidOperationException>(() => new DotNetAssemblyParser(TemporaryFile.Path));
            }
        }
    }
}