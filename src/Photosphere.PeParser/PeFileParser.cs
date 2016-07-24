using System;
using System.IO;
using Photosphere.PeParser.FileSystem;
using Photosphere.PeParser.PeContent;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser
{
    internal class PeFileParser : IPeFileParser
    {
        private readonly IFileReader _fileReader;

        public PeFileParser()
        {
            _fileReader = new FileReader();
        }

        public IPeFileContent Parse(string filePath)
        {
            var file = _fileReader.Read(filePath);
            throw new NotImplementedException();
        }


        private string ReadDosStub()
        {
            throw new NotImplementedException();
        }

        private PeSignature ReadPeSignature()
        {
            throw new NotImplementedException();
        }

        private PeFileHeader ReadPeFileHeader()
        {
            throw new NotImplementedException();
        }

        private PeFields ReadPeFields()
        {
            throw new NotImplementedException();
        }

        private IDataDirectories ReadDataDirectories()
        {
            throw new NotImplementedException();
        }
    }
}