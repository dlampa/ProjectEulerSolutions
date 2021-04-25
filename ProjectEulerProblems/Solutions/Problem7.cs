using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem7
    {
        /*
         By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         What is the 10 001st prime number?
        */

        public static long Solve(bool output = false)
        {
            int primeCount = 6;
            int lastPrime = 13;

            while (primeCount < 10001)
            {
                // Prime numbers will be odd
                lastPrime += 2;

                bool isPrime(int n)
                {
                    // If n is between 1(exclusive) and 3(inclusive) it's a prime number
                    if ((n > 1) & (n <= 3)) return true;
                    // If n is divisible by 2 or 3, n is not a prime number
                    if ((n % 2 == 0) | (n % 3 == 0)) return false;

                    // Primality test: https://en.wikipedia.org/wiki/Primality_test
                    for (int k = 1; k <= ((Math.Sqrt(n)+1)/6); k++)
                    {
                        // If n is divisible by a number (6k+-1) <= sqrt(n), it's not a prime number.
                        if ((n % (6 * k + 1) == 0) || (n % (6 * k - 1) == 0)) return false;
                    }

                    return true;
                }

                
                if (isPrime(lastPrime))
                {
                    primeCount += 1;
                    if (output) Console.WriteLine($"{primeCount}:{lastPrime}");
                }
            }

            return lastPrime;
        }
    }
}
