namespace Photosphere.AssemblyParser.Validation.Exceptions
{
    internal class InvalidBinaryFileLengthException : ValidationException
    {
        public InvalidBinaryFileLengthException(string filePath) : base(filePath) {}

        protected override string Reason => "Invalid binary file length";
    }
}