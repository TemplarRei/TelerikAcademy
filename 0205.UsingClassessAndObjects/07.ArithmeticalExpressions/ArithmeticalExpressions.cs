//    Write a program that calculates the value of given arithmetical expression.
//    The expression can contain the following elements only:
//        Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//        Arithmetic operators: +, -, *, / (standard priorities)
//        Mathematical functions: ln(x), sqrt(x), pow(x,y)
//        Brackets (for changing the default priorities): (, )
//Examples:
//input 	output
//(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) 	~10.6
//pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) 	~21.22
//Hint: Use the classical Shunting-yard algorithm and Reverse Polish notation.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace _07.ArithmeticalExpressions
{
    class ArithmeticalExpressions
    {

        public static List<char> operators = new List<char>() { '+', '-', '*', '/' };
        public static List<char> brackets = new List<char>() { '(', ')' };
        public static List<string> functions = new List<string>() { "pow", "ln", "sqrt" };

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)".Trim(); //Console.ReadLine().Trim();
            string trimmedInput = input.Replace(" ", string.Empty);
            var SeparatedTokens = SeparateTokens(trimmedInput);
            var reversePN = ConvertToRPNotation(SeparatedTokens);
            var final = GetResult(reversePN);
            Console.WriteLine(final);

        }
        public static double GetResult(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();
            while (queue.Count != 0)
            {
                string currentToken = queue.Dequeue();
                double number;
                if (double.TryParse(currentToken, out number))
                {
                    stack.Push(number);
                }
                else if (operators.Contains(currentToken[0]) || functions.Contains(currentToken))
                {
                    if (currentToken == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);

                    }
                    else if (currentToken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue * secondValue);

                    }
                    else if (currentToken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else if (currentToken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentToken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    else if (currentToken == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double value = stack.Pop();

                        stack.Push(Math.Sqrt(value));
                    }
                    else if (currentToken == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double value = stack.Pop();

                        stack.Push(Math.Log(value));
                    }

                }

            }
            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression.");
            }
        }
        public static int Precedence(string aritmOperator)
        {
            if (aritmOperator == "+" || aritmOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }
        public static Queue<string> ConvertToRPNotation(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;
                if (double.TryParse(currentToken, out number))
                {
                    queue.Enqueue(currentToken);
                }

                else if (functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }

                else if (currentToken == ",")
                {
                    if (stack.Count == 0 || !stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid bracket or function separator");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }

                else if (operators.Contains(currentToken[0]))
                {
                    while (stack.Count != 0 && operators.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());

                    }
                    stack.Push(currentToken);
                }

                else if (currentToken == "(")
                {
                    stack.Push(currentToken);
                }

                else if (currentToken == ")")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid bracket");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Pop();
                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }
            while (stack.Count != 0)
            {
                if (brackets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid bracket.");
                }
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }
        public static List<string> SeparateTokens(string expression)
        {
            List<string> result = new List<string>();
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '-' && (i == 0 || expression[i - 1] == '(' || expression[i - 1] == ','))
                {
                    number.Append('-');
                }
                else if (Char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    number.Append(expression[i]);
                }
                else if (!Char.IsDigit(expression[i]) && expression[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;

                }
                else if (brackets.Contains(expression[i]))
                {
                    result.Add(expression[i].ToString());
                }
                else if (expression[i] == ',')
                {
                    result.Add(",");
                }
                else if (operators.Contains(expression[i]))
                {
                    result.Add(expression[i].ToString());
                }
                else if (i + 1 < expression.Length && expression.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add(expression.Substring(i, 2));
                    i++;
                }
                else if (i + 2 < expression.Length && expression.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add(expression.Substring(i, 3));
                    i += 2;
                }
                else if (i + 3 < expression.Length && expression.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add(expression.Substring(i, 4));
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }
            }
            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }
            return result;
        }
        //public static string TrimInput (string input)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (Char.IsWhiteSpace(input[i]))
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            result.Append(input[i]);
        //        }
        //    }
        //    return result.ToString();
        //}
    }
}
