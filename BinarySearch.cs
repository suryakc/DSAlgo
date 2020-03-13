using System.Collections.Generic;

namespace Algorithmics.Search
{
    public static class BinarySearch
    {
        public static int? Find(List<int> haystack, int needle)
        {
            return FindInternal(haystack, needle, 0, haystack.Count - 1);
        }

        private static int? FindInternal(List<int> haystack, int needle, int min, int max)
        {
            if (0 >= haystack.Count || min >= max)
                return -1;
            var middle = min + (max - min) / 2;
            if (needle == haystack[middle])
                return middle;
            
            if (needle < haystack[middle])
                return FindInternal(haystack, needle, min, middle - 1);
            return FindInternal(haystack, needle, middle + 1, max);
        }
    }
}