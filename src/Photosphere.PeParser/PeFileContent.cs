using System;
using System.Collections.Generic;

namespace Photosphere.PeParser
{
    internal class PeFileContent : IPeFileContent
    {
        IEnumerable<byte> IPeFileContent.DosHeader
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IEnumerable<byte> IPeFileContent.PeHeader
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}