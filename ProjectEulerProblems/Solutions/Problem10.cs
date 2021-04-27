using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem10
    {
        public static long Solve(bool output = false)
        {
            /* 
             The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

             Find the sum of all the primes below two million.

            */

            // We know the sum up to 10
            long sum = 17;

            bool isPrime(int n)
            {
                if ((n > 1) && (n <= 3)) return true;
                if ((n % 2 == 0) || (n % 3 == 0)) return false;

                // Primality test: https://en.wikipedia.org/wiki/Primality_test
                for (int k = 1; k <= ((Math.Sqrt(n) + 1) / 6); k++)
                {
                    if ((n % (6 * k - 1) == 0) || (n % (6 * k + 1) == 0)) return false;
                }

                return true;
            }

            // Check only odd numbers from 11 to 2,000,000, since they can only be prime
            for (int num = 11; num < 2000000; num += 2)
            {
                if (isPrime(num)) sum += num;
                if (output) Console.WriteLine($"{num}:{sum}");
            }

            return sum;
        }
    }
}
