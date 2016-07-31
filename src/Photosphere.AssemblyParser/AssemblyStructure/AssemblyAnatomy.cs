using System.Collections.Generic;
using Photosphere.AssemblyParser.BinaryParsing.BinaryStructs;

namespace Photosphere.AssemblyParser.AssemblyStructure
{
    internal static class AssemblyAnatomy
    {
        public static IReadOnlyList<AssemblyPart> Parts = new List<AssemblyPart>
        {
            // DOS header
            { new AssemblyPart(AssemblyPartName.DosSignature, new Dword(0x4d5a)) },
            { new AssemblyPart(AssemblyPartName.DosHeaderContent, 58) },
            { new AssemblyPart(AssemblyPartName.Lfanew, BinarySize.Dword) },
            // PE header
            { new AssemblyPart(AssemblyPartName.PeSignature, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.Machine, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.NumberOfSections, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.TimeDateStamp, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.PointerToSymbolTable, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.NumberOfSymbols, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.OptionalHeaderSize, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.Characteristics, BinarySize.Word) },
            // Optional headers
            { new AssemblyPart(AssemblyPartName.Pe64, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.LMajor, BinarySize.Byte) },
            { new AssemblyPart(AssemblyPartName.LMinor, BinarySize.Byte) },
            { new AssemblyPart(AssemblyPartName.CodeSize, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.InitializedDataSize, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.UninitializedDataSize4, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.EntryPointRva, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.BaseOfCode, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.BaseOfData, BinarySize.Dword, 0) },
            // NTSpecificFieldsHeader
            { new AssemblyPart(AssemblyPartName.ImageBase, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.SectionAlignment, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.FileAlignement, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.OsMajor, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.OsMinor, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.UserMajor, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.UserMinor, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.SubSysMajor, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.SubSysMinor, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.Reserved, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.ImageSize, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.HeaderSize, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.FileChecksum,BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.SubSystem, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.DllFlags, BinarySize.Word) },
            { new AssemblyPart(AssemblyPartName.StackReserveSize, BinarySize.Dword, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.StackCommitSize, BinarySize.Dword, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.HeapReserveSize, BinarySize.Dword, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.HeapCommitSize, BinarySize.Dword, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.LoaderFlags, BinarySize.Dword) },
            { new AssemblyPart(AssemblyPartName.NumberOfDataDir, BinarySize.Dword) },
            // DataDirectoriesHeader
            { new AssemblyPart(AssemblyPartName.ExportTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.ImportTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.ResourceTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.ExceptionTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.CertificateTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.BaseRelocationTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.Debug, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.Copyright, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.GlobalPtr, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.TlsTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.LoadConfigTable, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.BoundImport, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.Iat, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.DelayImportDescriptor, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.CliHeader, BinarySize.Qword) },
            { new AssemblyPart(AssemblyPartName.Reserved, BinarySize.Qword) }
        };
    }
}