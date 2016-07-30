using Photosphere.AssemblyParser.BinaryParsing;
using Photosphere.AssemblyParser.Validation;

namespace Photosphere.AssemblyParser
{
    public class AssemblyParser : IAssemblyParser
    {
        private readonly BinaryFileReader _reader;

        public AssemblyParser(string filePath)
        {
            _reader = new BinaryFileReader(filePath);

            Validator.Validate(_reader);
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}
