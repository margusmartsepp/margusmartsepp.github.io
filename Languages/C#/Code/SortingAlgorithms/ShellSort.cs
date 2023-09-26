using System;

namespace SortingAlgorithms
{
    public static class ShellSort
    {
        public static void Sort(int[] numbersToSort)
        {
            int arraySize = numbersToSort.Length;
            int gap = arraySize / 2;

            while (gap > 0)
            {
                for (int currentIndex = gap; currentIndex < arraySize; currentIndex++)
                {
                    int currentNumber = numbersToSort[currentIndex];
                    int gapIndex;

                    for (gapIndex = currentIndex; gapIndex >= gap && numbersToSort[gapIndex - gap] > currentNumber; gapIndex -= gap)
                    {
                        numbersToSort[gapIndex] = numbersToSort[gapIndex - gap];
                    }

                    numbersToSort[gapIndex] = currentNumber;
                }

                gap /= 2;
            }
        }
    }
}
