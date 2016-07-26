using System;
using System.IO;

namespace Photosphere.PeParser
{
    public class DotNetAssemblyParser
    {
        public static byte[] GetMethod(string filePath)
        {
            var binaryReader = new BinaryReader(File.OpenRead(filePath));

            Check(binaryReader);

            return null;
        }

        private static void Check(BinaryReader binaryReader)
        {
            if (binaryReader.BaseStream.Length < 128)
            {
                throw new InvalidOperationException("Invalid file length");
            }

            if (binaryReader.ReadUInt16() != 0x5a4d)
            {
                throw new InvalidOperationException("Invalid DOS header");
            }

            binaryReader.BaseStream.Seek(58, SeekOrigin.Current);
            var peOffset = binaryReader.ReadUInt32();
            binaryReader.BaseStream.Seek(peOffset, SeekOrigin.Begin);

            if (binaryReader.ReadUInt32() != 0x00004550)
            {
                throw new InvalidOperationException("Invalid PE header");
            }
        }
    }
}