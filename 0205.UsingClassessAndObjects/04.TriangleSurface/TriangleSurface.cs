//Write methods that calculate the surface of a triangle by given:
//    Side and an altitude to it;
//    Three sides;
//    Two sides and an angle between them;
//Use System.Math.
using System;
class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine
            ("Make a selection for input:\n1 - Side and altitude\n2 - Three sides\n3 - Two sides and an angle between them");
        sbyte selection = sbyte.Parse(Console.ReadLine());
        double area = 0;
        if (selection == 1)
        {
            Console.Write("Enter the size of the side in sm: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter the size of the altitude in sm: ");
            double alt = double.Parse(Console.ReadLine());
            area = CalculateSurface(side, alt);
        }
        else if (selection == 2)
        {
            Console.Write("Enter side one: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side two: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side three: ");
            double c = double.Parse(Console.ReadLine());
            area = CalculateSurface(a, b, c);
        }
        else if (selection == 3)
        {
            Console.Write("Enter side one: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side two: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter the angle: ");
            byte angle = byte.Parse(Console.ReadLine());
            area = CalculateSurface(a, b, angle);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wrong button.");
            Main();
        }
        Console.WriteLine(area);
    }
private static double CalculateSurface(double a, double b, byte angle)
    {
        double area = (a * b * Math.Sin(angle)) / 2;
        return area;
    }
    private static double CalculateSurface(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return area;
    }
    

    private static double CalculateSurface(double side, double alt)
    {
        double area = (side * alt) / 2;
        return area;
    }
}