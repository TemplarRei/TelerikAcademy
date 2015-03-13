//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;
class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Type x coordinate for the point:");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Type y coordinate for the point");
        float y = float.Parse(Console.ReadLine());
        //We use the mighty Pythagorean theorem to bool check the point relative to the circle's radius. 
        bool checkIfInCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5;
        if (checkIfInCircle == true)
        {
            Console.WriteLine("The point is inside the circle.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");

        }
        Console.ReadLine();
    }
}