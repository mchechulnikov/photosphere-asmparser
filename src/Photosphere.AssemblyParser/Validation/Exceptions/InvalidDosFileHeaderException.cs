namespace Photosphere.AssemblyParser.Validation.Exceptions
{
    internal class InvalidDosFileHeaderException : ValidationException
    {
        public InvalidDosFileHeaderException(string filePath) : base(filePath) { }

        protected override string Reason => "Invalid DOS file header";
    }
}