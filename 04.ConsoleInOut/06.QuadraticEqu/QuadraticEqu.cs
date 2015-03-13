//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
//and solves it (prints its real roots).
using System;
class QuadraticEqu
{
    static void Main()
    {
        int a;
        do
        {
            Console.WriteLine("Enter value for a, that is not equal to 0.");
            a = int.Parse(Console.ReadLine());
        } while (a == 0);

        Console.WriteLine("Enter value for b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("enter value for c");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - 4 * a * c;

        if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1 = {0} \nx2 = {0}", x);
        }
        else if (d < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else
        {
            double xOne = (-b - Math.Sqrt(d)) / (2 * a);
            double xTwo = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0:F3} \nx2 = {1:F3}", xOne, xTwo);
        }
        Console.ReadLine();
    }
}