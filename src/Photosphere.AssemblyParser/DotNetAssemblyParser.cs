using System;
using Photosphere.AssemblyParser.BinaryParsing;
using Photosphere.AssemblyParser.Validation;

namespace Photosphere.AssemblyParser
{
    public class DotNetAssemblyParser : IDisposable
    {
        private readonly BinaryFileReader _reader;

        public DotNetAssemblyParser(string filePath)
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
