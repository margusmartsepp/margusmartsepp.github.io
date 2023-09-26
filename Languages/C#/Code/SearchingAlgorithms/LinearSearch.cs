using System;

namespace SearchingAlgorithms
{
    public static class LinearSearch
    {
        public static int Search(int[] arrayToSearch, int targetValue)
        {
            for (int index = 0; index < arrayToSearch.Length; index++)
            {
                if (arrayToSearch[index] == targetValue)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
