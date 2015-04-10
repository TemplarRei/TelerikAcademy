using System;
class BinaryToShortSinged
{
    static void Main()
    {

        Console.WriteLine("Enter your 16-bit binary number:");
        string bin = Console.ReadLine();

        if (bin.Length > 16)
        {
            return;
        }
        int numberAsDec = 0;
        
            int pow = 0;
            int temp;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                temp = (int)Char.GetNumericValue(bin[i]);
                numberAsDec += temp * (int)Math.Pow(2, pow);
                pow++;
            }
            if (Char.GetNumericValue(bin[0]) == 1)
            {
                numberAsDec = -(65535 - numberAsDec) - 1
                    ;
            }
            Console.WriteLine(numberAsDec);
    }
}