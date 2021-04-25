using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem9
    {
        public static double Solve(bool output = false)
        {

            int a = 0, b = 0, c = 0;

            // Based on the https://en.wikipedia.org/wiki/Pythagorean_triple
            // "A Variant"

            // Start at some arbitrary point and generate odd numbers
            for (int m = 3; m < 1000; m = m + 2)
            {
                
                int n = (int)((1000 - Math.Pow(m, 2)) / m);

                // n has to be a natural number and odd.
                if ((n % 1 != 0) || (n % 2 == 0)) continue;
                
                // As per expressions for a, b, c in the wiki article
                a = m * n;
                b = (int)((Math.Pow(m, 2) - Math.Pow(n, 2)) / 2);
                c = (int)((Math.Pow(m, 2) + Math.Pow(n, 2)) / 2);

                if (output) Console.WriteLine($"{m}:{n}:{a}:{b}:{c}");

                // Must satisfy a^2 + b^2 = c^2, a,b,c > 0
                if (((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2)) && (a > 0) && (b > 0) && (c > 0))
                {
                    // If a is even, a and b swap places.
                    if (output) Console.WriteLine($"a: {(b % 2 == 0 ? b: a)}, b: { (b % 2 == 0 ? a: b)}, c: {c}");
                    break;
                }
  

            }

            return a * b * c;
        }
    }
}
