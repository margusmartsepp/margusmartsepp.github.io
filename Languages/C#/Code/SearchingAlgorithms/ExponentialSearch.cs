using System;

namespace SearchingAlgorithms
{
    public static class ExponentialSearch
    {
        public static int Search(int[] arrayToSearch, int targetValue)
        {
            int arrayLength = arrayToSearch.Length;

            if (arrayToSearch[0] == targetValue)
                return 0;

            int index = 1;
            while (index < arrayLength && arrayToSearch[index] <= targetValue)
                index *= 2;

            return BinarySearch(arrayToSearch, index / 2, Math.Min(index, arrayLength - 1), targetValue);
        }

        private static int BinarySearch(int[] arrayToSearch, int leftIndex, int rightIndex, int targetValue)
        {
            while (leftIndex <= rightIndex)
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (arrayToSearch[midIndex] == targetValue)
                    return midIndex;

                if (arrayToSearch[midIndex] < targetValue)
                    leftIndex = midIndex + 1;
                else
                    rightIndex = midIndex - 1;
            }

            return -1;
        }
    }
}
