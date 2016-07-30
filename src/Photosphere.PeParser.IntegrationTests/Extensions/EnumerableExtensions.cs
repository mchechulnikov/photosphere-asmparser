using System.Collections.Generic;
using System.Linq;

namespace Photosphere.PeParser.IntegrationTests.Extensions
{
    internal static class EnumerableExtensions
    {
        public static bool IsNotEmpty<T>(this IEnumerable<T> enumerable) => !enumerable.IsNullOrEmpty();

        private static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable) => enumerable == null || !enumerable.Any();
    }
}