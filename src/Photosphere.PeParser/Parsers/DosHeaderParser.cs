using System;
using Photosphere.PeParser.Extensions;
using Photosphere.PeParser.FileSystem;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser.Parsers
{
    internal class DosHeaderParser : IParser<DosHeader>
    {
        private const ushort Emagic = 0x4d5a;
        private const ushort LfanewOffcet = 0x3c;

        public DosHeader Parse(TargetFile file, uint offset = 0)
        {
            if (Emagic != file.Content.GetWord(0))
            {
                throw new InvalidOperationException($"File `{file.Name}` is not DOS file!");
            }
            var peOffset = file.Content.GetDword(LfanewOffcet);
            return new DosHeader((uint) peOffset);
        }
    }
}