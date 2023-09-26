using System;

namespace SortingAlgorithms
{
    public static class RadixSort
    {
        public static void Sort(int[] inputArray)
        {
            int arrayLength = inputArray.Length;

            // Find the maximum number to determine the number of digits
            int maxNumber = FindMaxNumber(inputArray, arrayLength);

            // Perform counting sort for each digit
            for (int exponent = 1; maxNumber / exponent > 0; exponent *= 10)
            {
                CountingSortByDigit(inputArray, arrayLength, exponent);
            }
        }

        private static int FindMaxNumber(int[] inputArray, int arrayLength)
        {
            int maxNumber = inputArray[0];
            for (int i = 1; i < arrayLength; i++)
            {
                if (inputArray[i] > maxNumber)
                {
                    maxNumber = inputArray[i];
                }
            }
            return maxNumber;
        }

        private static void CountingSortByDigit(int[] inputArray, int arrayLength, int exponent)
        {
            int[] sortedArray = new int[arrayLength];
            int[] digitCount = new int[10];

            // Initialize count array
            Array.Clear(digitCount, 0, 10);

            // Count occurrences of each digit
            for (int i = 0; i < arrayLength; i++)
            {
                int digit = (inputArray[i] / exponent) % 10;
                digitCount[digit]++;
            }

            // Update count[i] to store the position of the next occurrence of the same digit
            for (int i = 1; i < 10; i++)
            {
                digitCount[i] += digitCount[i - 1];
            }

            // Build the sorted array
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                int digit = (inputArray[i] / exponent) % 10;
                sortedArray[digitCount[digit] - 1] = inputArray[i];
                digitCount[digit]--;
            }

            // Copy the sorted elements back into the original array
            for (int i = 0; i < arrayLength; i++)
            {
                inputArray[i] = sortedArray[i];
            }
        }
    }
}
