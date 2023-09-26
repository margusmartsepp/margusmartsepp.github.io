using System;

namespace SearchingAlgorithms
{
    public static class BinarySearch
    {
        public static int Search(int[] sortedArray, int targetValue)
        {
            int lowerBound = 0;
            int upperBound = sortedArray.Length - 1;

            while (lowerBound <= upperBound)
            {
                int midpoint = lowerBound + (upperBound - lowerBound) / 2;

                if (sortedArray[midpoint] == targetValue)
                {
                    return midpoint;
                }
                else if (sortedArray[midpoint] < targetValue)
                {
                    lowerBound = midpoint + 1;
                }
                else
                {
                    upperBound = midpoint - 1;
                }
            }

            return -1;  // Element not found
        }
    }
}
