using System;
using Photosphere.AssemblyParser.Extensions;

namespace Photosphere.AssemblyParser.Validation.Exceptions
{
    internal class ValidationException : Exception
    {
        private readonly string _filePath;
        private readonly string _reason;

        protected ValidationException(string filePath, string reason = null)
        {
            _filePath = filePath;
            _reason = reason;
        }

        protected virtual string Reason => _reason.IsNullOrEmpty() ? "Unknown reason" : _reason;

        public override string Message => $"Invalid binary file `{_filePath}`: {Reason}";
    }
}