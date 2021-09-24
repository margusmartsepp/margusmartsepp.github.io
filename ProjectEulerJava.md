### Problem 1: Add all the natural numbers below one thousand that are multiples of 3 or 5.
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_1 {
	// Arithmetic progression
	static int AP(int nr) {
		return nr * (nr + 1) / 2;
	}

	static int nAP(int nr, int multible) {
		return multible * nr * (nr + 1) / 2;
	}

	public static void main(String[] args) {
		int size = 999;
		int result = nAP(size / 3, 3) + nAP(size / 5, 5) - nAP(size / 15, 15);

		System.out.println(result);
	}
}
```
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_1 {
	public static void main(String[] args) {
		int size = 1000, sum = 0;

		for (int i = 0; i < size; i++)
			if (i % 3 == 0 || i % 5 == 0)
				sum += i;

		System.out.println(sum);
	}
}
```
### Problem 2: Find the sum of all the even-valued terms in the Fibonacci sequence which do not exceed four million.
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_2 {
	static final double gold_r = Math.pow((1 + Math.sqrt(5)) / 2, 3);

	public static void main(String[] args) {
		long size = 4000000, sum = 0;
		double f = 2;

		for (; f < size; f = Math.round(f * gold_r))
			sum += f;

		System.out.println(sum);
	}
}
```
Time: ~0.226 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_2 {
	public static long fib(int n) {
		if (n <= 1)
			return n;
		else
			return fib(n - 1) + fib(n - 2);
	}

	public static void main(String[] args) {
		long size = 4000000, sum = 0, tmp = 0;

		for (int i = 0; i < size; i++) {
			tmp = fib(i);
			if (tmp > size)
				break;
			if (tmp % 2 == 0)
				sum += tmp;
		}

		System.out.println(sum);
	}
}
```
### Problem 3: Find the largest prime factor of a composite number.
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_3 {
	static long lpf(long nr) {
		long max = 0;

		for (long i = 2; i <= nr / i; i++)
			while (nr % i == 0) {
				max = i;
				nr = nr / i;
			}

		return nr > 1 ? nr : max;
	}

	public static void main(String[] args) {
		System.out.println(lpf(600851475143L));
	}
}
```
### Problem 4: Find the largest palindrome made from the product of two 3-digit numbers.
Time: ~0.018 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_4 {
	static boolean isPalindrome(String p) {
		return p.equals(new StringBuilder(p).reverse().toString());
	}

	public static void main(String[] args) {
		int limit = 999, max = 0;

		for (int i = limit; i > 101; i -= 2)
			for (int j = i; j > 101 && i * j > max; j -= 2)
				if (isPalindrome("" + (i * j)))
					max = i * j;

		System.out.println(max);
	}
}
```
Time: ~0.044 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_4 {
	static boolean isPalindrome(String p) {
		return p.equals(new StringBuilder(p).reverse().toString());
	}

	public static void main(String[] args) {
		int limit = 999, max = 0;

		for (int i = limit; i > 0; i--)
			for (int j = limit, num = i * j; j > 0; j--, num = i * j)
				if (!(max > num) && isPalindrome("" + num))
					max = num;

		System.out.println(max);
	}
}
```
### Problem 5: What is the smallest number divisible by each of the numbers 1 to 20?
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_5 {
	static long gcd(long a, long b) {
		if (b == 0)
			return Math.abs(a);
		return gcd(b, a % b);
	}

	static long lcm(long a, long b) {
		return (a * b) / gcd(a, b);
	}

	public static void main(String[] args) {
		long result = 1;

		for (long i = 2; i < 21; i++)
			result = lcm(result, i);

		System.out.println(result);
	}
}
```
Time: ~12.525 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_5 {

	public static void main(String[] args) {
		int max = Integer.MAX_VALUE, limit = 20, i;
		boolean all_mod0;

		for (i = 1; i < max; i++) {
			all_mod0 = true;
			for (int j = 2; j < limit + 1; j++)
				if (i % j != 0) {
					all_mod0 = false;
					break;
				}
			if (all_mod0)
				break;
		}

		System.out.println(i);
	}
}
```
### Problem 6: What is the difference between the sum of the squares and the square of the sums?
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_6 {
	public static void main(String[] args) {
		int size = 100;
		long qos = (int) Math.pow(size * (size + 1) / 2, 2);
		long soq = size * (size + 1) * (2 * size + 1) / 6;

		System.out.println(qos - soq);
	}
}
```
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_6 {
	public static void main(String[] args) {
		int size = 100;
		long sums_of_square = 0, square_of_sums = 0;

		square_of_sums = (1 + size) * size / 2;
		square_of_sums = square_of_sums * square_of_sums;
		for (int i = 1; i < size + 1; i++)
			sums_of_square += i * i;

		System.out.println(square_of_sums - sums_of_square);
	}
}
```
### Problem 7: Find the 10001st prime.
Time: ~0.011 s
```java
package margusmartseppcode.From_1_to_9;

