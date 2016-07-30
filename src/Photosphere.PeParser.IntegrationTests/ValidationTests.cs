using Photosphere.PeParser.IntegrationTests.TestUtils;
using Photosphere.PeParser.Validation.Exceptions;
using Xunit;

namespace Photosphere.PeParser.IntegrationTests
{
    public class ValidationTests
    {
        [Fact]
        internal void Pars_TooSmallFile_Exception()
        {
            using (new RandomTemporaryFile(511))
            {
                Assert.Throws<InvalidBinaryFileLengthException>(() => new DotNetAssemblyParser(TemporaryFile.Path));
            }
        }

        [Fact]
        public void Parse_NotDosFile_Exception()
        {
            using (new InvalidDosTemporaryFile())
            {
                Assert.Throws<InvalidDosFileHeaderException>(() => new DotNetAssemblyParser(TemporaryFile.Path));
            }
        }

        [Fact]
        public void Parse_NotPeFile_Exception()
        {
            using (new InvalidPeTemporaryFile())
            {
                Assert.Throws<InvalidPeFileHeaderException>(() => new DotNetAssemblyParser(TemporaryFile.Path));
            }
        }
    }
}