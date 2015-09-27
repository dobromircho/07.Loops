using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        int n = 0;
        bool isNumber = int.TryParse(Console.ReadLine(), out n);
        if (isNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {

                }
                else
                {
                    Console.Write(i + " ");
                }
                
            }
        }
        else
        {
            Console.WriteLine("Wrong Entry");
        }
    }
}
// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space
