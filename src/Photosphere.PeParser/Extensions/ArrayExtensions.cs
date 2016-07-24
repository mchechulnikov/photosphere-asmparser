namespace Photosphere.PeParser.Extensions
{
    internal static class ArrayExtensions
    {
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            if (end < 0)
            {
                end = source.Length + end;
            }
            var length = end - start;
            var result = new T[length];
            for (var i = 0; i < length; i++)
            {
                result[i] = source[i + start];
            }
            return result;
        }
    }
}