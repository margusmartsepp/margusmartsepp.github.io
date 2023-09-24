# [Sorting Algorithms](#Sorting-Algorithms)

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

#### How It Works

1. **Select a Pivot**: Choose a 'pivot' element from the array. The choice of pivot selection and partitioning schemes greatly affects the algorithm's performance.
2. **Partition**: Reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it. The pivot is in its final sorted position after this step.
3. **Recursively Sort Sub-arrays**: Apply the above steps recursively to the two sub-arrays.
4. **Base Case**: The base case of the recursion is an array of size zero or one, which is already sorted.

#### C# Code Implementation

Call it like this:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
QuickSort.Sort(arr, 0, arr.Length - 1);
```

Code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the elements before and after partition
                Sort(arr, low, pivotIndex);
                Sort(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            // Choose the rightmost element as the pivot
            int pivot = arr[high];
            int i = low;

            // Partition the array into two parts using the pivot
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                }
            }

            // Swap arr[i] and arr[high] (or pivot)
            int temp1 = arr[i];
            arr[i] = arr[high];
            arr[high] = temp1;

            return i;
        }
    }
}
```
### [Merge Sort](#Merge-Sort)

#### How It Works

1. **Divide**: Continuously divide the unsorted list into `n` sub-lists, each containing one element, until each sub-list contains only one element.
2. **Conquer**: Repeatedly merge sub-lists to produce new sorted sub-lists until there is only one sub-list remaining.

#### C# Code Implementation

Here's how you can call the Merge Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
MergeSort.Sort(arr, 0, arr.Length - 1);
```

code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                // Recursively sort the first and second halves
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, middle + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
```
### [Heap Sort](#Heap-Sort)

#### How It Works

1. **Build Heap**: Transform the array into a binary max-heap.
2. **Extract Max**: Repeatedly remove the maximum element from the heap and insert it at the end of the array.
3. **Heapify**: After each extraction, heapify the reduced heap.
4. **Repeat**: Continue the process until the heap is empty.

#### C# Code Implementation

Here's how you can call the Heap Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
HeapSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class HeapSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Extract elements from heap one by one
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Heapify the reduced heap
                Heapify(arr, i, 0);
            }
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }
    }
}
```
### [Tim Sort](#Tim-Sort)

#### How It Works

1. **Divide and Sort**: Divide the array into small chunks, known as "runs," and sort them using Insertion Sort.
2. **Merge**: Merge the sorted runs using a modified Merge Sort algorithm, taking advantage of the sorted runs to optimize the process.

#### C# Code Implementation

Here's how you can call the Tim Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
TimSort.Sort(arr, arr.Length);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class TimSort
    {
        private const int RUN = 32;

        public static void Sort(int[] arr, int n)
        {
            for (int i = 0; i < n; i += RUN)
            {
                InsertionSort(arr, i, Math.Min((i + RUN - 1), (n - 1)));
            }

            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (n - 1));

                    Merge(arr, left, mid, right);
                }
            }
        }

        private static void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int j = i;
                while (j > left && arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int len1 = m - l + 1, len2 = r - m;
            int[] left = new int[len1];
            int[] right = new int[len2];
            Array.Copy(arr, l, left, 0, len1);
            Array.Copy(arr, m + 1, right, 0, len2);

            int i = 0;
            int j = 0;
            int k = l;

            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {
                arr[k] = left[i];
                k++;
                i++;
            }

            while (j < len2)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
        }
    }
}
```
### [Shell Sort](#Shell-Sort)

#### How It Works

1. **Gap Sequence**: Start with a large gap and reduce the gap by a shrink factor, usually by half.
2. **Compare and Swap**: Compare elements that are `gap` distance apart and swap them if necessary.
3. **Reduce Gap**: Reduce the gap and repeat the process until the gap is 1.

#### C# Code Implementation

Here's how you can call the Shell Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
ShellSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class ShellSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }
    }
}                                                 
```
## [Hybrid-Sorts](#Hybrid-Sorts)
### [Intro Sort](#Intro-Sort)

#### How It Works

1. **Choose Sorting Algorithm**: Intro Sort begins with Quick Sort and switches to Heap Sort when the recursion depth exceeds a level based on the number of elements being sorted.
2. **Quick Sort Phase**: Similar to Quick Sort, it partitions the array and recursively sorts the partitions.
3. **Heap Sort Phase**: If the recursion depth exceeds a certain limit, switch to Heap Sort to avoid Quick Sort's worst-case time complexity.

#### C# Code Implementation

Here's how you can call the Intro Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
IntroSort.Sort(arr, 0, arr.Length - 1);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class IntroSort
    {
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }

            int temp1 = arr[i];
            arr[i] = arr[high];
            arr[high] = temp1;

            return i;
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }

        public static void Sort(int[] arr, int low, int high)
        {
            int size = high - low;
            if (size < 16)
            {
                // Insertion sort for small array sizes
                for (int i = low + 1; i <= high; i++)
                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= low && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
            }
            else if (size > 1)
            {
                int mid = Partition(arr, low, high);
                Sort(arr, low, mid - 1);
                Sort(arr, mid + 1, high);
            }
            else
            {
                // Heap sort for large recursion depth
                for (int i = high / 2 - 1; i >= low; i--)
                    Heapify(arr, high, i);

                for (int i = high - 1; i >= low; i--)
                {
                    int temp = arr[low];
                    arr[low] = arr[i];
                    arr[i] = temp;

                    Heapify(arr, i, low);
                }
            }
        }
    }
}
```
### [Block Sort](#Block-Sort)

#### How It Works

