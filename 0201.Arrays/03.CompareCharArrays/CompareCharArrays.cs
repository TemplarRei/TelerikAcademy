//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
class CompareCharArrays
{
    static void Main()
    {

        Console.WriteLine("Enter first char array on a single line:");
        string str = Console.ReadLine();
        str = str.Replace(" ", "");
        char[] firstArr = str.ToCharArray();

        Console.WriteLine("Enter second char array on a single line:");
        str = Console.ReadLine();
        str = str.Replace(" ", "");
        char[] secondArr = str.ToCharArray();

        for (int i = 0; i < Math.Min(secondArr.Length, firstArr.Length); i++)
        {
            if (Char.IsUpper(firstArr[i]) && Char.IsUpper(firstArr[i]))
            {
                if (firstArr[i] == secondArr[i])
                {
                    Console.WriteLine("{0} - the two characters are the same.", i);
                }

                else
                {
                    Console.WriteLine("{0} - the two characters are different.", i);
                }

            }

            else if (Char.IsLower(firstArr[i]) && Char.IsLower(firstArr[i]))
            {
                if (firstArr[i] == secondArr[i])
                {
                    Console.WriteLine("{0} - the two characters are the same.", i);
                }

                else
                {
                    Console.WriteLine("{0} - the two characters are different.", i);
                }
            }

            else
            {
                char temp1 = Char.ToUpper(firstArr[i]);
                char temp2 = Char.ToUpper(secondArr[i]);
                if (temp1 == temp2)
                {
                    Console.WriteLine("{0} - the two characters are the same, but in different cases.", i);
                }

                else
                {
                    Console.WriteLine("{0} - the two characters are different.", i);
                }
            }
        }
        Console.WriteLine("End of the shorter array.");

    }
}
