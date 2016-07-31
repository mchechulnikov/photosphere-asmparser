namespace Photosphere.AssemblyParser.AssemblyStructure
{
    internal static class AssemblyPartName
    {
        // DOS header
        public const string DosSignature = nameof(DosSignature);
        public const string DosHeaderContent = nameof(DosHeaderContent);
        public const string Lfanew = nameof(Lfanew);
        // PE header
        public const string PeSignature = nameof(PeSignature);
        public const string Machine = nameof(Machine);
        public const string NumberOfSections = nameof(NumberOfSections);
        public const string TimeDateStamp = nameof(TimeDateStamp);
        public const string PointerToSymbolTable = nameof(PointerToSymbolTable);
        public const string NumberOfSymbols = nameof(NumberOfSymbols);
        public const string OptionalHeaderSize = nameof(OptionalHeaderSize);
        public const string Characteristics = nameof(Characteristics);
        // Optional headers
        public const string Pe64 = nameof(Pe64);
        public const string LMajor = nameof(LMajor);
        public const string LMinor = nameof(LMinor);
        public const string CodeSize = nameof(CodeSize);
        public const string InitializedDataSize = nameof(InitializedDataSize);
        public const string UninitializedDataSize4 = nameof(UninitializedDataSize4);
        public const string EntryPointRva = nameof(EntryPointRva);
        public const string BaseOfCode = nameof(BaseOfCode);
        public const string BaseOfData = nameof(BaseOfData);
        // NTSpecificFieldsHeader
        public const string ImageBase = nameof(ImageBase);
        public const string SectionAlignment = nameof(SectionAlignment);
        public const string FileAlignement = nameof(FileAlignement);
        public const string OsMajor = nameof(OsMajor);
        public const string OsMinor = nameof(OsMinor);
        public const string UserMajor = nameof(UserMajor);
        public const string UserMinor = nameof(UserMinor);
        public const string SubSysMajor = nameof(SubSysMajor);
        public const string SubSysMinor = nameof(SubSysMinor);
        // public const string Reserved = nameof(Reserved);
        public const string ImageSize = nameof(ImageSize);
        public const string HeaderSize = nameof(HeaderSize);
        public const string FileChecksum = nameof(FileChecksum);
        public const string SubSystem = nameof(SubSystem);
        public const string DllFlags = nameof(DllFlags);
        public const string StackReserveSize = nameof(StackReserveSize);
        public const string StackCommitSize = nameof(StackCommitSize);
        public const string HeapReserveSize = nameof(HeapReserveSize);
        public const string HeapCommitSize = nameof(HeapCommitSize);
        public const string LoaderFlags = nameof(LoaderFlags);
        public const string NumberOfDataDir = nameof(NumberOfDataDir);
        // DataDirectoriesHeader
        public const string ExportTable = nameof(ExportTable);
        public const string ImportTable = nameof(ImportTable);
        public const string ResourceTable = nameof(ResourceTable);
        public const string ExceptionTable = nameof(ExceptionTable);
        public const string CertificateTable = nameof(CertificateTable);
        public const string BaseRelocationTable = nameof(BaseRelocationTable);
        public const string Debug = nameof(Debug);
        public const string Copyright = nameof(Copyright);
        public const string GlobalPtr = nameof(GlobalPtr);
        public const string TlsTable = nameof(TlsTable);
        public const string LoadConfigTable = nameof(LoadConfigTable);
        public const string BoundImport = nameof(BoundImport);
        public const string Iat = nameof(Iat);
        public const string DelayImportDescriptor = nameof(DelayImportDescriptor);
        public const string CliHeader = nameof(CliHeader);

        // System
        public const string Reserved = nameof(Reserved);
    }
}