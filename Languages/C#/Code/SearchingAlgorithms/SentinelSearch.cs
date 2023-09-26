using System;

namespace SearchingAlgorithms
{
    public static class SentinelSearch
    {
        public static int Search(int[] arrayToSearch, int targetElement)
        {
            // Append the target as a sentinel at the end of the array
            int lastElement = arrayToSearch[arrayToSearch.Length - 1];
            arrayToSearch[arrayToSearch.Length - 1] = targetElement;

            int index = 0;
            while (arrayToSearch[index] != targetElement)
            {
                index++;
            }

            // Restore the last element
            arrayToSearch[arrayToSearch.Length - 1] = lastElement;

            // Element found, return its index
            if (index < arrayToSearch.Length - 1 || arrayToSearch[arrayToSearch.Length - 1] == targetElement)
            {
                return index;
            }

            // Element not found
            return -1;
        }
    }
}
