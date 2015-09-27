using System;

class PrintAdeckOf52Cards
{
    static void Main()
    {
        // Use console font - Raster font
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        char[] color = { '♣', '♦', '♥', '♠' };
        
        for (int i = 2; i <= 14; i++)
        {
            string card = i.ToString();

            switch (i)
            {
                case 11:
                    card = "J"; break;
                case 12:
                    card = "D"; break;
                case 13:
                    card = "K"; break;
                case 14:
                    card = "A"; break;
            }

            for (int j = 0; j < 4; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(card);
                if (j == 0 || j == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (j == 1 || j == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(color[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
