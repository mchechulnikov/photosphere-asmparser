using System;
using System.Collections.Generic;

namespace Photosphere.PeParser
{
    internal struct Word
    {
        private readonly byte _byte1;
        private readonly byte _byte2;

        public Word(IReadOnlyList<byte> bytes)
        {
            _byte1 = bytes[0];
            _byte2 = bytes[1];
        }

        public Word(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            _byte1 = bytes[0];
            _byte2 = bytes[1];
        }

        public static bool operator ==(Word first, Word second) =>
            first._byte1 == second._byte1 && first._byte2 == second._byte2;

        public static bool operator ==(Word first, uint second)
        {
            var bytes = BitConverter.GetBytes(second);
            return first._byte1 == bytes[0] && first._byte2 == bytes[1];
        }

        public static bool operator !=(Word first, Word second) => !(first == second);

        public static bool operator !=(Word first, uint second) => !(first == second);
    }
}