import java.util.BitSet;

public class Problem_7 {

	/**
	 * Sieve of Eratosthenes x'th prime <br>
	 * NB: Will return -1 if :<br>
	 * <ul>
	 * <li>x'th prime does not fit in max.</li>
	 * <li>max < 1 || nr < 1 || max < nr</li>
	 * </ul>
	 */
	static long getSoExnt(int max, int nr) {
		if (max < 1 || nr < 1 || max < nr)
			return -1;
		if (nr < 4)
			return (nr == 1 ? 2 : (nr == 2 ? 3 : 5));
		BitSet sieve = new BitSet(max / 2);

		for (int i = 5, f = 1, c = 2; i <= max; i += 3 - f, f = -f)
			if (sieve.get(i >> 1) == false) {
				int add = i << 1;
				for (int j = i + add; j < max; j += add)
					sieve.set(j >> 1, true);
				if (++c >= nr)
					return i;
			}

		return -1;
	}

	public static void main(String[] args) {
		System.out.println(getSoExnt(120000, 10001));
	}
}	
```
Time: ~0.080 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_7 {
	static boolean isPrime(long n) {
		if (n % 2 == 0 || n < 2)
			return (n == 2) ? true : false;
		if (n < 9)
			return true;
		if (n % 3 == 0 || n % 5 == 0)
			return false;

		final long r = (long) Math.floor(Math.sqrt(n));
		for (long f = 5L; f <= r; f += 6)
			if (n % f == 0 || n % (f + 2) == 0)
				return false;

		return true;
	}

	public static void main(String[] args) {
		long n = 10001, p = 5;
		for (long f = 1; n > 3; n -= isPrime(p) ? 1 : 0, f = -f)
			p += 3 - f;

		System.out.println(p);
	}
}
```
Time: ~0.236 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_7 {

	public static void main(String[] args) {
		int size = Integer.MAX_VALUE, prime_nr = 10001;
		long i, j, prime_c = 0;
		boolean isPrime = true;

		for (i = 2; i < size; i++, isPrime = true) {
			for (j = 2; j * j <= i; j++)
				if (i % j == 0) {
					isPrime = false;
					break;
				}

			if (isPrime)
				if (++prime_c >= prime_nr)
					break;
		}
		System.out.println(i);
	}
}
```
### Problem 8: Discover the largest product of five consecutive digits in the 1000-digit number.
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_8 {
	public static void main(String[] args) {
		char[] nr = ("7316717653133062491922511967442657474235534919493"
				+ "496983520312774506326239578318016984801869478851843"
				+ "858615607891129494954595017379583319528532088055111"
				+ "254069874715852386305071569329096329522744304355766"
				+ "896648950445244523161731856403098711121722383113622"
				+ "298934233803081353362766142828064444866452387493035"
				+ "890729629049156044077239071381051585930796086670172"
				+ "427121883998797908792274921901699720888093776657273"
				+ "330010533678812202354218097512545405947522435258490"
				+ "771167055601360483958644670632441572215539753697817"
				+ "977846174064955149290862569321978468622482839722413"
				+ "756570560574902614079729686524145351004748216637048"
				+ "440319989000889524345065854122758866688116427171479"
				+ "924442928230863465674813919123162824586178664583591"
				+ "245665294765456828489128831426076900422421902267105"
				+ "562632111110937054421750694165896040807198403850962"
				+ "455444362981230987879927244284909188845801561660979"
				+ "191338754992005240636899125607176060588611646710940"
				+ "507754100225698315520005593572972571636269561882670"
				+ "428252483600823257530420752963450").toCharArray();
		int tmp = 0, max = 0;

		for (int i = 4; i < nr.length; i++, tmp = 1) {
			for (int j = -4; j <= 0; j++)
				tmp *= (nr[i + j] - '0');

			if (tmp > max)
				max = tmp;
		}
		System.out.println(max);
	}
}
```
### Problem 9: Find the only Pythagorean triplet, {a, b, c}, for which a + b+ c = 1000.
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_9 {
	static long getPythSum(long nr) {
		double a, b, c, sqn = Math.sqrt(nr);
		for (int i = 1; i < sqn; i += 2)
			for (int j = 2; j < sqn; j += 2) {
				a = Math.abs(j * j - i * i);
				b = 2 * i * j;
				c = i * i + j * j;
				if ((a + b + c) == nr)
					return (long) (a * b * c);
			}

		return -1;
	}

	public static void main(String[] args) {
		System.out.println(getPythSum(1000));
	}
}
```
Time: ~0.001 s
```java
package margusmartseppcode.From_1_to_9;

