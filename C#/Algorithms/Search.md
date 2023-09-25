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
## [Hash-based](#Hash-based)
### [Direct Addressing](#Direct-Addressing)

#### How It Works

1. **Initialization**: Create an array, called the "direct address table," with a size equal to the range of input values.
2. **Mapping**: Map each element in the input array to an index in the direct address table.
3. **Storing**: Store each element at its mapped index in the direct address table.
4. **Reconstruction**: Reconstruct the sorted array from the elements stored in the direct address table.

#### C# Code Implementation

Here's how you can call the Direct Addressing function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
DirectAddressing.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class DirectAddressing
    {
        public static void Sort(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            // Find the maximum and minimum values in the array
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            // Initialize the direct address table
            int[] table = new int[max - min + 1];

            // Map the elements to the table
            for (int i = 0; i < arr.Length; i++)
            {
                table[arr[i] - min]++;
            }

            // Reconstruct the sorted array
            int j = 0;
            for (int i = min; i <= max; i++)
            {
                while (table[i - min] > 0)
                {
                    arr[j++] = i;
                    table[i - min]--;
                }
            }
        }
    }
}
```
### [Open Hashing (Separate Chaining)](#Open-Hashing)

#### How It Works

1. **Initialization**: Create an array of linked lists, each representing a bucket.
2. **Hash Function**: Use a hash function to determine the index of the bucket where each key-value pair should be stored.
3. **Insertion**: Insert the key-value pair into the linked list at the determined index.
4. **Lookup**: To find a value, use the hash function to find the bucket and then search through the linked list.
5. **Deletion**: To delete a key-value pair, use the hash function to find the bucket and then remove the node from the linked list.

#### C# Code Implementation

Here's how you can use the Open Hashing implementation:

```csharp
OpenHashing<string, int> hashTable = new OpenHashing<string, int>(10);
hashTable.Insert("key1", 1);
hashTable.Insert("key2", 2);
int value = hashTable.Lookup("key1");
hashTable.Delete("key1");
```
code:
```csharp
using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class OpenHashing<TKey, TValue>
    {
        private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;

        public OpenHashing(int size)
        {
            buckets = new LinkedList<KeyValuePair<TKey, TValue>>[size];
        }

        public void Insert(TKey key, TValue value)
        {
            int index = GetHash(key);
            if (buckets[index] == null)
            {
                buckets[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }
            buckets[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
        }

        public TValue Lookup(TKey key)
        {
            int index = GetHash(key);
            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key.Equals(key))
                    {
                        return pair.Value;
                    }
                }
            }
            throw new KeyNotFoundException();
        }

        public void Delete(TKey key)
        {
            int index = GetHash(key);
            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key.Equals(key))
                    {
                        buckets[index].Remove(pair);
                        return;
                    }
                }
            }
            throw new KeyNotFoundException();
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % buckets.Length;
        }
    }
}
```
### [Closed Hashing](#Closed-Hashing)

#### How It Works

1. **Initialize Table**: Create a hash table with a predefined size.
2. **Hash Function**: Use a hash function to map each key to an index in the hash table.
3. **Collision Resolution**: If a collision occurs (i.e., two keys hash to the same index), resolve it using a predefined method like linear probing, quadratic probing, or double hashing.
4. **Insert, Delete, Search**: Use the hash function and collision resolution method to perform operations like insert, delete, and search.

#### C# Code Implementation

Here's how you can call the Closed Hashing functions:

```csharp
ClosedHashing hashTable = new ClosedHashing(10);
hashTable.Insert(5);
hashTable.Insert(15);
hashTable.Delete(5);
bool exists = hashTable.Search(15);
```
code:
```csharp
using System;

namespace DataStructures
{
    public class ClosedHashing
    {
        private int[] hashTable;
        private int capacity;

        public ClosedHashing(int capacity)
        {
            this.capacity = capacity;
            hashTable = new int[capacity];
            Array.Fill(hashTable, -1);
        }

        private int HashFunction(int key)
        {
            return key % capacity;
        }

        public void Insert(int key)
        {
            int index = HashFunction(key);
            while (hashTable[index] != -1)
            {
                index = (index + 1) % capacity;
            }
            hashTable[index] = key;
        }

        public void Delete(int key)
        {
            int index = HashFunction(key);
            while (hashTable[index] != key)
            {
                index = (index + 1) % capacity;
            }
            hashTable[index] = -1;
        }

