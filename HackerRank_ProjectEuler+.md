Back to [Main](README.md).

# Problem 1
## .NET 5 C# ✓
- [x] Arithmetic Progression
    ```csharp
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;

	class Solution {
		static long ArithmeticProgression(long nr) => nr * (nr + 1) / 2;
		static long Problem1_ArithmeticProgression(long size) =>  
			3 * ArithmeticProgression(size/3)
			+ 5 * ArithmeticProgression(size/5)
			- 15 * ArithmeticProgression(size/15);

		static void Main(String[] args) {
			int t = Convert.ToInt32(Console.ReadLine());
			for(int a0 = 0; a0 < t; a0++){
				int n = Convert.ToInt32(Console.ReadLine());        
				Console.WriteLine(Problem1_ArithmeticProgression(n-1));            
			}
		}
	}
    ```