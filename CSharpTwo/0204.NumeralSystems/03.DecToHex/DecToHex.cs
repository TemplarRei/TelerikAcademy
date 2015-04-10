using System;
using System.Text;
class DecToHex
{
    static void Main()
    {
        Console.WriteLine("Enter your integer:");
        int numberAsDec = int.Parse(Console.ReadLine());
        StringBuilder numberToBase = new StringBuilder();
        int temp;
        while (numberAsDec > 0)
        {
            temp = numberAsDec % 16;
            if (temp < 10)
            {
                numberToBase.Insert(0, temp);
            }
            else
            {
                switch (temp)
                {
                    case 10: numberToBase.Insert(0, 'A'); break;
                    case 11: numberToBase.Insert(0, 'B'); break;
                    case 12: numberToBase.Insert(0, 'C'); break;
                    case 13: numberToBase.Insert(0, 'D'); break;
                    case 14: numberToBase.Insert(0, 'E'); break;
                    case 15: numberToBase.Insert(0, 'F'); break;
                }
            }
            numberAsDec /= 16;
        }
        Console.WriteLine(numberToBase);
    }
}