        public bool Search(int key)
        {
            int index = HashFunction(key);
            while (hashTable[index] != -1)
            {
                if (hashTable[index] == key)
                {
                    return true;
                }
                index = (index + 1) % capacity;
            }
            return false;
        }
    }
}
```
## [Tree-based](#Tree-based)
### [Binary Search Tree](#Binary-Search-Tree)

#### How It Works

1. **Initialization**: Create a root node to serve as the starting point for the tree.
2. **Insertion**: To insert a new node, compare its value with the root. If it's less, traverse the left subtree; otherwise, traverse the right subtree. Repeat until you find an empty spot to insert the new node.
3. **Search**: To search for a node, compare its value with the root. If it's less, traverse the left subtree; otherwise, traverse the right subtree. Repeat until you find the node or reach an empty spot.
4. **Deletion**: To delete a node, find it first. If it has zero or one child, remove it directly. If it has two children, find the in-order successor, replace the node with it, and remove the successor.

#### C# Code Implementation

Here's how you can call the Binary Search Tree functions:

```csharp
BinarySearchTree bst = new BinarySearchTree();
bst.Insert(5);
bst.Insert(3);
bst.Insert(8);
bool exists = bst.Search(3);
bst.Delete(3);
```
code:
```csharp
using System;

namespace DataStructures
{
    public class Node
    {
        public int Value;
        public Node Left, Right;

        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node Root;

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Value)
                root.Left = InsertRec(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRec(root.Right, value);

            return root;
        }

        public bool Search(int value)
        {
            return SearchRec(Root, value) != null;
        }

        private Node SearchRec(Node root, int value)
        {
            if (root == null || root.Value == value)
                return root;

            if (root.Value > value)
                return SearchRec(root.Left, value);

            return SearchRec(root.Right, value);
        }

        public void Delete(int value)
        {
            Root = DeleteRec(Root, value);
        }

        private Node DeleteRec(Node root, int value)
        {
            if (root == null) return root;

            if (value < root.Value)
                root.Left = DeleteRec(root.Left, value);
            else if (value > root.Value)
                root.Right = DeleteRec(root.Right, value);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Value = MinValue(root.Right);

                root.Right = DeleteRec(root.Right, root.Value);
            }

            return root;
        }

        private int MinValue(Node root)
        {
            int minValue = root.Value;
            while (root.Left != null)
            {
                minValue = root.Left.Value;
                root = root.Left;
            }
            return minValue;
        }
    }
}
```
### [Balanced Trees: AVL (Adelson-Velsky and Landis) Tree](#AVL-Tree)

#### How It Works

1. **Insertion**: Similar to a regular binary search tree, but after insertion, the tree is balanced.
2. **Deletion**: Also similar to a regular binary search tree, but after deletion, the tree is balanced.
3. **Balancing**: After each insert or delete operation, the balance factor of each node is checked and the tree is balanced accordingly.

#### C# Code Implementation

Here's how you can use the AVL Tree class:

```csharp
AVLTree tree = new AVLTree();
tree.Insert(30);
tree.Insert(20);
tree.Insert(40);
tree.Delete(20);
```
code:
```csharp
using System;

namespace BalancedTrees
{
    public class Node
    {
        public int Key, Height;
        public Node Left, Right;

        public Node(int item)
        {
            Key = item;
            Height = 1;
        }
    }

    public class AVLTree
    {
        private Node root;

        private int Height(Node N) => N == null ? 0 : N.Height;

        private int Max(int a, int b) => (a > b) ? a : b;

        private Node RightRotate(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Max(Height(x.Left), Height(x.Right)) + 1;

            return x;
        }

        private Node LeftRotate(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Max(Height(y.Left), Height(y.Right)) + 1;

            return y;
        }

        private int GetBalance(Node N) => (N == null) ? 0 : Height(N.Left) - Height(N.Right);

