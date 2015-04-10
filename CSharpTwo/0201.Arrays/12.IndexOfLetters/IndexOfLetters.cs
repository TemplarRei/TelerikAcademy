//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;
using System.Collections.Generic;
    class IndexOfLetters
    {
        static void Main()
        {
            List<char> alphabet = new List<char>();
            for (int i = 65; i <= 90; i++)
            {
                alphabet.Add((char)i);
            }
            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToUpper();

            Console.Write("The alphabet indexes of {0} are: ", word);
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("{0}, ", alphabet.IndexOf(word[i])); 
            }
            Console.WriteLine("\b\b \n");
        }
    }