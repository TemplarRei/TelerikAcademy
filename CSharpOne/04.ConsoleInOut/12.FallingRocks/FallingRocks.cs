//Implement the "Falling Rocks" game in the text console.
//    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.
using System;
using System.Collections.Generic;
using System.Threading;


struct ThingOnScreen
{
    public int posX;
    public int posY;
    public string charC;
    public ConsoleColor color;
}

class FallingRocks
{
    static void Printing(int x, int y, string c, ConsoleColor color = ConsoleColor.DarkGray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintingString(int x, int y, string str, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static int playField = 30;
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.BufferHeight = Console.WindowHeight = 15;
        Console.BufferWidth = Console.WindowWidth = 50;

        int speed = 100;
        int accel = 3;
        int lives = 3;

        ThingOnScreen dwarf = new ThingOnScreen();
        dwarf.posX = 19;
        dwarf.posY = Console.WindowHeight - 1;
        dwarf.charC = "(O)";
        dwarf.color = ConsoleColor.Red;

        Random randomGen = new Random();
        List<ThingOnScreen> objectsOnScreen = new List<ThingOnScreen>();

        while (true)
        {
            speed += accel;
            if (speed > 450)
            {
                speed = 450;
            }
            Thread.Sleep(500 - speed);

            bool hit = (false);
            for (int i = 0; i < randomGen.Next(0, 7); i++)
            {
                {
                    ThingOnScreen newRock = new ThingOnScreen();
                    newRock.posX = randomGen.Next(0, playField);
                    newRock.posY = 0;
                    switch (randomGen.Next(0, 11))
                    {
                        case 0: newRock.charC = "^"; break;
                        case 1: newRock.charC = "@"; break;
                        case 2: newRock.charC = "*"; break;
                        case 3: newRock.charC = "&"; break;
                        case 4: newRock.charC = "+"; break;
                        case 5: newRock.charC = "%"; break;
                        case 6: newRock.charC = "$"; break;
                        case 7: newRock.charC = "#"; break;
                        case 8: newRock.charC = "!"; break;
                        case 9: newRock.charC = "."; break;
                        case 10: newRock.charC = ";"; break;
                        case 11: newRock.charC = "-"; break;
                    }
                    switch (randomGen.Next(0, 14))
                    {
                        case 0: newRock.color = ConsoleColor.Black; break;
                        case 1: newRock.color = ConsoleColor.Blue; break;
                        case 2: newRock.color = ConsoleColor.Cyan; break;
                        case 3: newRock.color = ConsoleColor.DarkBlue; break;
                        case 4: newRock.color = ConsoleColor.DarkCyan; break;
                        case 5: newRock.color = ConsoleColor.DarkGray; break;
                        case 6: newRock.color = ConsoleColor.DarkGreen; break;
                        case 7: newRock.color = ConsoleColor.DarkMagenta; break;
                        case 8: newRock.color = ConsoleColor.DarkRed; break;
                        case 9: newRock.color = ConsoleColor.DarkYellow; break;
                        case 10: newRock.color = ConsoleColor.Green; break;
                        case 11: newRock.color = ConsoleColor.Magenta; break;
                        case 12: newRock.color = ConsoleColor.Red; break;
                        case 13: newRock.color = ConsoleColor.White; break;
                        case 14: newRock.color = ConsoleColor.Yellow; break;
                    }
                    objectsOnScreen.Add(newRock);
                }
            }

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.posX - 1 >= 0)
                    {
                        dwarf.posX--;
                    }

                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.posX + 1 <= playField)
                    {
                        dwarf.posX++;
                    }
                }
            }

            List<ThingOnScreen> newRocksList = new List<ThingOnScreen>();

            for (int i = 0; i < objectsOnScreen.Count; i++)
            {
                ThingOnScreen oldRock = objectsOnScreen[i];
                ThingOnScreen newRock = new ThingOnScreen();
                newRock.posX = oldRock.posX;
                newRock.posY = oldRock.posY + 1;
                newRock.charC = oldRock.charC;
                newRock.color = oldRock.color;
                if (newRock.posY == dwarf.posY && (newRock.posX == dwarf.posX || newRock.posX == dwarf.posX + 1 || newRock.posX == dwarf.posX + 2))
                {
                    lives--;
                    hit = true;
                    speed -= 50;
                    Printing(dwarf.posX, dwarf.posY, "X", ConsoleColor.Red);
                    if (lives <= 0)
                    {
                        PrintingString(15, 10, "GAME OVER", ConsoleColor.Red);
                        PrintingString(15, 12, "Press enter to exit.", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                if (!(newRock.posY >= Console.WindowHeight))
                {
                    newRocksList.Add(newRock);
                }
            }
            objectsOnScreen = newRocksList;
            Console.Clear();

            foreach (ThingOnScreen rock in objectsOnScreen)
            {
                Printing(rock.posX, rock.posY, rock.charC, rock.color);
            }

            if (hit)
            {
                Console.Beep();
                objectsOnScreen.Clear();
                Printing(dwarf.posX, dwarf.posY, "X", ConsoleColor.Red);
            }
            else
            {
                Printing(dwarf.posX, dwarf.posY, dwarf.charC, dwarf.color);
            }

            PrintingString(32, 4, "Lives: " + lives);
            PrintingString(32, 5, "Speed: " + (speed - 100));
            PrintingString(32, 6, "Accel: " + accel);
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                PrintingString(31, i, "|");
            }



        }
    }
}