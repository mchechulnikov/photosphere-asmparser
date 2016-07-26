using System;
using System.IO;
using System.Linq;

namespace Photosphere.PeParser
{
    internal struct Word
    {
        private byte[] _bytes;

        public Word(byte[] bytes)
        {
            _bytes = bytes;
        }
    }

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
            BitConverter.
            _binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
        }

        public ushort ReadWord()
        {
            var bytes = _binaryReader.ReadBytes(2);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return BitConverter.ToUInt16(bytes, 0);
        }

        public uint ReadDword()
        {
            var bytes = _binaryReader.ReadBytes(4);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return BitConverter.ToUInt32(bytes, 0);
        }

        public void Dispose()
        {
            _binaryReader.Dispose();
        }
    }
}