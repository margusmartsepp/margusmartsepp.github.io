# Read me
There area a lot of ways to solve a task. Different languages will enable different styles. Some approaches are more efficient than others and usually a **brute force** way is not considered as correct.

# Problem 1
- Arithmetic progression sums
## .NET 5 C# 
- [x] ### Loops | 0.25 ±0.05 s
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
- [x] Lambda sum aggregation | 0.25 ±0.05 s
    ```csharp 
    int Problem1_LinqSum(int size) => Enumerable.Range(1, size)
        .Where(o => o % 3 == 0 || o % 5 == 0).Sum();
    Problem1_LinqSum(1000)
    ```
- [x] Lambda aggregation sum | 0.25 ±0.05 s
    ```csharp
    int Problem1_LinqAccumulator(int size) => Enumerable.Range(1, size)
        .Aggregate(0, (total, nr) => nr % 3 == 0 || nr % 5 == 0 ? total + nr : total);
    Problem1_LinqAccumulator(1000)
    ```
- [x] Arithmetic Progression | 0.25 ±0.05 s
    ```csharp
    int ArithmeticProgression(int nr) => nr * (nr + 1) / 2;
    int Problem1_ArithmeticProgression(int size) =>  
        3 * ArithmeticProgression(size/3)
        + 5 * ArithmeticProgression(size/5);
        - 15 * ArithmeticProgression(size/15);;
    Problem1_ArithmeticProgression(1000)
    ```