public class Problem_9 {
	public static int gcd(int a, int b) {
		if (b != 0)
			return gcd(b, a % b);
		return Math.abs(a);
	}

	public static void main(String[] args) {
		int s = 1000, s2 = s / 2, sm, d, n, a = 0, b = 0, c = 0, m, k = 0;
		int mlimit = (int) (Math.abs(Math.sqrt(s2)) - 1);
		boolean haveAnswer = false;

		for (m = 2; m < mlimit; m++) {
			if (s2 % m != 0)
				continue;

			sm = s2 / m;
			while (sm % 2 == 0)
				sm = sm / 2;

			k = m + 1 + (m % 2 == 1 ? 1 : 0);
			while (k < 2 * m && k <= sm && !haveAnswer) {
				if (sm % k == 0 && gcd(k, m) == 1)
					haveAnswer = true;
				if (haveAnswer)
					break;

				k += 2;
			}
			if (haveAnswer)
				break;
		}
		d = s2 / (k * m);
		n = k - m;
		a = d * (m * m - n * n);
		b = 2 * d * m * n;
		c = d * (m * m + n * n);
		System.out.println(a * b * c);
	}
}
```
### Problem 10: Calculate the sum of all the primes below two million.
Time: ~0.097 s
```java
package margusmartseppcode.From_10_to_19;

import java.util.BitSet;

public class Problem_10 {
	/** Sieve of Eratosthenes sum */
	static long getSoEsum(int max) {
		if (max < 1)
			return 0;
		BitSet sieve = new BitSet(max / 2);
		long sum = (max > 1 ? 2 + (max > 2 ? 3 : 0) : 0);

		for (int i = 5, f = 1; i <= max; i += 3 - f, f = -f)
			if (sieve.get(i >> 1) == false) {
				int add = i << 1;
				for (int j = i + add; j < max; j += add)
					sieve.set(j >> 1, true);
				sum += i;
			}

		return sum;
	}

