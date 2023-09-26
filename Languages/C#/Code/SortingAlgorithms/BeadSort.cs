using System;

namespace SortingAlgorithms
{
    public static class BeadSort
    {
        public static void Sort(int[] numbersToSort)
        {
            int maximumValue = numbersToSort[0];
            for (int i = 1; i < numbersToSort.Length; i++)
            {
                if (numbersToSort[i] > maximumValue)
                {
                    maximumValue = numbersToSort[i];
                }
            }

            int[][] beadGrid = new int[numbersToSort.Length][];
            for (int i = 0; i < numbersToSort.Length; i++)
            {
                beadGrid[i] = new int[maximumValue];
            }

            // Drop the beads
            for (int i = 0; i < numbersToSort.Length; i++)
            {
                for (int j = 0; j < numbersToSort[i]; j++)
                {
                    beadGrid[i][j] = 1;
                }
            }

            // Count the beads
            for (int i = 0; i < maximumValue; i++)
            {
                int beadCount = 0;
                for (int j = 0; j < numbersToSort.Length; j++)
                {
                    beadCount += beadGrid[j][i];
                    beadGrid[j][i] = 0;
                }

                // Move the beads to the bottom
                for (int j = numbersToSort.Length - beadCount; j < numbersToSort.Length; j++)
                {
                    beadGrid[j][i] = 1;
                }
            }

            // Convert the grid back to the array
            for (int i = 0; i < numbersToSort.Length; i++)
            {
                int beadCount = 0;
                for (int j = 0; j < maximumValue; j++)
                {
                    beadCount += beadGrid[i][j];
                }
                numbersToSort[i] = beadCount;
            }
        }
    }
}
