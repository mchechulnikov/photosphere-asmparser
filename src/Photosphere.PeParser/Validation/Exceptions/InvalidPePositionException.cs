using Photosphere.PeParser.Extensions;

namespace Photosphere.PeParser.Validation.Exceptions
{
    internal class InvalidPePositionException : ValidationException
    {
        private readonly string _peOffset;

        public InvalidPePositionException(string filePath, uint peOffset) : base(filePath)
        {
            _peOffset = peOffset.ToHex();
        }

        protected override string Reason => $"Invalid PE offset `{_peOffset}`";
    }
}