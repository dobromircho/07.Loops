using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = new int[input.Length];
        long result = 0;
        for (int i = 0 ; i < input.Length ; i++)
        {
            numbers[i] = int.Parse(input[i].ToString());
           
        }
        Array.Reverse(numbers);
        for (int i = 0 ; i < numbers.Length ; i++)
        {
            result += numbers[i] * (long)Math.Pow(2, i);
        }
        Console.WriteLine(result);
    }
}
//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 
// 1010101010101011	           :    43691
// 1110000110000101100101000000:    236476736

