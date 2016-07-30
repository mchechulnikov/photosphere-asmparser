using System;
using System.IO;

namespace Photosphere.AssemblyParser.IntegrationTests.TestUtils
{
    internal class TemporaryFile : IDisposable
    {
        public const string Path = "temp_test_file.dat";
        private readonly FileStream _file;

        public TemporaryFile(byte[] bytes)
        {
            _file = File.OpenWrite(Path);
            _file.Write(bytes, 0, bytes.Length);
            _file.Close();
        }

        public void Dispose()
        {
            _file.Dispose();
            File.Delete(Path);
        }
    }
}