	public static void main(String[] args) {
		System.out.println(getSoEsum(2000000));
	}
}
```
Time: ~1.555 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_10 {
	// Call only if: (n>0&&(i%2==0||i%3==0||i%5==0||i%7==0))
	static boolean isPrimeS(final int n) {
		final int r = (int) Math.floor(Math.sqrt(n));
		for (int f = 5; f <= r; f += 6)
			if (n % f == 0 || n % (f + 2) == 0)
				return false;
		return true;
	}

	public static void main(String[] args) {
		int size = 2000000;
		long sum = 17;

		for (int i = 5, f = 1; i <= size; i += 3 - f, f = -f) {
			if (i % 5 == 0 || i % 7 == 0)
				continue;
			// 9524 tests if size = 2000000
			if (isPrimeS(i))
				sum += i;
		}

		System.out.println(sum);
	}
}
```
Time: ~14.056 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_10 {
	public static void main(String[] args) {
		int size = 2000000;
		long i, j, sum = 0;
		boolean isPrime = true;

		for (i = 2; i < size; i++, isPrime = true) {
			for (j = 2; j * j <= i; j++)
				if (i % j == 0) {
					isPrime = false;
					break;
				}

			if (isPrime)
				sum += i;
		}
		System.out.println(sum);
	}
}
```
### Problem 11: What is the greatest product of four numbers on the same straight line in the 20 by 20 grid?
Time: ~0.002 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_11 {
  public static void main(String[] args) {
    int max = 0, rows = 20, fr = 16, clmns = 17, phv, pd = 0;

    for (int i = 0; i < rows; i++)
      for (int j = 0; j < clmns; j++) {
        phv = Math.max(n[i][j] * n[i][j + 1] * n[i][j + 2] * n[i][j + 3],
            n[j][i] * n[j + 1][i] * n[j + 2][i] * n[j + 3][i]);
        if (i < fr)
          pd = Math.max(n[i][j] * n[i + 1][j + 1] * n[i + 2][j + 2] * n[i + 3][j + 3],
              n[i][j + 3] * n[i + 1][j + 2] * n[i + 2][j + 1] * n[i + 3][j]);
        max = Math.max(max, Math.max(phv, pd));
      }

    System.out.println(max);
  }

  static int n[][] = {
      { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75, 04, 05, 7, 78, 52, 12, 50, 77, 91, 8 },
      { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 },
      { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 },
      { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 },
      { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 },
      { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 },
      { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 },
      { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 8, 40, 91, 66, 49, 94, 21 },
      { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 },
      { 21, 36, 23, 9, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 },
      { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 9, 53, 56, 92 },
      { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 },
      { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 },
      { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 },
      { 04, 52, 8, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 },
      { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 },
      { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8, 46, 29, 32, 40, 62, 76, 36 },
      { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 },
      { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 },
      { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01,89, 19, 67, 48 } };
}
```
Time: ~0.002 s
```java
package margusmartseppcode.From_10_to_19;
public class Problem_11 {
	// left-right top-bottom
	// top-bottom left-right
	// left-top right-bottom
	// left-bottom right-top
	public static void main(String[] args) {
		int msize = nrs.length, tmp = 0, max = 0;
		int stare = 4, stare_size = stare - 1;

		for (int i = stare_size; i < msize; i++)
			for (int j = 0; j < msize; j++,tmp = 1) {
				for (int k = 0; k < stare; k++)
					tmp *= nrs[i - k][j];

				if (tmp > max)
					max = tmp;
			}

		for (int i = 0; i < msize; i++)
			for (int j = stare_size; j < msize; j++,tmp = 1) {
				for (int k = 0; k < stare; k++)
					tmp *= nrs[i][j - k];

				if (tmp > max)
					max = tmp;
			}

		for (int i = stare_size; i < msize; i++)
			for (int j = stare_size; j < msize; j++,tmp = 1) {
				for (int k = 0; k < stare; k++)
					tmp *= nrs[i - k][j - k];

				if (tmp > max)
					max = tmp;
			}

		for (int i = 0; i < msize-stare_size; i++)
			for (int j = stare_size; j < msize; j++,tmp = 1) {
				for (int k = 0; k < stare; k++)
					tmp *= nrs[i + k][j - k];

				if (tmp > max)
					max = tmp;
			}

		System.out.println(max);
	}

	static int nrs[][] = {
			{ 8, 2, 22, 97, 38, 15, 0, 40, 0, 75, 04, 05, 7, 78, 52, 12, 50,
					77, 91, 8 },
			{ 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48,
					04, 56, 62, 00 },
			{ 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03,
					49, 13, 36, 65 },
			{ 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71,
					37, 02, 36, 91 },
			{ 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28,
					66, 33, 13, 80 },
			{ 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20,
					35, 17, 12, 50 },
			{ 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66,
					18, 38, 64, 70 },
			{ 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 8, 40, 91,
					66, 49, 94, 21 },
			{ 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88,
					34, 89, 63, 72 },
			{ 21, 36, 23, 9, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97,
					34, 31, 33, 95 },
			{ 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14,
					9, 53, 56, 92 },
			{ 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24,
					36, 29, 85, 57 },
			{ 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58,
					51, 54, 17, 58 },
			{ 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77,
					04, 89, 55, 40 },
			{ 04, 52, 8, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79,
					33, 27, 98, 66 },
			{ 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32,
					63, 93, 53, 69 },
			{ 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8, 46, 29, 32,
					40, 62, 76, 36 },
			{ 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85,
					74, 04, 36, 16 },
			{ 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16,
					23, 57, 05, 54 },
			{ 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01,
					89, 19, 67, 48 } };
}
```
### Problem 12: What is the value of the first triangle number to have over five hundred divisors?
Time: ~0.002 s
```
package margusmartseppcode.From_10_to_19;

public class Problem_12 {
	/** Get number of prime exponents */
	static int getNoPE(int sum) {
		int dx = 1, exp = 1;

		for (int p : new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }) {
			if (sum == 1)
				break;
			if (sum < p * p)
				return dx * 2;
			for (exp = 1; sum % p == 0; exp += 1)
				sum = sum / p;

			dx *= exp;
		}

		return dx;
	}

	public static void main(String[] args) {
		int size = 500, sum = 1;

		for (int i = 1; i < Integer.MAX_VALUE; i++, sum += i)
			if (getNoPE(sum) > size)
				break;

		System.out.println(sum);
	}
}
```
### Problem 13: Find the first ten digits of the sum of one-hundred 50-digit numbers.
Time: ~0.010 s
```java
package margusmartseppcode.From_10_to_19;

import java.math.BigInteger;

public class Problem_13 {
	static String str[] = {
			"37107287533902102798797998220837590246510135740250",
			"46376937677490009712648124896970078050417018260538",
			"74324986199524741059474233309513058123726617309629",
			"91942213363574161572522430563301811072406154908250",
			"23067588207539346171171980310421047513778063246676",
			"89261670696623633820136378418383684178734361726757",
			"28112879812849979408065481931592621691275889832738",
			"44274228917432520321923589422876796487670272189318",
			"47451445736001306439091167216856844588711603153276",
			"70386486105843025439939619828917593665686757934951",
			"62176457141856560629502157223196586755079324193331",
			"64906352462741904929101432445813822663347944758178",
			"92575867718337217661963751590579239728245598838407",
			"58203565325359399008402633568948830189458628227828",
			"80181199384826282014278194139940567587151170094390",
			"35398664372827112653829987240784473053190104293586",
			"86515506006295864861532075273371959191420517255829",
			"71693888707715466499115593487603532921714970056938",
			"54370070576826684624621495650076471787294438377604",
			"53282654108756828443191190634694037855217779295145",
			"36123272525000296071075082563815656710885258350721",
			"45876576172410976447339110607218265236877223636045",
			"17423706905851860660448207621209813287860733969412",
			"81142660418086830619328460811191061556940512689692",
			"51934325451728388641918047049293215058642563049483",
			"62467221648435076201727918039944693004732956340691",
			"15732444386908125794514089057706229429197107928209",
			"55037687525678773091862540744969844508330393682126",
			"18336384825330154686196124348767681297534375946515",
			"80386287592878490201521685554828717201219257766954",
			"78182833757993103614740356856449095527097864797581",
			"16726320100436897842553539920931837441497806860984",
			"48403098129077791799088218795327364475675590848030",
			"87086987551392711854517078544161852424320693150332",
			"59959406895756536782107074926966537676326235447210",
			"69793950679652694742597709739166693763042633987085",
			"41052684708299085211399427365734116182760315001271",
			"65378607361501080857009149939512557028198746004375",
			"35829035317434717326932123578154982629742552737307",
			"94953759765105305946966067683156574377167401875275",
			"88902802571733229619176668713819931811048770190271",
			"25267680276078003013678680992525463401061632866526",
			"36270218540497705585629946580636237993140746255962",
			"24074486908231174977792365466257246923322810917141",
			"91430288197103288597806669760892938638285025333403",
			"34413065578016127815921815005561868836468420090470",
			"23053081172816430487623791969842487255036638784583",
			"11487696932154902810424020138335124462181441773470",
			"63783299490636259666498587618221225225512486764533",
			"67720186971698544312419572409913959008952310058822",
			"95548255300263520781532296796249481641953868218774",
			"76085327132285723110424803456124867697064507995236",
			"37774242535411291684276865538926205024910326572967",
			"23701913275725675285653248258265463092207058596522",
			"29798860272258331913126375147341994889534765745501",
			"18495701454879288984856827726077713721403798879715",
			"38298203783031473527721580348144513491373226651381",
			"34829543829199918180278916522431027392251122869539",
			"40957953066405232632538044100059654939159879593635",
			"29746152185502371307642255121183693803580388584903",
			"41698116222072977186158236678424689157993532961922",
			"62467957194401269043877107275048102390895523597457",
			"23189706772547915061505504953922979530901129967519",
			"86188088225875314529584099251203829009407770775672",
			"11306739708304724483816533873502340845647058077308",
			"82959174767140363198008187129011875491310547126581",
			"97623331044818386269515456334926366572897563400500",
			"42846280183517070527831839425882145521227251250327",
			"55121603546981200581762165212827652751691296897789",
			"32238195734329339946437501907836945765883352399886",
			"75506164965184775180738168837861091527357929701337",
			"62177842752192623401942399639168044983993173312731",
			"32924185707147349566916674687634660915035914677504",
			"99518671430235219628894890102423325116913619626622",
			"73267460800591547471830798392868535206946944540724",
			"76841822524674417161514036427982273348055556214818",
			"97142617910342598647204516893989422179826088076852",
			"87783646182799346313767754307809363333018982642090",
			"10848802521674670883215120185883543223812876952786",
			"71329612474782464538636993009049310363619763878039",
			"62184073572399794223406235393808339651327408011116",
			"66627891981488087797941876876144230030984490851411",
			"60661826293682836764744779239180335110989069790714",
			"85786944089552990653640447425576083659976645795096",
			"66024396409905389607120198219976047599490197230297",
			"64913982680032973156037120041377903785566085089252",
			"16730939319872750275468906903707539413042652315011",
			"94809377245048795150954100921645863754710598436791",
			"78639167021187492431995700641917969777599028300699",
			"15368713711936614952811305876380278410754449733078",
			"40789923115535562561142322423255033685442488917353",
			"44889911501440648020369068063960672322193204149535",
			"41503128880339536053299340368006977710650566631954",
			"81234880673210146739058568557934581403627822703280",
			"82616570773948327592232845941706525094512325230608",
			"22918802058777319719839450180888072429661980811197",
			"77158542502016545090413245809786882778948721859617",
			"72107838435069186155435662884062257473692284509516",
			"20849603980134001723930671666823555245252804609722",
			"53503534226472524250874054075591789781264330331690" };

	public static void main(String[] args) {
		BigInteger tmp = BigInteger.ZERO;
		for (String s : str)
			tmp=tmp.add(new BigInteger(s));
		System.out.println(tmp.toString().substring(0, 10));
	}
}
```
### Problem 14: Find the longest sequence using a starting number under one million.
Time: ~0.355 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_14 {
	static long makeChain(long nr, long d[], int max) {
		if (nr >= max)
			return makeChain(nr % 2 == 0 ? nr / 2 : 3 * nr + 1, d, max) + 1;
		else if (d[(int) nr] == 0)
			d[(int) nr] = makeChain(nr % 2 == 0 ? nr / 2 : 3 * nr + 1, d, max) + 1;

		return d[(int) nr];
	}

	public static void main(String[] args) {
		int maxNr = 0, maxSize = 1000000;
		long maxLen = 0, d[] = new long[maxSize];

		d[1] = 1;
		for (int i = 500001; i < 1000000; i++)
			if (makeChain(i, d, maxSize) > maxLen)
				maxLen = d[maxNr = i];

		System.out.println(maxNr);
	}
}
```
Time: ~0.361 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_14 {
	static final int maxSize = 1000000;
	static long d[] = new long[maxSize];
	static {
		d[1] = 1;
	}

	static long makeChain(long nr) {
		if (nr >= maxSize)
			return makeChain(nr % 2 == 0 ? nr / 2 : 3 * nr + 1) + 1;
		else if (d[(int) nr] == 0)
			d[(int) nr] = makeChain(nr % 2 == 0 ? nr / 2 : 3 * nr + 1) + 1;

		return d[(int) nr];
	}

	public static void main(String[] args) {
		int maxNr = 0;
		long maxLen = 0;

		for (int i = 1; i < 1000000; i++) {
			if (makeChain(i) > maxLen) {
				maxNr = i;
				maxLen = d[i];
			}
		}

		System.out.println(maxNr);
	}
}
```
### Problem 15: Starting in the top left corner in a 20 by 20 grid, how many routes are there to the bottom right corner?
Time: ~0.001 s
```java
package margusmartseppcode.From_10_to_19;

import java.math.BigInteger;

public class Problem_15 {
	static final int maxSize = 42;
	static BigInteger f[] = new BigInteger[maxSize];
	static {
		f[0] = BigInteger.ONE;
		for (int i = 1; i < maxSize; i++)
			f[i] = f[i - 1].multiply(BigInteger.valueOf(i));
	}

	public static void main(String[] args) {
		// s=x=y
		// !(x+y)/!x*!y
		int s = 20;
		System.out.println(f[s + s].divide((f[s].multiply(f[s]))));
	}
}
```
### Problem 16: What is the sum of the digits of the number 2^1000?
Time: ~0.003 s
```java
package margusmartseppcode.From_10_to_19;

import java.math.BigInteger;

public class Problem_16 {

	public static void main(String[] args) {
		int sum = 0;
		for (char c : BigInteger.valueOf(2L).pow(1000).toString().toCharArray())
			sum += c - '0';
		System.out.println(sum);
	}
}
```
### Problem 17: How many letters would be needed to write all the numbers in words from 1 to 1000?
Time: ~0.002 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_17 {
	static int hundred = "hundred".length();
	static int hundredand = "hundredand".length();
	static int onethousand = "onethousand".length();
	static int lens[] = new int[100];
	static {
		String tmp[] = ("| one two three four five six seven eight nine "
				+ "| eleven twelve thirteen fourteen fifteen sixteen seventeen eighteen "
				+ "nineteen | ten twenty thirty forty fifty sixty seventy eighty ninety")
				.split(" ");
		for (int i = 1; i < 10; i++) {
			lens[i] = tmp[i].length();
			lens[i + 10] = tmp[i + 10].length();
			lens[i * 10] = tmp[i + 20].length();
		}
		for (int i = 2; i < 10; i++)
			for (int j = 1; j < 10; j++)
				lens[i * 10 + j] = lens[i * 10] + lens[j];
	}

	public static void main(String[] args) {
		int sum = 0, hundredsum = 0;

		for (int i = 1; i < lens.length; i++)
			hundredsum += lens[i];

		sum = hundredsum;
		for (int i = 1; i < 10; i++)
			sum += lens[i] + hundred + (lens[i] + hundredand) * 99 + hundredsum;

		sum += onethousand;
		System.out.println(sum);
	}
}
```
### Problem 18: Find the maximum sum travelling from the top of the triangle to the base.
Time: ~0.001 s
```java
package margusmartseppcode.From_10_to_19;

