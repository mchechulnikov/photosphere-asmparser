using Xunit;

namespace Photosphere.AssemblyParser.IntegrationTests
{
    public class DotNetAssemblyParserTests
    {
        private const string FilePath = "Photosphere.AssemblyParser.TestAssembly.dll";

        [Fact]
        internal void Parse_ValidFile_ValidResult()
        {
            using (var parser = new AssemblyParser(FilePath))
            {
                Assert.NotNull(parser);
            }
        }
    }
}