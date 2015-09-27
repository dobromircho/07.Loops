using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        if (min <= max)
        {
            Console.Write("Random Numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(RandomGen(min, max, i) + " ");
            }
        }
    }

    static int RandomGen(int min, int max, int seed)
    {
        Random rand = new Random(seed);
        int randomNumber = rand.Next(min, max + 1);
        return randomNumber;
    }
}
//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]
