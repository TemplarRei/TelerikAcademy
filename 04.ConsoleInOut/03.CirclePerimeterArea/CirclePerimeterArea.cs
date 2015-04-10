//Write a program that reads the radius r of a circle and prints its 
//perimeter and area formatted with 2 digits after the decimal point.
using System;
class CirclePerimeterArea
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter radius r:");
        const float pi = 3.1415926f;
        float r = float.Parse(Console.ReadLine());
        float c = 2 * pi * r;
        float a = pi * (r * r);
        Console.WriteLine("R = {0} \n C = {1:F2} A = {2:F2}", r, c, a);
        Console.ReadLine();
    }
}