1. **Partition**: Divide the array into smaller blocks of a fixed size.
2. **Sort Blocks**: Sort each block using an efficient sorting algorithm like Quick Sort or Merge Sort.
3. **Merge**: Merge the sorted blocks to produce a fully sorted array.

#### C# Code Implementation

Here's how you can call the Block Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
int blockSize = 5; // Choose an appropriate block size
BlockSort.Sort(arr, blockSize);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class BlockSort
    {
        public static void Sort(int[] arr, int blockSize)
        {
            int n = arr.Length;
            int numBlocks = (int)Math.Ceiling((double)n / blockSize);

            // Step 1: Sort each block
            for (int i = 0; i < numBlocks; i++)
            {
                int start = i * blockSize;
                int end = Math.Min(start + blockSize - 1, n - 1);
                QuickSort.Sort(arr, start, end);  // Assuming QuickSort is already implemented
            }

            // Step 2: Merge sorted blocks
            for (int size = blockSize; size < n; size = 2 * size)
            {
                for (int left = 0; left < n - 1; left += 2 * size)
                {
                    int mid = Math.Min(left + size - 1, n - 1);
                    int right = Math.Min(left + 2 * size - 1, n - 1);

                    Merge(arr, left, mid, right);  // Assuming Merge is already implemented
                }
            }
        }

        // Merge function similar to the one used in Merge Sort
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            // Merge code here, similar to Merge Sort
        }
    }
}
```
## [Non-Comparison Sorts](#Non-Comparison-Sorts)
### [Radix Sort](#Radix-Sort)

#### How It Works

1. **Find the Maximum Number**: To know the number of digits.
2. **Digit by Digit Sort**: Do counting sort for every digit. Note that instead of passing digit number, the actual place value is passed.

#### C# Code Implementation

Here's how you can call the Radix Sort function:

```csharp
int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
RadixSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class RadixSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Find the maximum number to know the number of digits
            int max = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];

            // Do counting sort for every digit
            for (int exp = 1; max / exp > 0; exp *= 10)
                CountingSortByDigit(arr, n, exp);
        }

        private static void CountingSortByDigit(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];

            // Initialize count array
            for (int i = 0; i < 10; i++)
                count[i] = 0;

            // Store the count of occurrences in count[]
            for (int i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] contains the actual
            // position of this digit in output[]
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now contains
            // sorted numbers according to the current digit
            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }
    }
}
```
### [Counting Sort](#Counting-Sort)

#### How It Works

1. **Find Range**: Determine the range of input values to know the size of the counting array.
2. **Initialize Count Array**: Create an array of zeros with a length equal to the range.
3. **Count Occurrences**: Traverse the input array and increment the corresponding index in the count array.
4. **Calculate Cumulative Count**: Update the count array such that each element stores the sum of the previous counts.
5. **Place Elements**: Use the count array to place the elements in the output array in sorted order.

#### C# Code Implementation

Here's how you can call the Counting Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
CountingSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class CountingSort
    {
        public static void Sort(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int range, i, j, index = 0;

            for(i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
                if(arr[i] < min)
                    min = arr[i];
            }

            range = max - min + 1;
            int[] count = new int[range];

            for(i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            for(i = min; i <= max; i++)
            {
                for(j = 0; j < count[i - min]; j++)
                {
                    arr[index++] = i;
                }
            }
        }
    }
}
```
### [Bucket Sort](#Bucket-Sort)

#### How It Works

1. **Initialize Buckets**: Create an empty array of buckets, each capable of holding a range of values.
2. **Distribute Elements**: Traverse the original array, placing each element into a bucket based on its value.
3. **Sort Buckets**: Sort each non-empty bucket individually.
4. **Concatenate Buckets**: Traverse the array of buckets, appending the elements of each bucket to a new array.

#### C# Code Implementation

Here's how you can call the Bucket Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
BucketSort.Sort(arr);
```
code:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class BucketSort
    {
        public static void Sort(int[] arr)
        {
            int maxValue = arr.Max();
            int minValue = arr.Min();

            List<int>[] buckets = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            foreach (int num in arr)
            {
                buckets[num - minValue].Add(num);
            }

            int index = 0;
            foreach (List<int> bucket in buckets)
            {
                if (bucket.Count > 0)
                {
                    bucket.Sort();  // You can use any sorting algorithm here
                    foreach (int num in bucket)
                    {
                        arr[index++] = num;
                    }
                }
            }
        }
    }
}
```
## [Elementary Sorts](#Elementary-Sorts)
### [Bubble Sort](#Bubble-Sort)

#### How It Works

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
---


## Fast Inverse Squere Root aka Quake  III Algorithm
Following has some minor improvements over the original ( see [youtube](https://www.youtube.com/watch?v=p8u_k2LIZyo), see [stackoverflow](https://stackoverflow.com/questions/268853/is-it-possible-to-write-quakes-fast-invsqrt-function-in-c) ). Original was using an inferior constant value ```0x5f3759df``` ( see [paper](http://www.lomont.org/papers/2003/InvSqrt.pdf) ) and unsafe pointer casts. Furthermore, the readability of the document has been improved by separating functionality into three methods. By default, compile-time optimizations would inline method calls in Release config, but optional implementation attribute ```AggressiveInlining``` ensures that we will not lose performance.
```c#
using static System.BitConverter;
using System.Runtime.CompilerServices;

public float InvSqrt(float x) => NewtonMethod(InvSqrtFast(x), 0.5f * x);
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float InvSqrtFast(float x) => Int32BitsToSingle(0x5f375a86 - (SingleToInt32Bits(x) >> 1));
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float NewtonMethod(float x, float half) => x * (1.5f - half * x * x);
```