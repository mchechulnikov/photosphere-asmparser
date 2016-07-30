using System;
using System.Collections.Generic;
using Photosphere.PeParser.Extensions;

namespace Photosphere.PeParser.BinaryParsing.BinaryStructs
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

        public bool Equals(Word other) => _byte1 == other._byte1 && _byte2 == other._byte2;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Word && Equals((Word)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_byte1.GetHashCode() * 397) ^ _byte2.GetHashCode();
            }
        }
    }
}