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
    }
}