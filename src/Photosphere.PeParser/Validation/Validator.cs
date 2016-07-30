using Photosphere.PeParser.BinaryParsing;
using Photosphere.PeParser.BinaryParsing.BinaryStructs;
using Photosphere.PeParser.Validation.Exceptions;

namespace Photosphere.PeParser.Validation
{
    internal class Validator
    {
        private readonly Word _dosHeaderMagic = new Word(0x4d5a);
        private readonly Dword _peSignature = new Dword(0x50450000);
        private const int LfNewOffsetPosition = 60;
        private const int MinDotNetAssemblyFileLength = 512;

        private readonly BinaryFileReader _reader;

        public Validator(BinaryFileReader reader)
        {
            _reader = reader;
        }

        public void Validate()
        {
            try
            {
                ValidateFile();
            }
            catch
            {
                _reader.Dispose();
                throw;
            }
        }

        private void ValidateFile()
        {
            ValidateLength();
            ValidateDosHeader();
            var pePosition = GetPeOffset();
            ValidatePePosition(pePosition);

            _reader.MoveTo(pePosition);

            if (_reader.ReadDword() != _peSignature)
            {
                throw new InvalidPeFileHeaderException(_reader.FilePath);
            }
        }

        private void ValidateLength()
        {
            if (_reader.Length < MinDotNetAssemblyFileLength)
            {
                throw new InvalidBinaryFileLengthException(_reader.FilePath);
            }
        }

        private void ValidateDosHeader()
        {
            if (_reader.ReadWord() != _dosHeaderMagic)
            {
                throw new InvalidDosFileHeaderException(_reader.FilePath);
            }
        }

        private Dword GetPeOffset()
        {
            _reader.MoveTo(LfNewOffsetPosition);
            return _reader.ReadDword();
        }

        private void ValidatePePosition(Dword pePosition)
        {
            if (pePosition >= MinDotNetAssemblyFileLength)
            {
                throw new InvalidPePositionException(_reader.FilePath, pePosition);
            }
        }
    }
}