/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/
using System;
class FourDigitNum
{
    static void Main()
    {
        Console.WriteLine("Enter a four-digit integer");
        int num = int.Parse(Console.ReadLine());
        //Here we first use ToString, so we can easily check if the integer is 4 digits long. The entire do loop is
        //designed for that.
        string numAsString = num.ToString();
        do
        {
            if (numAsString.Length != 4)
            {
                Console.WriteLine("Please, enter a four-digit integer.");
                num = int.Parse(Console.ReadLine());
                numAsString = num.ToString();
            }
            else if (numAsString.Length == 4)
            {
                break;
            }
        } while (true);
        //Now we take out each digit - take the leftover after division by ten to get the last digit, 
        //then divide by 10 again to make the next digit - last.
        int fourthDigit = num % 10;
        int thirdDigit = (num /= 10) % 10;
        int secondDigit = (num /= 10) % 10;
        int firstDigit = (num /= 10) % 10;
        //From here on out it's a simple matter of placeholders.
        Console.WriteLine("Let's calculate the sum of the digits for {0}", numAsString);
        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.ReadLine();

        Console.WriteLine("Next, we'll print {0} in reverse order", numAsString);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.ReadLine();

        Console.WriteLine("Third - we'll put {0} in the place of {1}", fourthDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        Console.ReadLine();

        Console.WriteLine("Last of all, we'll swap the places of {0} and {1}", secondDigit, thirdDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        Console.ReadLine();
    }
}