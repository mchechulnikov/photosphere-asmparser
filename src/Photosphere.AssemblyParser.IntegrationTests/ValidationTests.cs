using Photosphere.AssemblyParser.IntegrationTests.TestUtils;
using Photosphere.AssemblyParser.Validation.Exceptions;
using Xunit;

namespace Photosphere.AssemblyParser.IntegrationTests
{
    public class ValidationTests
    {
        [Fact]
        internal void Pars_TooSmallFile_Exception()
        {
            using (new RandomTemporaryFile(511))
            {
                Assert.Throws<InvalidBinaryFileLengthException>(() => new AssemblyParser(TemporaryFile.Path));
            }
        }

        [Fact]
        public void Parse_NotDosFile_Exception()
        {
            using (new InvalidDosTemporaryFile())
            {
                Assert.Throws<InvalidDosFileHeaderException>(() => new AssemblyParser(TemporaryFile.Path));
            }
        }

        [Fact]
        public void Parse_NotPeFile_Exception()
        {
            using (new InvalidPeTemporaryFile())
            {
                Assert.Throws<InvalidPeFileHeaderException>(() => new AssemblyParser(TemporaryFile.Path));
            }
        }
    }
}