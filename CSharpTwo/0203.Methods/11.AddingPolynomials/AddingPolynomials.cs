//    Write a method that adds two polynomials.
//    Represent them as arrays of their coefficients.
//Example:

//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

//Extend the previous program to support also subtraction and multiplication of polynomials.
using System;
using System.Collections.Generic;
using System.Linq;
class AddingPolynomials
{
    static int minLenght;
    static bool firstNomISmaller = false;
    static void Main()
    {
        decimal[] polynomOne = { 5, -1};
        Console.Write("First Polynom:");
        PrintPolynom(polynomOne);

        decimal[] polynomTwo = { 4, 6, -5 };
        Console.Write("Second Polynom:");
        PrintPolynom(polynomTwo);

        int maxLenght = polynomOne.Length;
        minLenght = polynomTwo.Length;
        if (polynomTwo.Length > polynomOne.Length)
        {
            maxLenght = polynomTwo.Length;
            minLenght = polynomOne.Length;
            firstNomISmaller = true;
        }
        decimal[] result = new decimal[maxLenght];

        Console.WriteLine();

        result = SumPolynoms(polynomOne, polynomTwo, result);
        Console.WriteLine("The sum is:");
        PrintPolynom(result);

        result = SubstractPolynoms(polynomOne, polynomTwo, result);
        Console.WriteLine("The substractrion is:");
        PrintPolynom(result);

        result = MultuplicatePolynoms(polynomOne, polynomTwo, result);
        Console.WriteLine("The product is:");
        PrintPolynom(result);
    }
    
    private static decimal[] MultuplicatePolynoms(decimal[] polynomOne, decimal[] polynomTwo, decimal[] result)
    {
        List<decimal> resultMultiply = Enumerable.Repeat((decimal)0, result.Length).ToList();
        for (int i = 0; i < polynomOne.Length; i++)
        {
            for (int j = 0; j < polynomTwo.Length; j++)
            {
                int position = i + j;
                if (position >= resultMultiply.Count - 1)
                {
                    resultMultiply.Add((polynomOne[i] * polynomTwo[j]));
                }
                resultMultiply[position] += (polynomOne[i] * polynomTwo[j]);
            }
        }
        return resultMultiply.ToArray();
    }

    private static decimal[] SubstractPolynoms(decimal[] polynomOne, decimal[] polynomTwo, decimal[] result)
    {
        for (int i = 0; i < minLenght; i++)
        {
            result[i] = polynomOne[i] - polynomTwo[i];
        }
        for (int i = minLenght; i < result.Length; i++)
        {
            if (firstNomISmaller)
            {
                result[i] = polynomTwo[i];
            }
            else
            {
                result[i] = polynomOne[i];
            }
        }
        return result;
    }

    private static decimal[] SumPolynoms(decimal[] polynomOne, decimal[] polynomTwo, decimal[] result)
    {
        for (int i = 0; i < minLenght; i++)
        {
            result[i] = polynomOne[i] + polynomTwo[i];
        }
        for (int i = minLenght; i < result.Length; i++)
        {
            if (firstNomISmaller)
            {
                result[i] = polynomTwo[i];
            }
            else
            {
                result[i] = polynomOne[i];
            }
        }
        return result;
    }

    private static void PrintPolynom(decimal[] polynom)
    {
        for (int index = polynom.Length - 1; index >= 0; index--)
        {
            if (polynom[index] != 0 && index != 0)
            {
                if (polynom[index - 1] >= 0)
                {
                    Console.Write("{0}x^{1} +", polynom[index], index);
                }
                else
                {
                    Console.Write("{0}x^{1} ", polynom[index], index);
                }
            }
            else if (index == 0)
            {
                Console.Write("{0}", polynom[index] + Environment.NewLine);
            }
        }
    }
}