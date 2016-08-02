using Photosphere.AssemblyParser.Anatomy;
using Xunit;

namespace Photosphere.AssemblyParser.IntegrationTests
{
    public class FsharpTests
    {
        [Fact]
        internal void Test()
        {
            Assert.NotNull(FSharpTestType.StaticFoo);
        }
    }
}