        public Node Insert(Node node, int key)
        {
            if (node == null) return new Node(key);

            if (key < node.Key) node.Left = Insert(node.Left, key);
            else if (key > node.Key) node.Right = Insert(node.Right, key);
            else return node;

            node.Height = 1 + Max(Height(node.Left), Height(node.Right));

            int balance = GetBalance(node);

            // Left Heavy
            if (balance > 1 && key < node.Left.Key) return RightRotate(node);

            // Right Heavy
            if (balance < -1 && key > node.Right.Key) return LeftRotate(node);

            // Left Right Heavy
            if (balance > 1 && key > node.Left.Key)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Heavy
            if (balance < -1 && key < node.Right.Key)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        public void Insert(int key) => root = Insert(root, key);

        // Deletion and other methods can be added here
    }
}
```
### [Balanced Trees: Red-Black Trees](#Red-Black-Trees)
#### How It Works

1. **Node Coloring**: Each node is either red or black.
2. **Root Node**: The root is always black.
3. **Red Node Children**: The children of a red node are always black.
4. **Black Height**: Every path from a node to a descendant leaf has the same black height (the number of black nodes).
5. **New Insertions**: Newly inserted nodes are always red.
6. **Balancing**: After insertion or deletion, the tree is balanced using rotations and color changes.

#### C# Code Implementation

Here's how you can use the Red-Black Tree in C#:

```csharp
RedBlackTree<int> tree = new RedBlackTree<int>();
tree.Insert(5);
tree.Insert(3);
tree.Delete(5);
```
code:
```csharp
using System;

namespace DataStructures
{
    public enum Color { Red, Black }

    public class Node<T> where T : IComparable
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;
        public Node<T> Parent;
        public Color Color;

        public Node(T value)
        {
            Value = value;
            Color = Color.Red;
        }

