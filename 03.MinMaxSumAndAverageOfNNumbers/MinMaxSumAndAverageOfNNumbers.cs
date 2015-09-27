using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int sum = 0;
        float average = 0f;
        int[] inputs = new int[n];
        if (n > 1)
        {
            for (int i = 0; i < n; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
                sum += inputs[i];
            }
        }
        Array.Sort(inputs);
        min = inputs[0];
        max = inputs[n-1];
        average = (float)sum / n;
        Console.WriteLine("Min = {0}\nMax = {1}\nSum = {2}\nAvg = {3:0.00}", min, max, sum, average);
    }
}
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
