using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem6
    {
        public static int Solve(bool output = false)
        {
            int sumOfSquares = 0;
            int sumOfNums = 0;
            int num;

            // The 10s multiplier
            for (int m = 0; m < 10; m++)
            {
                // The 1s
                for (int n = 0; n < 10; n++)
                {
                    // Calculate the number
                    num = (n + 1) + m * 10;
                    // Sum of numbers in series, e.g. 1, 2, 3 ... for m = 0
                    sumOfNums += num;
                    // Sum of squares, e.g. 1^2 + 2^2 ..
                    sumOfSquares += (int)Math.Pow(num, 2);
                }
            }

            if (output) Console.WriteLine($"Sum of Squares: {sumOfSquares} Square of Sum: {Math.Pow(sumOfNums, 2)}");
            
            return (int)(Math.Pow(sumOfNums,2) - sumOfSquares);
        }
    }
}
