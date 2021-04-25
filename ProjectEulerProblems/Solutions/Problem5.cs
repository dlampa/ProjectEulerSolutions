using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem5
    {
        public static int Solve(bool output = false)
        {
            int num = 2520;

            bool[] match = new bool[11];
                        
            while (!match.All(x => x == true))
            {
                // If the number is divisible by 10 - 20 it will be divisible by 1-20
                for (int i = 10; i <= 20; i++)
                {
                    // Store result of each division in a bool array
                    match[i - 10] = (num % i == 0);

                    // Stop checking num if num % i is not true
                    if (!match[i - 10])
                    {
                        // The number has to be even to be divisible by 2 and 10, so the next iteration is +10
                        num += 10;
                        match = new bool[11];
                        break;
                    }
                }
             
            }

            return num; 
        }
    }
}
