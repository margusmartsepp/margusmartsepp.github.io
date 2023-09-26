using System;

namespace SearchingAlgorithms
{
    public static class InterpolationSearch
    {
        public static int Search(int[] sortedArray, int targetValue)
        {
            int lowerBound = 0, upperBound = sortedArray.Length - 1;

            while (lowerBound <= upperBound && targetValue >= sortedArray[lowerBound] && targetValue <= sortedArray[upperBound])
            {
                if (lowerBound == upperBound)
                {
                    if (sortedArray[lowerBound] == targetValue) return lowerBound;
                    return -1;
                }

                int estimatedPosition = lowerBound + ((targetValue - sortedArray[lowerBound]) * (upperBound - lowerBound)) / (sortedArray[upperBound] - sortedArray[lowerBound]);

                if (sortedArray[estimatedPosition] == targetValue)
                    return estimatedPosition;

                if (sortedArray[estimatedPosition] < targetValue)
                    lowerBound = estimatedPosition + 1;
                else
                    upperBound = estimatedPosition - 1;
            }
            return -1;
        }
    }
}
