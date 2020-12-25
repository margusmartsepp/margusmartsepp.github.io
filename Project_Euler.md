# Problem 1
## .NET 5 C# 
- [x] Loops
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
- [x] Loops