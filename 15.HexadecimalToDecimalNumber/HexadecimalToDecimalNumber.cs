using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        int[] numbers = new int[input.Length];
        long result = 0;
        for (int i = input.Length -1; i >= 0; i--)
        {

            int num = 0;
            bool isNumber = int.TryParse(input[i].ToString(), out num);
            switch (input[i])
            {
                case 'A':
                    num = 10; break;
                case 'B':
                    num = 11; break;
                case 'C':
                    num = 12; break;
                case 'D':
                    num = 13; break;
                case 'E':
                    num = 14; break;
                case 'F':
                    num = 15; break;
            }
            numbers[i] = num;
            
        }
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i] * (long)Math.Pow(16, i);
        }
        Console.WriteLine(result);
    }
}
// Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:
// FE	       =           254
// 1AE3	       =          6883
// 4ED528CBB4  =  338583669684

