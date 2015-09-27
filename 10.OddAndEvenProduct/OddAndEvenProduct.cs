using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            else
            {
                evenProduct *= int.Parse(numbers[i]);
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes\nProduct: {0} ", evenProduct );
        }
        else
        {
            Console.WriteLine("No\nOdd product: {0}\nEven product: {1}" ,oddProduct ,evenProduct);
        }
    }
}
// You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
