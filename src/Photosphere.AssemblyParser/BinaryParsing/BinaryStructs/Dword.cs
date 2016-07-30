using System;
using System.Collections.Generic;

namespace Photosphere.AssemblyParser.BinaryParsing.BinaryStructs
{
    internal struct Dword
    {
        private readonly byte _byte1;
        private readonly byte _byte2;
        private readonly byte _byte3;
        private readonly byte _byte4;

        public Dword(IReadOnlyList<byte> bytes)
        {
            _byte1 = bytes[0];
            _byte2 = bytes[1];
            _byte3 = bytes[2];
            _byte4 = bytes[3];
        }

        public Dword(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            _byte1 = bytes[0];
            _byte2 = bytes[1];
            _byte3 = bytes[2];
            _byte4 = bytes[3];
        }

        public static bool operator ==(Dword first, Dword second) =>
            first._byte1 == second._byte1 &&
            first._byte2 == second._byte2 &&
            first._byte3 == second._byte3 &&
            first._byte4 == second._byte4;

        public static bool operator ==(Dword first, uint second)
        {
            var bytes = BitConverter.GetBytes(second);
            return
                first._byte1 == bytes[0] &&
                first._byte2 == bytes[1] &&
                first._byte3 == bytes[2] &&
                first._byte4 == bytes[3];
        }

        public static bool operator !=(Dword first, Dword second) => !(first == second);

        public static bool operator !=(Dword first, uint second) => !(first == second);

        public static implicit operator uint(Dword dword)
        {
            return (uint) dword._byte1 | dword._byte2 | dword._byte3 | dword._byte4;
        }

        public bool Equals(Dword other) =>
            _byte1 == other._byte1 &&
            _byte2 == other._byte2 &&
            _byte3 == other._byte3 &&
            _byte4 == other._byte4;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Dword && Equals((Dword)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _byte1.GetHashCode();
                hashCode = (hashCode * 397) ^ _byte2.GetHashCode();
                hashCode = (hashCode * 397) ^ _byte3.GetHashCode();
                hashCode = (hashCode * 397) ^ _byte4.GetHashCode();
                return hashCode;
            }
        }
    }
}