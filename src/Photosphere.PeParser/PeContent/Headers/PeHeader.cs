namespace Photosphere.PeParser.PeContent.Headers
{
    public class PeHeader
    {
        public PeHeader(bool isDll)
        {
            IsDll = isDll;
        }

        public bool IsDll { get; }
    }
}