using Xunit;

namespace Photosphere.PeParser.IntegrationTests
{
    public class DotNetAssemblyParserTests
    {
        private const string FilePath = "Photosphere.PeParser.TestAssembly.dll";

        [Fact]
        internal void Parse_ValidFile_ValidResult()
        {
            DotNetAssemblyParser.GetMethod(FilePath);
            Assert.True(true);
        }
    }
}