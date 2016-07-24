namespace Photosphere.PeParser.PeContent.Headers
{
    public class DosHeader
    {
        public DosHeader(uint peOffcet)
        {
            PeOffcet = peOffcet;
        }

        public uint PeOffcet { get; }
    }
}