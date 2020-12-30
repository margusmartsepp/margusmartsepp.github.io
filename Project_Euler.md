Back to [Main](README.md).

# Problem 1
## .NET 5 C# ✓
- [x] Loops ~3d
    ```csharp
    int Problem1_ForLoop(int size) {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
    Problem1_ForLoop(1000)
    ```
- [x] Lambda sum aggregation
    ```csharp
    int Problem1_LinqSum(int size) => Enumerable.Range(1, size)
        .Where(o => o % 3 == 0 || o % 5 == 0).Sum();
    Problem1_LinqSum(1000)
    ```
- [x] Lambda aggregation sum
    ```csharp
    int Problem1_LinqAccumulator(int size) => Enumerable.Range(1, size)
        .Aggregate(0, (total, nr) => nr % 3 == 0 || nr % 5 == 0 ? total + nr : total);
    Problem1_LinqAccumulator(1000)
    ```
- [x] Arithmetic Progression
    ```csharp
    int ArithmeticProgression(int nr) => nr * (nr + 1) / 2;
    int Problem1_ArithmeticProgression(int size) =>  
        3 * ArithmeticProgression(size/3)
        + 5 * ArithmeticProgression(size/5)
        - 15 * ArithmeticProgression(size/15);
    Problem1_ArithmeticProgression(1000)
    ```
# HackerRank
```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    int Problem1_LinqAccumulator(int size) => Enumerable.Range(1, size)
        .Aggregate(0, (total, nr) => nr % 3 == 0 || nr % 5 == 0 ? total + nr : total);

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Problem1_ArithmeticProgression(n));
        }
    }
}
```