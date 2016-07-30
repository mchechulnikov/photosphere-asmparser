using System;
using Photosphere.PeParser.BinaryParsing;
using Photosphere.PeParser.Validation;

namespace Photosphere.PeParser
{
    public class DotNetAssemblyParser : IDisposable
    {
        private readonly BinaryFileReader _reader;

        public DotNetAssemblyParser(string filePath)
        {
            _reader = new BinaryFileReader(filePath);

            new Validator(_reader).Validate();
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}