public class Problem_18 {

	static int nrs[][] = { { 75 }, { 95, 64 }, { 17, 47, 82 },
			{ 18, 35, 87, 10 }, { 20, 04, 82, 47, 65 },
			{ 19, 01, 23, 75, 03, 34 }, { 88, 02, 77, 73, 07, 63, 67 },
			{ 99, 65, 04, 28, 06, 16, 70, 92 },
			{ 41, 41, 26, 56, 83, 40, 80, 70, 33 },
			{ 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
			{ 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
			{ 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
			{ 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
			{ 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
			{ 04, 62, 98, 27, 23, 9, 70, 98, 73, 93, 38, 53, 60, 04, 23 } };

	public static void main(String[] args) {
		for (int i = nrs.length - 2; i >= 0; i--)
			for (int j = 0; j < nrs[i].length; j++)
				nrs[i][j] += Math.max(nrs[i + 1][j], nrs[i + 1][j + 1]);

		System.out.println(nrs[0][0]);
	}
}
```
### Problem 19: How many Sundays fell on the first of the month during the twentieth century?
Time: ~0.098 s
```java
package margusmartseppcode.From_10_to_19;

import java.util.Calendar;

public class Problem_19 {
	public static void main(String[] a) {
		int Sundays = 0, D = Calendar.DATE;
		Calendar F = Calendar.getInstance();

		for (F.set(1901, 0, 1); F.get(Calendar.YEAR) < 2001; F.add(D, 1))
			if (F.get(Calendar.DAY_OF_MONTH) == 1)
				if (F.get(Calendar.DAY_OF_WEEK) == Calendar.SUNDAY)
					Sundays++;

		System.out.println(Sundays);
	}
}
```
