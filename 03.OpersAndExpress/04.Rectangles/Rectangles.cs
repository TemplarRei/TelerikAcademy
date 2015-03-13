//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Write the rectangle's width:");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("Write the rectangle's height:");
        float height = float.Parse(Console.ReadLine());
        //Well, it's simple maths and placeholders here - we go for 2*a+2*b=Perimeter and a*b=S(Area)
        Console.WriteLine("The rectangle's perimeter is {0}, and it's area is {1}.", 2 * width + 2 * height, width * height);
        Console.WriteLine("Press any key to close...");
        Console.ReadLine();
    }
}