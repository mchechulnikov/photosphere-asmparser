using System;
using System.IO;

namespace Photosphere.PeParser
{
    internal class BinaryFileReader : IDisposable
    {
        private readonly BinaryReader _binaryReader;

        public BinaryFileReader(string filePath)
        {
            var fileStream = File.OpenRead(filePath);
            _binaryReader = new BinaryReader(fileStream);
        }

        public long Length => _binaryReader.BaseStream.Length;

        public void ForwardOn(uint offset)
        {
            _binaryReader.BaseStream.Seek(offset, SeekOrigin.Current);
        }

        public void MoveTo(uint offset)
        {
            _binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
        }

        public Word ReadWord()
        {
            var bytes = _binaryReader.ReadBytes(2);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return new Word(bytes);
        }

        public Dword ReadDword()
        {
            var bytes = _binaryReader.ReadBytes(4);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return new Dword(bytes);
        }

        public void Dispose()
        {
            _binaryReader.Dispose();
        }
    }
}