# [Sorting Algorithms](#Sorting-Algorithms)
TODO: Include benchmark tests and their results to analyze the performance of the algorithm.
TODO: Consider implementing both iterative and recursive variants of the algorithm to compare their efficiency.
TODO: Different data structures have varying performance characteristics for operations such as adding, inserting, deleting, maintaining, and lookup. It's important to consider these differences when choosing the appropriate data structure for your algorithm.
TODO: Keep in mind that an algorithm may be efficient for one data structure but not necessarily for all. So, it's crucial to consider the specific requirements and constraints of your problem.
TODO: Consider utilizing generics, which allow for the creation of reusable algorithms that can work with different data types. This can enhance the flexibility and versatility of your code.

| [Category](#Category)   | Algorithm (Link to .md) | Time Complexity (Worst, Average, Best) | Memory Complexity | Performance Metrics |
|-------------------------|--------------------------|----------------------------------------|-------------------|---------------------|
| [Efficient Sorts](#Efficient-Sorts) | [Quick Sort](#Quick-Sort) | O(n^2), O(n log n), O(n log n) | O(log n) | Average-Case Time Complexity, Data Sensitivity (Varies) |
| [Efficient Sorts](#Efficient-Sorts) | [Merge Sort](#Merge-Sort) | O(n log n), O(n log n), O(n log n) | O(n) | Average-Case Time Complexity |
| [Efficient Sorts](#Efficient-Sorts) | [Heap Sort](#Heap-Sort) | O(n log n), O(n log n), O(n log n) | O(1) | Worst-Case Time Complexity |
| [Efficient Sorts](#Efficient-Sorts) | [Tim Sort](#Tim-Sort) | O(n log n), O(n log n), O(n log n) | O(n) | Average-Case Time Complexity |
| [Efficient Sorts](#Efficient-Sorts) | [Shell Sort](#Shell-Sort) | O(n^2), O(n log^2 n), O(n log n) | O(1) | Worst-Case Time Complexity |
| [Hybrid Sorts](#Hybrid-Sorts) | [Intro Sort](#Intro-Sort) | O(n log n), O(n log n), O(n log n) | O(log n) | Average-Case Time Complexity |
| [Hybrid Sorts](#Hybrid-Sorts) | [Block Sort](#Block-Sort) | O(n log n), O(n log n), O(n log n) | O(n) | Average-Case Time Complexity |
| [Non-Comparison Sorts](#Non-Comparison-Sorts) | [Radix Sort](#Radix-Sort) | O(nk), O(nk), O(nk) | O(n+k) | Average-Case Time Complexity |
| [Non-Comparison Sorts](#Non-Comparison-Sorts) | [Counting Sort](#Counting-Sort) | O(n+k), O(n+k), O(n+k) | O(k) | Average-Case Time Complexity |
| [Non-Comparison Sorts](#Non-Comparison-Sorts) | [Bucket Sort](#Bucket-Sort) | O(n^2), O(n+k), O(n+k) | O(n) | Worst-Case Time Complexity, Data Sensitivity (Varies) |
| [Elementary Sorts](#Elementary-Sorts) | [Bubble Sort](#Bubble-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity, Data Sensitivity (Stable) |
| [Elementary Sorts](#Elementary-Sorts) | [Insertion Sort](#Insertion-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity, Data Sensitivity (Stable) |
| [Elementary Sorts](#Elementary-Sorts) | [Selection Sort](#Selection-Sort) | O(n^2), O(n^2), O(n^2) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Cocktail Sort](#Cocktail-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Odd-Even Sort](#Odd-Even-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Gnome Sort](#Gnome-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Comb Sort](#Comb-Sort) | O(n^2), O(n^2/log n), O(n) | O(1) | Worst-Case Time Complexity |
| [Special-Purpose Sorts](#Special-Purpose-Sorts) | [Pancake Sort](#Pancake-Sort) | O(n), O(n), O(n) | O(1) | Worst-Case Time Complexity |
| [Special-Purpose Sorts](#Special-Purpose-Sorts) | [Stooge Sort](#Stooge-Sort) | O(n^(log 3/log 1.5)), O(n^(log 3/log 1.5)), O(n^(log 3/log 1.5)) | O(1) | Worst-Case Time Complexity |
| [Special-Purpose Sorts](#Special-Purpose-Sorts) | [Bead Sort](#Bead-Sort) | O(n), O(n), O(n) | O(n) | Worst-Case Time Complexity |

---
## [Efficient-Sorts](#Quick-Sort)
### [Quick Sort](#Quick-Sort)

**How It Works**

1. **Select a Pivot**: Choose a 'pivot' element from the array. The choice of pivot selection and partitioning schemes greatly affects the algorithm's performance.
2. **Partition**: Reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it. The pivot is in its final sorted position after this step.
3. **Recursively Sort Sub-arrays**: Apply the above steps recursively to the two sub-arrays.
4. **Base Case**: The base case of the recursion is an array of size zero or one, which is already sorted.

| Code | Tests |
|------|-------|
| [QuickSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/QuickSort.cs) | [QuickSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/QuickSortTests.cs) |

### [Merge Sort](#Merge-Sort)

**How It Works**

1. **Divide**: Continuously divide the unsorted list into `n` sub-lists, each containing one element, until each sub-list contains only one element.
2. **Conquer**: Repeatedly merge sub-lists to produce new sorted sub-lists until there is only one sub-list remaining.

| Code | Tests |
|------|-------|
| [MergeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/MergeSort.cs) | [MergeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/MergeSortTests.cs) |

### [Heap Sort](#Heap-Sort)

**How It Works**

1. **Build Heap**: Transform the array into a binary max-heap.
2. **Extract Max**: Repeatedly remove the maximum element from the heap and insert it at the end of the array.
3. **Heapify**: After each extraction, heapify the reduced heap.
4. **Repeat**: Continue the process until the heap is empty.

| Code | Tests |
|------|-------|
| [HeapSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/HeapSort.cs) | [HeapSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/HeapSortTests.cs) |

### [Tim Sort](#Tim-Sort)

**How It Works**

1. **Divide and Sort**: Divide the array into small chunks, known as "runs," and sort them using Insertion Sort.
2. **Merge**: Merge the sorted runs using a modified Merge Sort algorithm, taking advantage of the sorted runs to optimize the process.

| Code | Tests |
|------|-------|
| [TimSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/TimSort.cs) | [TimSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/TimSortTests.cs) |

### [Shell Sort](#Shell-Sort)

**How It Works**

1. **Gap Sequence**: Start with a large gap and reduce the gap by a shrink factor, usually by half.
2. **Compare and Swap**: Compare elements that are `gap` distance apart and swap them if necessary.
3. **Reduce Gap**: Reduce the gap and repeat the process until the gap is 1.

| Code | Tests |
|------|-------|
| [ShellSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/ShellSort.cs) | [ShellSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/ShellSortTests.cs) |
                                                 
## [Hybrid-Sorts](#Hybrid-Sorts)
### [Intro Sort](#Intro-Sort)

**How It Works**

1. **Choose Sorting Algorithm**: Intro Sort begins with Quick Sort and switches to Heap Sort when the recursion depth exceeds a level based on the number of elements being sorted.
2. **Quick Sort Phase**: Similar to Quick Sort, it partitions the array and recursively sorts the partitions.
3. **Heap Sort Phase**: If the recursion depth exceeds a certain limit, switch to Heap Sort to avoid Quick Sort's worst-case time complexity.

| Code | Tests |
|------|-------|
| [IntroSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/IntroSort.cs) | [IntroSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/IntroSortTests.cs) |

### [Block Sort](#Block-Sort)

**How It Works**

1. **Partition**: Divide the array into smaller blocks of a fixed size.
2. **Sort Blocks**: Sort each block using an efficient sorting algorithm like Quick Sort or Merge Sort.
3. **Merge**: Merge the sorted blocks to produce a fully sorted array.

| Code | Tests |
|------|-------|
| [BlockSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/BlockSort.cs) | [BlockSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/BlockSortTests.cs) |

## [Non-Comparison Sorts](#Non-Comparison-Sorts)
### [Radix Sort](#Radix-Sort)

**How It Works**

1. **Find the Maximum Number**: To know the number of digits.
2. **Digit by Digit Sort**: Do counting sort for every digit. Note that instead of passing digit number, the actual place value is passed.

| Code | Tests |
|------|-------|
| [RadixSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/RadixSort.cs) | [RadixSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/RadixSortTests.cs) |

### [Counting Sort](#Counting-Sort)

**How It Works**

1. **Find Range**: Determine the range of input values to know the size of the counting array.
2. **Initialize Count Array**: Create an array of zeros with a length equal to the range.
3. **Count Occurrences**: Traverse the input array and increment the corresponding index in the count array.
4. **Calculate Cumulative Count**: Update the count array such that each element stores the sum of the previous counts.
5. **Place Elements**: Use the count array to place the elements in the output array in sorted order.

| Code | Tests |
|------|-------|
| [CountingSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/CountingSort.cs) | [CountingSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/CountingSortTests.cs) |

### [Bucket Sort](#Bucket-Sort)

**How It Works**

1. **Initialize Buckets**: Create an empty array of buckets, each capable of holding a range of values.
2. **Distribute Elements**: Traverse the original array, placing each element into a bucket based on its value.
3. **Sort Buckets**: Sort each non-empty bucket individually.
4. **Concatenate Buckets**: Traverse the array of buckets, appending the elements of each bucket to a new array.

| Code | Tests |
|------|-------|
| [BucketSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/BucketSort.cs) | [BucketSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/BucketSortTests.cs) |

## [Elementary Sorts](#Elementary-Sorts)
### [Bubble Sort](#Bubble-Sort)

**How It Works**

1. **Iterate**: Traverse through the list, comparing adjacent elements.
2. **Swap**: If the adjacent elements are in the wrong order, swap them.
3. **Repeat**: Continue the process for each element, ignoring the last sorted element in each iteration.
4. **Terminate**: The algorithm terminates when no more swaps are needed, indicating that the list is sorted.

#### C# Code Implementation

Here's how you can call the Bubble Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
BubbleSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the list is sorted
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
```
### [Insertion Sort](#Insertion-Sort)

#### How It Works

1. **Iterate**: Traverse from the second element to the last element in the array.
2. **Compare and Insert**: For each element, compare it with the elements before it and insert it into its correct position by swapping.
3. **Repeat**: Continue the process for each of the elements in the array.

#### C# Code Implementation

Here's how you can call the Insertion Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
InsertionSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
```
### [Selection Sort](#Selection-Sort)

#### How It Works

1. **Find Minimum Element**: Traverse the array to find the minimum element.
2. **Swap**: Swap the minimum element found with the first element of the array.
3. **Iterate**: Move the boundary of the unsorted array one element ahead and repeat steps 1 and 2 until the array is sorted.

#### C# Code Implementation

Here's how you can call the Selection Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
SelectionSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap arr[minIndex] and arr[i]
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
```
### [Cocktail Sort](#Cocktail-Sort)

#### How It Works

1. **Bi-Directional Traversal**: Unlike Bubble Sort, which only traverses the list in one direction, Cocktail Sort traverses the list in both directions.
2. **Forward Pass**: Compare adjacent elements and swap them if they are in the wrong order, moving from the beginning to the end of the list.
3. **Backward Pass**: Similar to the forward pass, but moves from the end to the beginning of the list.
4. **Repeat**: Continue the process of forward and backward passes until the list is sorted.

#### C# Code Implementation

Here's how you can call the Cocktail Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
CocktailSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class CocktailSort
    {
        public static void Sort(int[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped)
            {
                // Reset the swapped flag on entering the loop,
                // because it might be true from a previous iteration.
                swapped = false;

                // Forward pass
                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                // If nothing moved, array is sorted.
                if (!swapped)
                    break;

                // Otherwise, reset the swapped flag so that it can be used in the next stage.
                swapped = false;

                // Move the end point back by one, because the item at the end is in its rightful place.
                end--;

                // Backward pass
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                // Increment the starting point, because the last stage would have moved the next smallest number to its rightful place.
                start++;
            }
        }
    }
}
```
### [Odd-Even Sort](#Odd-Even-Sort)

#### How It Works

1. **Odd-Even Phase**: Compare all odd-indexed elements with their next adjacent elements and swap them if they are out of order.
2. **Even-Odd Phase**: Compare all even-indexed elements with their next adjacent elements and swap them if they are out of order.
3. **Repeat**: Continue alternating between the odd-even and even-odd phases until the array is sorted.

#### C# Code Implementation

Here's how you can call the Odd-Even Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
OddEvenSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class OddEvenSort
    {
        public static void Sort(int[] arr)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                // Odd-Even Phase
                for (int i = 1; i <= arr.Length - 2; i += 2)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        isSorted = false;
                    }
                }

                // Even-Odd Phase
                for (int i = 0; i <= arr.Length - 2; i += 2)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
```
### [Gnome Sort](#Gnome-Sort)

#### How It Works

1. **Initialize**: Start at the first element as the current element.
2. **Compare and Swap**: Compare the current element with the next element. If the current element is greater than the next element, they are swapped.
3. **Advance or Retreat**: If the swap was made or you're at the start of the array, move one position forward. Otherwise, move one position backward.
4. **Iterate**: Repeat steps 2-3 until the array is sorted.

#### C# Code Implementation

Here's how you can call the Gnome Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
GnomeSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class GnomeSort
    {
        public static void Sort(int[] arr)
        {
            int index = 0;
            int n = arr.Length;

            while (index < n)
            {
                if (index == 0)
                    index++;
                if (arr[index] >= arr[index - 1])
                    index++;
                else
                {
                    int temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }
        }
    }
}
```
### [Comb Sort](#Comb-Sort)

#### How It Works

1. **Initialize Gap**: Start with a large gap and reduce it by a shrink factor (commonly 1.3).
2. **Compare and Swap**: Compare elements that are `gap` distance apart and swap them if they are in the wrong order.
3. **Reduce Gap**: Reduce the gap and repeat the process until the gap becomes 1.
4. **Final Pass**: Perform a final pass with a gap of 1 to ensure the array is fully sorted.

#### C# Code Implementation

Here's how you can call the Comb Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
CombSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class CombSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Initialize gap
            int gap = n;

            // Initialize shrink factor
            float shrink = 1.3f;

            // Initialize sorted
            bool sorted = false;

            while (!sorted)
            {
                // Update the gap value for the next comb
                gap = (int)(gap / shrink);
                if (gap <= 1)
                {
                    gap = 1;
                    sorted = true;
                }

                // Compare and swap elements with gap distance
                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        // Swap arr[i] and arr[i + gap]
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;

                        sorted = false;
                    }
                }
            }
        }
    }
}
```
### [Pancake Sort](#Pancake-Sort)

#### How It Works

1. **Find Max**: Locate the maximum element in the array.
2. **Flip**: Use a spatula (figuratively speaking) to flip the array from the start to the maximum element, bringing the maximum element to the front.
3. **Flip Again**: Flip the array from the start to the current length of the unsorted partition to move the maximum element to its correct position.
4. **Repeat**: Reduce the length of the unsorted partition by one and go back to the first step, until the array is sorted.

#### C# Code Implementation

Here's how you can call the Pancake Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
PancakeSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class PancakeSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int currSize = n; currSize > 1; --currSize)
            {
                int maxIndex = FindMax(arr, currSize);

                if (maxIndex != currSize - 1)
                {
                    Flip(arr, maxIndex);
                    Flip(arr, currSize - 1);
                }
            }
        }

        private static int FindMax(int[] arr, int n)
        {
            int maxIndex = 0;
            for (int i = 1; i < n; ++i)
            {
                if (arr[i] > arr[maxIndex])
                    maxIndex = i;
            }
            return maxIndex;
        }

        private static void Flip(int[] arr, int i)
        {
            int start = 0;
            while (start < i)
            {
                int temp = arr[start];
                arr[start] = arr[i];
                arr[i] = temp;
                start++;
                i--;
            }
        }
    }
}
```
### [Stooge Sort](#Stooge-Sort)

#### How It Works

1. **Divide**: Divide the array into three parts.
2. **Recursively Sort**: Recursively sort the first two-thirds, then the last two-thirds, and finally the first two-thirds again.
3. **Conquer**: If the value at the start is greater than the value at the end, swap them.

#### C# Code Implementation

Here's how you can call the Stooge Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
StoogeSort.Sort(arr, 0, arr.Length - 1);
```
code
```csharp
using System;

namespace SortingAlgorithms
{
    public static class StoogeSort
    {
        public static void Sort(int[] arr, int l, int h)
        {
            if (l >= h)
                return;

            // If first element is larger than the last, swap them
            if (arr[l] > arr[h])
            {
                int temp = arr[l];
                arr[l] = arr[h];
                arr[h] = temp;
            }

            // If there are more than 2 elements in the array
            if (h - l + 1 > 2)
            {
                int t = (h - l + 1) / 3;

                // Recursively sort the first two-thirds, last two-thirds, and first two-thirds again
                Sort(arr, l, h - t);
                Sort(arr, l + t, h);
                Sort(arr, l, h - t);
            }
        }
    }
}
```
### [Bead Sort](#Bead-Sort)

#### How It Works

1. **Initialization**: Create a set of bins, each representing a digit in the numbers to be sorted.
2. **Drop Beads**: For each number, drop a bead in each bin corresponding to the value of that digit.
3. **Count Beads**: Count the number of beads in each bin, from top to bottom, to obtain the sorted numbers.

#### C# Code Implementation

Here's how you can call the Bead Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
BeadSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class BeadSort
    {
        public static void Sort(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[][] grid = new int[arr.Length][];
            for (int i = 0; i < arr.Length; i++)
            {
                grid[i] = new int[max];
            }

            // Drop the beads
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    grid[i][j] = 1;
                }
            }

            // Count the beads
            for (int i = 0; i < max; i++)
            {
                int beads = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    beads += grid[j][i];
                    grid[j][i] = 0;
                }

                // Move the beads to the bottom
                for (int j = arr.Length - beads; j < arr.Length; j++)
                {
                    grid[j][i] = 1;
                }
            }

            // Convert the grid back to the array
            for (int i = 0; i < arr.Length; i++)
            {
                int beads = 0;
                for (int j = 0; j < max; j++)
                {
                    beads += grid[i][j];
                }
                arr[i] = beads;
            }
        }
    }
}
```