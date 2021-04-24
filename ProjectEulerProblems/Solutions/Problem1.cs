using System;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem1
    {
        /*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        Find the sum of all the multiples of 3 or 5 below 1000.*/

        public static int Solve(bool output = false)
        {
            // We know that the sum of numbers below 10 is 23
            int result = 23;
            
            for (int i = 10; i < 1000; i++)
            {
                // Check if the number is divisible either by 3 or 5
                if ((i % 3 == 0) | (i % 5 == 0))
                {
                    // Add i to result if true
                    result += i;
                    Console.WriteLine($"{i}:{result}");
                }
            }

            return result;
        }
    }
}
