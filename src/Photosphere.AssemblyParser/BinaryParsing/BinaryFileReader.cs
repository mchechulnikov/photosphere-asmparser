using System;
using System.IO;
using Photosphere.AssemblyParser.BinaryParsing.BinaryStructs;
using Photosphere.AssemblyParser.Extensions;

namespace Photosphere.AssemblyParser.BinaryParsing
{
    internal class BinaryFileReader : IDisposable
    {
        private readonly BinaryReader _binaryReader;

        public BinaryFileReader(string filePath)
        {
            FilePath = filePath;
            var fileStream = File.OpenRead(filePath);
            _binaryReader = new BinaryReader(fileStream);
        }

        public string FilePath { get; }

        public long Length => _binaryReader.BaseStream.Length;

        public void ForwardOn(uint offset)
        {
            _binaryReader.BaseStream.Seek(offset, SeekOrigin.Current);
        }

        public void MoveTo(uint position)
        {
            _binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);
        }

        public Word ReadWord()
        {
            var bytes = _binaryReader.ReadBytes(2);
            bytes.RepresentInDirectOrder();
            return new Word(bytes);
        }

        public Dword ReadDword()
        {
            var bytes = _binaryReader.ReadBytes(4);
            bytes.RepresentInDirectOrder();
            return new Dword(bytes);
        }

        public void Dispose()
        {
            _binaryReader.Dispose();
        }
    }
}