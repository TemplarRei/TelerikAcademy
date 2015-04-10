//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;
class PointInCircleOutOfRect
{
    static void Main()
    {
        Console.WriteLine("Type x coordinate for the point:");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Type y coordinate for the point");
        float y = float.Parse(Console.ReadLine());
        //For the circle we use the same solution as above (see 07.), for the rectangle it's easier - imagine the point
        //as having to be in between the "borders" given by the sides of the rectangle.
        bool checkIfInCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5;
        bool checkIfOutRect = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
        if (checkIfInCircle == true && checkIfOutRect == true)
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is NOT inside the circle and outside the rectangle.");

        }
        Console.ReadLine();
    }
}