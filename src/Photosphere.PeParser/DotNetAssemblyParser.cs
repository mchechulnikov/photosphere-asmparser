using System;
using System.IO;

namespace Photosphere.PeParser
{
    public class DotNetAssemblyParser : IDisposable
    {
        private readonly string _filePath;
        private readonly BinaryFileReader _reader;

        public DotNetAssemblyParser(string filePath)
        {
            _filePath = filePath;
            _reader = new BinaryFileReader(filePath);

            ValidateFile();
        }

        public byte[] GetMethod()
        {
            throw new NotImplementedException();
        }

        private void ValidateFile()
        {
            if (_reader.Length < 128)
            {
                throw new InvalidOperationException("Invalid file length");
            }

            if (_reader.ReadWord() != 0x4d5a)
            {
                throw new InvalidOperationException("Invalid DOS header");
            }

            _reader.ForwardOn(58);
            var peOffset = _reader.ReadDword();
            _reader.MoveTo(peOffset);

            if (_reader.ReadDword() != 0x50450000)
            {
                throw new InvalidOperationException("Invalid PE header");
            }
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}