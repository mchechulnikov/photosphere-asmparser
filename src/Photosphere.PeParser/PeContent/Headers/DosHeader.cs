namespace Photosphere.PeParser.PeContent.Headers
{
    public class DosHeader
    {
        public DosHeader(byte[] content, int peOffcet)
        {
            Content = content;
            PeOffcet = peOffcet;
        }

        public byte[] Content { get; }

        public int PeOffcet { get; }
    }
}