        public override bool Equals(object obj)
        {
            if (obj is Node<T> otherNode)
            {
                return Value.Equals(otherNode.Value);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }

    public class RedBlackTree<T> where T : IComparable
    {
        private Node<T> root;

        public void Insert(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (root == null)
            {
                root = newNode;
                root.Color = Color.Black;
            }
            else
            {
                Node<T> temp = root;
                while (temp != null)
                {
                    if (value.CompareTo(temp.Value) < 0)
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                    else
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                }
                FixTree(newNode);
            }
        }
        private void FixTree(Node<T> current)
        {

            public void Delete(T value)
            {
                Node<T> nodeToDelete = FindNode(root, value);
                if (nodeToDelete == null) return; // Return if the node to delete is not found

                Node<T> x, y;

                // Determine the node to be deleted (either the node itself or its successor)
                if (nodeToDelete.Left == null || nodeToDelete.Right == null)
                {
                    y = nodeToDelete;
                }
                else
                {
                    y = GetSuccessor(nodeToDelete);
                }

                // Set x to either the left or right child of y, whichever is non-null
                if (y.Left != null)
                {
                    x = y.Left;
                }
                else
                {
                    x = y.Right;
                }

                // Update the parent of x
                if (x != null)
                {
                    x.Parent = y.Parent;
                }

                // Update the parent to point to x instead of y
                if (y.Parent == null)
                {
                    root = x;
                }
                else
                {
                    if (y == y.Parent.Left)
                    {
                        y.Parent.Left = x;
                    }
                    else
                    {
                        y.Parent.Right = x;
                    }
                }

                // Copy the value from y (the node to be deleted or its successor)
                if (y != nodeToDelete)
                {
                    nodeToDelete.Value = y.Value;
                }

                // Fix the tree if the color of y was black
                if (y.Color == Color.Black)
                {
                    FixDelete(x);
                }

                // Transplant y with x
                Transplant(y, x);
            }


            private void FixDelete(Node<T> x)
            {
                if (x == null)
                    return;

                // While x is not the root and x.color == black
                while (x != root && x.Color == Color.Black)
                {
                    if (x == x.Parent.Left)
                    {
                        Node<T> w = x.Parent.Right;

                        // Case 1: w is red
                        if (w.Color == Color.Red)
                        {
                            w.Color = Color.Black;
                            x.Parent.Color = Color.Red;
                            LeftRotate(x.Parent);
                            w = x.Parent.Right;
                        }

                        // Case 2: Both of w's children are black
                        if (w.Left.Color == Color.Black && w.Right.Color == Color.Black)
                        {
                            w.Color = Color.Red;
                            x = x.Parent;
                        }
                        else
                        {
                            // Case 3: w's right child is black
                            if (w.Right.Color == Color.Black)
                            {
                                w.Left.Color = Color.Black;
                                w.Color = Color.Red;
                                RightRotate(w);
                                w = x.Parent.Right;
                            }

                            // Case 4: w's right child is red
                            w.Color = x.Parent.Color;
                            x.Parent.Color = Color.Black;
                            w.Right.Color = Color.Black;
                            LeftRotate(x.Parent);
                            x = root;
                        }
                    }
                    else
                    {
                        // Same logic as above, with "Left" and "Right" swapped
                        Node<T> w = x.Parent.Left;

                        if (w.Color == Color.Red)
                        {
                            w.Color = Color.Black;
                            x.Parent.Color = Color.Red;
                            RightRotate(x.Parent);
                            w = x.Parent.Left;
                        }

                        if (w.Right.Color == Color.Black && w.Right.Color == Color.Black)
                        {
                            w.Color = Color.Red;
                            x = x.Parent;
                        }
                        else
                        {
                            if (w.Left.Color == Color.Black)
                            {
                                w.Right.Color = Color.Black;
                                w.Color = Color.Red;
                                LeftRotate(w);
                                w = x.Parent.Left;
                            }

                            w.Color = x.Parent.Color;
                            x.Parent.Color = Color.Black;
                            w.Left.Color = Color.Black;
                            RightRotate(x.Parent);
                            x = root;
                        }
                    }
                }

                x.Color = Color.Black;
            }

            private Node<T> FindNode(Node<T> current, T value)
            {
                if (current == null) return null;

                int comparison = value.CompareTo(current.Value);
                if (comparison < 0)
                {
                    return FindNode(current.Left, value);
                }
                else if (comparison > 0)
                {
                    return FindNode(current.Right, value);
                }
                else
                {
                    return current;
                }
                return null;
            }

            private Node<T> GetSuccessor(Node<T> x)
            {
                if (x.Right != null)
                {
                    Node<T> temp = x.Right;
                    while (temp.Left != null)
                    {
                        temp = temp.Left;
                    }
                    return temp;
                }

                Node<T> successor = x.Parent;
                while (successor != null && x == successor.Right)
                {
                    x = successor;
                    successor = successor.Parent;
                }
                return successor;
            }


            private void RotateLeft(Node<T> current)
            {
                Node<T> temp = current.Right;
                current.Right = temp.Left;

                if (temp.Left != null)
                {
                    temp.Left.Parent = current;
                }

                temp.Parent = current.Parent;

                if (current.Parent == null)
                {
                    root = temp;
                }
                else if (current == current.Parent.Left)
                {
                    current.Parent.Left = temp;
                }
                else
                {
                    current.Parent.Right = temp;
                }

                temp.Left = current;
                current.Parent = temp;
            }

            private void RotateRight(Node<T> current)
            {
                Node<T> temp = current.Left;
                current.Left = temp.Right;

                if (temp.Right != null)
                {
                    temp.Right.Parent = current;
                }

                temp.Parent = current.Parent;

                if (current.Parent == null)
                {
                    root = temp;
                }
                else if (current == current.Parent.Right)
                {
                    current.Parent.Right = temp;
                }
                else
                {
                    current.Parent.Left = temp;
                }

                temp.Right = current;
                current.Parent = temp;
            }

            private void Transplant(Node<T> u, Node<T> v)
            {
                if (u.Parent == null)
                {
                    root = v;
                }
                else if (u == u.Parent.Left)
                {
                    u.Parent.Left = v;
                }
                else
                {
                    u.Parent.Right = v;
                }

                if (v != null)
                {
                    v.Parent = u.Parent;
                }
            }

            public void InOrderTraversal(Action<T> action)
            {
                InOrderTraversal(root, action);
            }

            private void InOrderTraversal(Node<T> node, Action<T> action)
            {
                if (node != null)
                {
                    InOrderTraversal(node.Left, action);
                    action(node.Value);
                    InOrderTraversal(node.Right, action);
                }
            }

            public void PreOrderTraversal(Action<T> action)
            {
                PreOrderTraversal(root, action);
            }

            private void PreOrderTraversal(Node<T> node, Action<T> action)
            {
                if (node != null)
                {
                    action(node.Value);
                    PreOrderTraversal(node.Left, action);
                    PreOrderTraversal(node.Right, action);
                }
            }

            public void PostOrderTraversal(Action<T> action)
            {
                PostOrderTraversal(root, action);
            }


            private void PostOrderTraversal(Node<T> node, Action<T> action)
            {
                if (node != null)
                {
                    PostOrderTraversal(node.Left, action);
                    PostOrderTraversal(node.Right, action);
                    action(node.Value);
                }
            }

            public bool Contains(T value)
            {
                return FindNode(root, value) != null;
            }

            public T MinValue()
            {
                Node<T> temp = root;
                while (temp.Left != null)
                {
                    temp = temp.Left;
                }
                return temp.Value;
            }

            public T MaxValue()
            {
                Node<T> temp = root;
                while (temp.Right != null)
                {
                    temp = temp.Right;
                }
                return temp.Value;
            }
        }
    }    
}
```
