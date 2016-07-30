using System;

namespace Photosphere.AssemblyParser.Validation.Exceptions
{
    internal abstract class ValidationException : Exception
    {
        private readonly string _filePath;

        protected ValidationException(string filePath)
        {
            _filePath = filePath;
        }

        protected virtual string Reason => "Unknown reason";

        public override string Message => $"Invalid binary file `{_filePath}`: {Reason}";
    }
}