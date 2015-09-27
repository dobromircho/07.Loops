using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger catalan = 0;
        BigInteger twoByNFact = 1;
        BigInteger nPlusOneFact = 1;
        BigInteger nFact = 1;
        if (n == 0)
        {
            catalan = 1;
        }
        if (n > 1 && n < 100)
        {
            for (int i = 1; i <= (2 * n); i++)
            {
                // Using formula C = (2*N)!/((N+1)! * N!)

                twoByNFact *= i;
                if (i <= (n + 1))
                {
                    nPlusOneFact *= i;
                }
                if (i <= n)
                {
                    nFact *= i;
                }
            }
            catalan = twoByNFact / (nPlusOneFact * nFact);
        }
        Console.WriteLine(catalan);
    }
}
// In combinatorics, the Catalan numbers are calculated by the following formula:  C = (2*N)!/((N+1)! * N!)

//Write a program to calculate the nth Catalan number by given n(1 < n< 100). 

