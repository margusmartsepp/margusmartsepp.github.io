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