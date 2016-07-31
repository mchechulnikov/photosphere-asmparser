using System;
using System.Collections.Generic;

namespace Photosphere.AssemblyParser.BinaryParsing.BinaryStructs
{
    internal struct Qword : IBinaryStruct
    {
        private readonly byte _byte1;
        private readonly byte _byte2;
        private readonly byte _byte3;
        private readonly byte _byte4;
        private readonly byte _byte5;
        private readonly byte _byte6;
        private readonly byte _byte7;
        private readonly byte _byte8;

        public Qword(IReadOnlyList<byte> bytes)
        {
            _byte1 = bytes[0];
            _byte2 = bytes[1];
            _byte3 = bytes[2];
            _byte4 = bytes[3];
            _byte5 = bytes[4];
            _byte6 = bytes[5];
            _byte7 = bytes[6];
            _byte8 = bytes[7];
        }

        public Qword(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            _byte1 = bytes[0];
            _byte2 = bytes[1];
            _byte3 = bytes[2];
            _byte4 = bytes[3];
            _byte5 = bytes[4];
            _byte6 = bytes[5];
            _byte7 = bytes[6];
            _byte8 = bytes[7];
        }

        public static bool operator ==(Qword first, Qword second) =>
            first._byte1 == second._byte1 &&
            first._byte2 == second._byte2 &&
            first._byte3 == second._byte3 &&
            first._byte4 == second._byte4 &&
            first._byte5 == second._byte5 &&
            first._byte6 == second._byte6 &&
            first._byte7 == second._byte7 &&
            first._byte8 == second._byte8;

        public static bool operator ==(Qword first, uint second)
        {
            var bytes = BitConverter.GetBytes(second);
            return
                first._byte1 == bytes[0] &&
                first._byte2 == bytes[1] &&
                first._byte3 == bytes[2] &&
                first._byte4 == bytes[3] &&
                first._byte5 == bytes[4] &&
                first._byte6 == bytes[5] &&
                first._byte7 == bytes[6] &&
                first._byte8 == bytes[7];
        }

        public static bool operator !=(Qword first, Qword second) => !(first == second);

        public static bool operator !=(Qword first, uint second) => !(first == second);

        public static implicit operator uint(Qword dword)
        {
            return (uint)dword._byte1 | dword._byte2 | dword._byte3 | dword._byte4;
        }
    }
}