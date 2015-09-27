using System;
using System.Numerics;

class CalculateCombinatorics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusKFact = 1;
        if (k > 0 && n > k && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                if (i <= k)
                {
                    kFact *= i;
                }
                if (i <= (n - k))
                {
                    nMinusKFact *= i;
                }
            }
            BigInteger result = nFact / (kFact * nMinusKFact);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong entry");
        }
    }
}
// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:

//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k(1 < k<n< 100). Try to use only two loops.

