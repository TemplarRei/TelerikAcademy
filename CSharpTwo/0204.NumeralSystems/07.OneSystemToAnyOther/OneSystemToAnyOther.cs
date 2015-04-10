using System;
using System.Linq;
using System.Text;
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter the base of the numeral system to convert from: ");
        sbyte baseFrom = sbyte.Parse(Console.ReadLine());

        Console.Write("Enter the base of the numeral system to convert to: ");
        sbyte baseTo = sbyte.Parse(Console.ReadLine());

        if (baseFrom < 2 || baseFrom > 16 || baseTo > 16 || baseTo < 2)
        {
            return;
        }

        Console.WriteLine("Enter number to be converted:");
        Console.WriteLine(string.Concat(Enumerable.Repeat("-", 70)));
        Console.WriteLine("For systems with base greater than decimal, use the following coding:\n|10:A|11:B|12:C|13:D|14:E|15:F|");
        Console.WriteLine(string.Concat(Enumerable.Repeat("-", 70)));
        string number = Console.ReadLine();
        string final;
        if (baseFrom == 10)
        {
            final = ConvertToBase(Convert.ToInt32(number), baseTo);
        }
        else
        {
            final = ConvertToBase(ConvertToDec(number, baseFrom), baseTo);
        }
        Console.WriteLine(final);
    }

    private static string ConvertToBase(int numberAsDec, sbyte baseTo)
    {
        StringBuilder numberToBase = new StringBuilder();
        int temp;
        while (numberAsDec > 0)
        {
            temp = numberAsDec % baseTo;
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
            numberAsDec /= baseTo;
        }
        return numberToBase.ToString();
    }

    private static int ConvertToDec(string number, sbyte baseFrom)
    {
        int num;
        int pow = 0;
        int numberAsDec = 0;
        int temp;
        if (int.TryParse(number, out num))
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                temp = (int)Char.GetNumericValue(number[i]);
                numberAsDec += temp * (int)Math.Pow(baseFrom, pow);
                pow++;
            }
        }
        else
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                switch (number[i])
                {
                    case 'A':
                    case 'a': temp = 10; break;
                    case 'B':
                    case 'b': temp = 11; break;
                    case 'C':
                    case 'c': temp = 12; break;
                    case 'D':
                    case 'd': temp = 13; break;
                    case 'E':
                    case 'e': temp = 14; break;
                    case 'F':
                    case 'f': temp = 15; break;
                    default: temp = (int)Char.GetNumericValue(number[i]);
                        break;
                }
                numberAsDec += temp * (int)Math.Pow(baseFrom, pow);
                pow++;
            }
        }
        return numberAsDec;
    }
}