using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class BucketSort
    {
        public static void Sort(int[] inputArray)
        {
            int maxValue = inputArray.Max();
            int minValue = inputArray.Min();

            List<int>[] buckets = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            foreach (int number in inputArray)
            {
                buckets[number - minValue].Add(number);
            }

            int outputIndex = 0;
            foreach (List<int> bucket in buckets)
            {
                if (bucket.Count > 0)
                {
                    bucket.Sort();  // You can use any sorting algorithm here
                    foreach (int sortedNumber in bucket)
                    {
                        inputArray[outputIndex++] = sortedNumber;
                    }
                }
            }
        }
    }
}
