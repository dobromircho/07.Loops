using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 1 && n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n + i - 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops
                            
                            4	1 2 3 4
                                2 3 4 5
                                3 4 5 6
                                4 5 6 7      */
