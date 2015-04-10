using System;
using System.Text;
class DecToBin
{
    static void Main()
    {

        Console.WriteLine("Enter a decimal integer:");
        int dec = int.Parse(Console.ReadLine());
        StringBuilder bin = new StringBuilder();
        while (dec / 2 != 0)
        {
            if (dec % 2 == 1)
            {
                bin.Insert(0, 1);
                dec /= 2;
            }
            else
            {
                bin.Insert(0, 0);
                dec /= 2;
            }
        }
        if (dec % 2 == 0)
        {
            bin.Insert(0, 0);
        }
        else
        {
            bin.Insert(0, 1);

        }
        Console.WriteLine(bin);
    }
}