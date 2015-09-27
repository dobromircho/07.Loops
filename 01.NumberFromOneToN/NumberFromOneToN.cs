using System;

class NumberFromOneToN
{
    static void Main()
    {
        int n = 0;
        bool isNumber = int.TryParse(Console.ReadLine(), out n);
        if (isNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Wrong Entry");
        }
    }
}
// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space
