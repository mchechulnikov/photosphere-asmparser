using System;

namespace Photosphere.PeParser
{
    public class DotNetAssemblyParser : IDisposable
    {
        private readonly Word _dosHeaderMagic = new Word(0x4d5a);
        private readonly Dword _peSignature = new Dword(0x50450000);

        private readonly string _filePath;
        private readonly BinaryFileReader _reader;

        public DotNetAssemblyParser(string filePath)
        {
            _filePath = filePath;
            _reader = new BinaryFileReader(filePath);

            ValidateFile();
        }

        private void ValidateFile()
        {
            if (_reader.Length < 128)
            {
                throw new InvalidOperationException("Invalid file length");
            }

            if (_reader.ReadWord() != _dosHeaderMagic)
            {
                throw new InvalidOperationException("Invalid DOS header");
            }

            _reader.ForwardOn(58);
            var peOffset = _reader.ReadDword();
            _reader.MoveTo(peOffset);

            if (_reader.ReadDword() != _peSignature)
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