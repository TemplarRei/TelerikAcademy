using System;
using System.Collections.Generic;
class CorrectBrackets
{
    static void Main()
    {
        string str = "((a+b)/5-d)";//Console.ReadLine();
        List<char> expression = new List<char>();
        for (int i = 0; i < str.Length; i++)
        {
            expression.Add(str[i]);
        }
        CheckForOpeningBracket(expression);
        if (expression.Contains('(') || expression.Contains(')'))
        {
            Console.WriteLine("Invalid expression.");
        }
        else
        {
            Console.WriteLine("Valid expression.");
        }

    }

    private static void CheckForOpeningBracket(List<char> expression)
    {
        for (int i = 0; i < expression.Count; i++)
        {
            if (expression[i] == '(')
            {
                CheckForClosingBracket(expression, i);
            }
        }
    }

    private static void CheckForClosingBracket(List<char> expression, int startIndex)
    {

        for (int endIndex = startIndex; endIndex < expression.Count; endIndex++)
        {
            if (expression[endIndex] == ')')
            {
                
                expression[endIndex] = '0';
                expression[startIndex] = '0';
                return;
            }
        }
    }
}