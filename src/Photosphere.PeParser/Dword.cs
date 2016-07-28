using System;
using System.Collections.Generic;

namespace Photosphere.PeParser
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
    }
}