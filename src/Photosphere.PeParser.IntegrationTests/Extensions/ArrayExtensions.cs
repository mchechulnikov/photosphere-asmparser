namespace Photosphere.PeParser.IntegrationTests.Extensions
{
    internal static class ArrayExtensions
    {
        public static void PutFromBegining<T>(this T[] array, T[] sourceArray)
        {
            for (var i = 0; i < sourceArray.Length; i++)
            {
                array[i] = sourceArray[i];
            }
        }
    }
}