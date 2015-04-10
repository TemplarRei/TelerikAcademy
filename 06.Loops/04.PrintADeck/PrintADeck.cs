//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and 
//a switch-case statement.

using System;
    class PrintADeck
    {
        static void Main()
        {
            string[] indexes = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = new string[] { "clubs", "diamonds", "hearts", "spades" };

            for (int i = 0; i < indexes.Length ; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Console.Write("{0,-2} of {1}, ", indexes[i], suits[j]);
                }
                Console.Write("\b\b \b\n");
            }
        }
    }