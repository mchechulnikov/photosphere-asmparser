using System;
using Photosphere.PeParser.Extensions;
using Photosphere.PeParser.FileSystem;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser.Parsers
{
    internal class PeHeaderParser : IParser<PeHeader>
    {
        private const uint Signature = 0x50450000;
        private const ushort IsDllCharacteristicValue = 0x2000;
        private const int CharacteristicOffset = 22;

        public PeHeader Parse(TargetFile file, uint offset = 0)
        {
            if (Signature != file.Content.GetDword(offset))
            {
                throw new InvalidOperationException($"File `{file.Name}` is not PE file!");
            }
            var isDll = file.Content.GetWord(offset + CharacteristicOffset) == IsDllCharacteristicValue;
            return new PeHeader(isDll);
        }
    }
}