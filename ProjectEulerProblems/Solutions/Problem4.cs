using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem4
    {
        /*
         A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         Find the largest palindrome made from the product of two 3-digit numbers.
        */
        public static int Solve(bool output = false)
        {
            // Largest product of two 3-digit numbers
            int result = 998001;
            char[] revNum = new char[6];
            bool match = false;

            while ( ! match )
            {
                // Reverse the array of chars
                revNum = result.ToString().ToCharArray();
                Array.Reverse(revNum);

                // Is it a palindrome?
                if (output) Console.WriteLine($"{new string(revNum)}:{result}");
                bool palindrome = new string (revNum) == result.ToString();

                if (palindrome) {
                    for (int i = 999; i > 99; i--)
                    {
                        // Is it a product of two three digit numbers?
                        if ((result % i == 0) && ( result / i < 1000 ))
                        {
                            if (output) Console.WriteLine(i);
                            match = true;
                            break;
                        }
                    }
                    if (!match) result -= 1;
                } else result -= 1;
                
            }
            
            return result;
        }

    }
}
