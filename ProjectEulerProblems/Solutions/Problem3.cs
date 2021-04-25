using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem3
    {
        /*The prime factors of 13195 are 5, 7, 13 and 29.

        What is the largest prime factor of the number 600851475143 ?*/

        public static long Solve(bool output = false)
        {
            long num = 600851475143;

            /* 
            
            Alternative, much quicker solution https://projecteuler.net/action=quote;post_id=380822
            
            long k = 1;
            
            while (k < num)
            {
                k += 1;
                // While the result of division is a factor
                while (num % k == 0)
                {
                    // Divide the starting number by the factor
                    num = num / k;
                }
            }
            // Eventually one would end up with the largest number that's a prime number (since it was divisible only by itself,
            // i.e. k = num) and a factor of the original number.

            Console.WriteLine(k);
           */

            static bool isPrime(long n)
            {
                // If number is larger than 1 and less or equal than 3, it's a prime number
                if ((n > 1) && (n <= 3)) return true;
                // If it's divisible by 2 or 3, it's not a prime number
                if ((n % 2 == 0) | (n % 3 == 0)) return false;

                // Check for all integers between 6k-1 = 5 and 6k+1 <= sqrt(n)
                for (int k = 1; k <= (float)((Math.Sqrt(n) + 1) / 6); k++)
                {
                    // If it is divisible by (6k+1) or (6k-1), it's not a prime number
                    if ((n % (6 * k + 1) == 0) || (n % (6 * k - 1) == 0)) return false;
                }

                return true;
            }

            // Check between sqrt(num)-1 down to 1, in steps of -2 (all odd numbers)
            for (long i = (long)Math.Sqrt(num)-1; i > 0; i-=2)
            {
                // If it's a prime number and a factor
                if (isPrime(i) && (num % i == 0)) return i; 
            }
            
            return 0;
        }

    }
}
