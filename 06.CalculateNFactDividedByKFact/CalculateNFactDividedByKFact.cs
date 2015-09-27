using System;
using System.Numerics;

class CalculateNFactDividedByKFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        if (k > 0 && n > k && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                if (i <= k)
                {
                    kFact *= i;
                }
            }
            BigInteger result = nFact / kFact;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong entry");
        }
    }
}
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.
