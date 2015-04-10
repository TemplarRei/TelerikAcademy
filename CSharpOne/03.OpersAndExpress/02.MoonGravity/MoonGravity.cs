//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;
class MoonGravity
{
    static void Main()
    {
        Console.WriteLine("Enter your weight:");
        float weight = float.Parse(Console.ReadLine());
        //almost the same as the above, really - simple maths :)
        Console.WriteLine("Your weight on the moon would be: {0} kg.", weight * 17 / 100);
        Console.WriteLine("Press any key to close...");
        Console.ReadLine();
    }
}