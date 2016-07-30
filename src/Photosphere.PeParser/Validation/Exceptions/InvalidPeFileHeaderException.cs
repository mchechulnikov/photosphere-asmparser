namespace Photosphere.PeParser.Validation.Exceptions
{
    internal class InvalidPeFileHeaderException : ValidationException
    {
        public InvalidPeFileHeaderException(string filePath) : base(filePath) { }

        protected override string Reason => "Invalid PE file header";
    }
}