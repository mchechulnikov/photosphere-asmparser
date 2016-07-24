using System;
using Photosphere.PeParser.Extensions;
using Photosphere.PeParser.FileSystem;
using Photosphere.PeParser.PeContent.Headers;

namespace Photosphere.PeParser.Parsers
{
    internal class DosHeaderParser
    {
        private const uint Emagic = 0x4d5a;
        private const uint IfnewOffcet = 0x3c;
        private const int HeaderLength = 64;

        public DosHeader Parse(TargetFile file)
        {
            if (Emagic != file.Content.GetWord(0))
            {
                throw new InvalidOperationException($"File `{file.Name}` is not DOS file!");
            }
            var headerContent = file.Content.Slice(0, HeaderLength);
            var peOffset = file.Content.GetDword(IfnewOffcet);
            return new DosHeader(headerContent, peOffset);
        }
    }
}