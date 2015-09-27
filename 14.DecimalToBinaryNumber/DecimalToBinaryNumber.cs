using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        string[] binary = new string[64];
        byte[] bits = new byte[64];
        
        for (int i = binary.Length -1; i >=0; i--)
        {
            if (num % 2 == 1)
            {
                bits[i] = 1;
            }
            else
            {
                bits[i] = 0;
            }
            num = num / 2;
        }
        for (int i = 0; i < bits.Length; i++)
        {
            binary[i] = bits[i].ToString();
        }
        
        for (int i = 0; i < binary.Length; i++)
        {
            Console.Write(binary[i].ToString());
        }
    }
}
// Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. Examples:
// 3	                                  11
// 43691	                1010101010101011
// 236476736	1110000110000101100101000000

