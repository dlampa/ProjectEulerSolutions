using System;

namespace ProjectEulerSolutions.Solutions
{
    public static class Problem8
    {
        public static long Solve(bool output = false)
        {
            /*  The four adjacent digits in the 1000 - digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.

              73167176531330624919225119674426574742355349194934
              96983520312774506326239578318016984801869478851843
              85861560789112949495459501737958331952853208805511
              12540698747158523863050715693290963295227443043557
              66896648950445244523161731856403098711121722383113
              62229893423380308135336276614282806444486645238749
              30358907296290491560440772390713810515859307960866
              70172427121883998797908792274921901699720888093776
              65727333001053367881220235421809751254540594752243
              52584907711670556013604839586446706324415722155397
              53697817977846174064955149290862569321978468622482
              83972241375657056057490261407972968652414535100474
              82166370484403199890008895243450658541227588666881
              16427171479924442928230863465674813919123162824586
              17866458359124566529476545682848912883142607690042
              24219022671055626321111109370544217506941658960408
              07198403850962455444362981230987879927244284909188
              84580156166097919133875499200524063689912560717606
              05886116467109405077541002256983155200055935729725
              71636269561882670428252483600823257530420752963450

              Find the thirteen adjacent digits in the 1000 - digit number that have the greatest product. What is the value of this product ?*/

            const string largeNumber = "73167176531330624919225119674426574742355349194934969835203127745" +
              "0632623957831801698480186947885184385861560789112949495459501737958331952853208805" +
              "5111254069874715852386305071569329096329522744304355766896648950445244523161731856" +
              "4030987111217223831136222989342338030813533627661428280644448664523874930358907296" +
              "2904915604407723907138105158593079608667017242712188399879790879227492190169972088" +
              "8093776657273330010533678812202354218097512545405947522435258490771167055601360483" +
              "9586446706324415722155397536978179778461740649551492908625693219784686224828397224" +
              "1375657056057490261407972968652414535100474821663704844031998900088952434506585412" +
              "2758866688116427171479924442928230863465674813919123162824586178664583591245665294" +
              "7654568284891288314260769004224219022671055626321111109370544217506941658960408071" +
              "9840385096245544436298123098787992724428490918884580156166097919133875499200524063" +
              "6899125607176060588611646710940507754100225698315520005593572972571636269561882670" +
              "428252483600823257530420752963450";
            const int iterSize = 13; // Number of adjacent digits to check

            long product; // Store the product during iterations
            long result = 1; // Store the result
            char lastChar = largeNumber[0]; // First character that will be dropped after an iteration      

            for (int i = 0; (i + iterSize) < largeNumber.Length; i++)
            {
                string numOfInterest = largeNumber.Substring(i, iterSize);
                if (output) Console.Write($"{i}:{result}, {numOfInterest}");
                // Check if the numOfInterest contains a zero
                int posZero = numOfInterest.LastIndexOf('0');
                if (posZero > -1)
                {
                    // Skip 'containsZero' digits of the largeNumber if a zero digit is found
                    i = i + posZero;
                    if (output) Console.WriteLine("");
                    continue;
                }
                else if (long.Parse(lastChar.ToString()) >= long.Parse(numOfInterest[numOfInterest.Length - 1].ToString()))
                {
                    // Continue if the last character from the previous iteration was greater than the
                    // new last char of the current iteration
                    lastChar = '0';
                    if (output) Console.WriteLine("");
                    continue;
                }
                else
                {
                    product = 1;
                    // Calculate the product of individual digits
                    foreach (char num in numOfInterest)
                    {
                        product = product * Int32.Parse(num.ToString());
                    }

                    if (output) Console.WriteLine($", {product}");

                    if (product > result) { result = product; }
                    lastChar = numOfInterest[0];
                }
            }

            return result;
        }
    }
}
