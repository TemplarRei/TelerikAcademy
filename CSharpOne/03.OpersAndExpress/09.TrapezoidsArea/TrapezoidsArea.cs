using System;
class TrapezoidsArea
    {
        static void Main()
        {
            Console.WriteLine("Type the lenght of side a:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Type the lenght of side b:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Type the height:");
            float height = float.Parse(Console.ReadLine());
            //This one's simple maths, really - you have the formula ((a+b)/2)*h and that's that :)
            Console.WriteLine("The trapezoid's area is {0} sm squared", ((a + b) / 2) * height);
            Console.ReadLine();
        }
    }