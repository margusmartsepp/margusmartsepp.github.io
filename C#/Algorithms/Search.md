# [Search Algorithms](#Search-Algorithms)

| [Category](#Category)   | Algorithm (Link to .md) | Time Complexity (Worst, Average, Best) | Memory Complexity | Performance Metrics |
|-------------------------|--------------------------|----------------------------------------|-------------------|---------------------|
| [Divide and Conquer](#Divide-and-Conquer) | [Binary Search](#Binary-Search) | \(O(log n), O(log n), O(1)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Divide and Conquer](#Divide-and-Conquer) | [Interpolation Search](#Interpolation-Search) | \(O(n), O(log log n), O(1)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (Yes) |
| [Divide and Conquer](#Divide-and-Conquer) | [Exponential Search](#Exponential-Search) | \(O(log n), O(log n), O(1)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Divide and Conquer](#Divide-and-Conquer) | [Fibonacci Search](#Fibonacci-Search) | \(O(log n), O(log n), O(1)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Linear](#Linear) | [Linear Search](#Linear-Search) | \(O(n), O(n), O(1)\) | \(O(1)\) | Worst-Case Time Complexity, Data Sensitivity (No) |
| [Linear](#Linear) | [Sentinel Search](#Sentinel-Search) | \(O(n), O(n), O(1)\) | \(O(1)\) | Worst-Case Time Complexity, Data Sensitivity (No) |
| [Linear](#Linear) | [Sublist Search](#Sublist-Search) | \(O(n), O(n), O(1)\) | \(O(1)\) | Worst-Case Time Complexity, Data Sensitivity (No) |
| [Hash-based](#Hash-based) | [Direct Addressing](#Direct-Addressing) | \(O(1), O(1), O(1)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Hash-based](#Hash-based) | [Open Hashing](#Open-Hashing) | \(O(n), O(1), O(1)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Hash-based](#Hash-based) | [Closed Hashing](#Closed-Hashing) | \(O(n), O(1), O(1)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Tree-based](#Tree-based) | [Binary Search Tree](#Binary-Search-Tree) | \(O(n), O(log n), O(log n)\) | \(O(n)\) | Worst-Case Time Complexity, Data Sensitivity (Yes) |
| [Tree-based](#Tree-based) | [Balanced Trees (AVL, RB)](#Balanced-Trees) | \(O(log n), O(log n), O(log n)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (Yes) |
| [Tree-based](#Tree-based) | [B-trees](#B-trees) | \(O(log n), O(log n), O(log n)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Tree-based](#Tree-based) | [Ternary Search Tree](#Ternary-Search-Tree) | \(O(log n), O(log n), O(log n)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (Yes) |
| [Graph-based](#Graph-based) | [Depth-First Search (DFS)](#Depth-First-Search) | \(O(V + E), O(V + E), O(V + E)\) | \(O(V)\) | Worst-Case Time Complexity, Data Sensitivity (No) |
| [Graph-based](#Graph-based) | [Breadth-First Search (BFS)](#Breadth-First-Search) | \(O(V + E), O(V + E), O(V + E)\) | \(O(V)\) | Worst-Case Time Complexity, Data Sensitivity (No) |
| [Graph-based](#Graph-based) | [A* Search](#A-Search) | \(O(V), O(V), O(V)\) | \(O(V)\) | Average-Case Time Complexity, Data Sensitivity (Yes) |
| [Graph-based](#Graph-based) | [Dijkstra's Algorithm](#Dijkstras-Algorithm) | \(O(V^2), O(V log V), O(V log V)\) | \(O(V)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Probabilistic](#Probabilistic) | [Bloom Filters](#Bloom-Filters) | \(O(1), O(1), O(1)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Probabilistic](#Probabilistic) | [Locality-Sensitive Hashing](#Locality-Sensitive-Hashing) | \(O(1), O(1), O(1)\) | \(O(n)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [Probabilistic](#Probabilistic) | [Randomized Binary Search](#Randomized-Binary-Search) | \(O(log n), O(log n), O(1)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [String Matching](#String-Matching) | [Rabin-Karp](#Rabin-Karp) | \(O(n^2), O(n), O(n)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [String Matching](#String-Matching) | [KMP](#KMP) | \(O(n), O(n), O(n)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |
| [String Matching](#String-Matching) | [Boyer-Moore](#Boyer-Moore) | \(O(n), O(n), O(n)\) | \(O(1)\) | Average-Case Time Complexity, Data Sensitivity (No) |




---
## [Divide and Conquer](#Divide-and-Conquer)

### [Binary Search](#Binary-Search)

#### How It Works

1. **Initialize Pointers**: Start with two pointers, `low` and `high`, initialized to the first and last indices of the sorted array, respectively.
2. **Calculate Midpoint**: Calculate the midpoint index between `low` and `high`.
3. **Compare**: Compare the element at the midpoint with the target value.
    - If it's equal, return the midpoint index.
    - If it's less, set `low` to `midpoint + 1` and repeat from step 2.
    - If it's greater, set `high` to `midpoint - 1` and repeat from step 2.
4. **Not Found**: If `low` exceeds `high`, the element is not in the array.

#### C# Code Implementation

Here's how you can call the Binary Search function:

```csharp
int[] arr = { 2, 3, 5, 7, 9, 10, 11, 12, 14 };
int target = 10;
int result = BinarySearch.Search(arr, target);
```
code:
```csharp
using System;

namespace SearchingAlgorithms
{
    public static class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;  // Element not found
        }
    }
}
```
### [Interpolation Search](#Interpolation-Search)

#### How It Works

1. **Calculate Position**: Use the formula `pos = low + [ (x - arr[low]) * (high - low) / (arr[high] - arr[low]) ]` to find the position where the element might be.
2. **Check Bounds**: Ensure that the calculated position is within the bounds of the array.
3. **Compare and Move**: Compare the element at the calculated position with the target. If it matches, return the position. Otherwise, adjust the `low` and `high` pointers accordingly.
4. **Repeat**: Continue the process until the element is found or the search interval is empty.

#### C# Code Implementation

Here's how you can call the Interpolation Search function:

```csharp
int[] arr = { 2, 3, 5, 7, 9, 10, 11, 12, 14 };
int x = 10;
int index = InterpolationSearch.Search(arr, x);
```
code:
```csharp
using System;

namespace SearchingAlgorithms
{
    public static class InterpolationSearch
    {
        public static int Search(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;

            while (low <= high && x >= arr[low] && x <= arr[high])
            {
                if (low == high)
                {
                    if (arr[low] == x) return low;
                    return -1;
                }

                int pos = low + ((x - arr[low]) * (high - low)) / (arr[high] - arr[low]);

                if (arr[pos] == x)
                    return pos;

                if (arr[pos] < x)
                    low = pos + 1;
                else
                    high = pos - 1;
            }
            return -1;
        }
    }
}
```
### [Exponential Search](#Exponential-Search)

#### How It Works

1. **Find Range**: Start with a subarray size of 1, and double its size until the last element of the subarray is greater than the target value.
2. **Binary Search**: Perform a binary search on the identified subarray to find the target value.

#### C# Code Implementation

Here's how you can call the Exponential Search function:

```csharp
int[] arr = { 2, 3, 4, 10, 40 };
int target = 10;
int result = ExponentialSearch.Search(arr, target);
```
code:
```csharp
using System;

namespace SearchingAlgorithms
{
    public static class ExponentialSearch
    {
        public static int Search(int[] arr, int target)
        {
            int n = arr.Length;

            // Base case: check if target is at index 0
            if (arr[0] == target)
                return 0;

            // Find the range for binary search
            int i = 1;
            while (i < n && arr[i] <= target)
                i *= 2;

            // Call binary search for the found range
            return BinarySearch(arr, i / 2, Math.Min(i, n - 1), target);
        }

        private static int BinarySearch(int[] arr, int left, int right, int target)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
```
### [Fibonacci Search](#Fibonacci-Search)

#### How It Works

1. **Initialize**: Start with two Fibonacci numbers `fib1 = 0` and `fib2 = 1`.
2. **Calculate Next Fibonacci**: Calculate the next Fibonacci number `fib = fib1 + fib2`.
3. **Check Bounds**: If `fib` is less than the size of the array, go back to step 2.
4. **Partition**: Use `fib` to partition the array into two sub-arrays.
5. **Search**: Compare the element at the partition index with the target element.
   - If equal, return the index.
   - If greater, continue the search in the left sub-array.
   - If smaller, continue the search in the right sub-array.
6. **Update Fibonacci Numbers**: Update `fib`, `fib1`, and `fib2` to set up the next iteration.

#### C# Code Implementation

Here's how you can call the Fibonacci Search function:

```csharp
int[] arr = { 2, 3, 5, 7, 9, 10, 14, 15, 17, 19, 22, 24, 27, 30, 32 };
int x = 17;
int index = FibonacciSearch.Search(arr, x);
```
code:
```csharp
using System;

namespace SearchingAlgorithms
{
    public static class FibonacciSearch
    {
        public static int Search(int[] arr, int x)
        {
            int fib1 = 0;
            int fib2 = 1;
            int fib = fib1 + fib2;

            while (fib < arr.Length)
            {
                fib1 = fib2;
                fib2 = fib;
                fib = fib1 + fib2;
            }

            int offset = -1;

            while (fib > 1)
            {
                int i = Math.Min(offset + fib1, arr.Length - 1);

                if (arr[i] < x)
                {
                    fib = fib2;
                    fib2 = fib1;
                    fib1 = fib - fib2;
                    offset = i;
                }
                else if (arr[i] > x)
                {
                    fib = fib1;
                    fib2 = fib2 - fib1;
                    fib1 = fib - fib2;
                }
                else
                {
                    return i;
                }
            }

            if (fib1 == 1 && arr[offset + 1] == x)
            {
                return offset + 1;
            }

            return -1;
        }
    }
}
```
## [Linear](#Linear)
### [Linear Search](#Linear-Search)

#### How It Works

1. **Start at the Beginning**: Begin at the first element of the array.
2. **Iterate**: Move through the array element by element.
3. **Compare**: At each step, compare the current element with the target value.
4. **Found or Not**: If a match is found, return the index of the element. If the end of the array is reached without finding the target, return -1.

#### C# Code Implementation

Here's how you can call the Linear Search function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
int target = 11;
int result = LinearSearch.Search(arr, target);
```
code:
```csharp
using System;

namespace SearchingAlgorithms
{
    public static class LinearSearch
    {
        public static int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
```
### [Sentinel Search](#Sentinel-Search)

#### How It Works

1. **Append Sentinel**: Add the target element to the end of the array. This element acts as a sentinel.
2. **Linear Search**: Start from the beginning and move through the array to find the target element.
3. **Check for Sentinel**: If you reach the sentinel, the element was not found in the array.

#### C# Code Implementation

Here's how you can call the Sentinel Search function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
int target = 11;
int index = SentinelSearch.Search(arr, target);
```
code:
```csharp
using System;

namespace SearchingAlgorithms
{
    public static class SentinelSearch
    {
        public static int Search(int[] arr, int target)
        {
            // Append the target as a sentinel at the end of the array
            int last = arr[arr.Length - 1];
            arr[arr.Length - 1] = target;

            int i = 0;
            while (arr[i] != target)
            {
                i++;
            }

            // Restore the last element
            arr[arr.Length - 1] = last;

            // Element found, return its index
            if (i < arr.Length - 1 || arr[arr.Length - 1] == target)
            {
                return i;
            }

            // Element not found
            return -1;
        }
    }
}
```
### [Sublist Search](#Sublist-Search)

#### How It Works

1. **Initialize Pointers**: Initialize two pointers, one for the main list and one for the sublist.
2. **Traverse Main List**: Traverse the main list. For each element, compare it with the first element of the sublist.
3. **Compare Sublist**: If the first element matches, move both pointers across their respective lists, comparing each element.
4. **Found or Not**: If you reach the end of the sublist, then the sublist is found in the main list. If you reach the end of the main list but not the sublist, the sublist is not in the main list.

#### C# Code Implementation

Here's how you can call the Sublist Search function:

```csharp
LinkedList<int> mainList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
LinkedList<int> subList = new LinkedList<int>(new int[] { 3, 4 });
bool isSublist = SublistSearch.IsSublist(mainList, subList);
```
code:
```csharp
using System;
using System.Collections.Generic;

namespace SearchingAlgorithms
{
    public static class SublistSearch
    {
        public static bool IsSublist(LinkedList<int> mainList, LinkedList<int> subList)
        {
            LinkedListNode<int> mainCurrent = mainList.First;
            LinkedListNode<int> subCurrent = subList.First;

            while (mainCurrent != null)
            {
                LinkedListNode<int> tempMain = mainCurrent;

                while (subCurrent != null)
                {
                    if (tempMain == null || tempMain.Value != subCurrent.Value)
                    {
                        break;
                    }

                    tempMain = tempMain.Next;
                    subCurrent = subCurrent.Next;
                }

                if (subCurrent == null)
                {
                    return true;
                }

                subCurrent = subList.First;
                mainCurrent = mainCurrent.Next;
            }

            return false;
        }
    }
}
```