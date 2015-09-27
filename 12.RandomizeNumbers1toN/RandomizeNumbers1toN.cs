using System;

class RandomizeNumbers1toN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        
        for (int i = 0; i <  num.Length; i++)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int current = rand.Next(1, n + 1);
            if (!IsExisting(num, current))
            {
                num[i] = current;
            }
            else
            {
                i--;
            }
        }
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    }

    static bool IsExisting(int[] numbers, int num)
    {
        bool isExist = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == num)
            {
                isExist = true;
            }
        }
        return isExist;
    }
}
// Write a program that enters in integer n and prints all the numbers 1, 2, …, n in random order.
// Examples: 10	:  3 4 8 2 6 7 9 1 10 5 
//            3 :  3 1 2
// Note that the above output is just an example. Due to randomness, your program most probably will produce different results. 