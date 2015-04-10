
    //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    //Find in MSDN how to use System.IO.File.ReadAllText(…).
    //Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
class ReadFileContents
{
    static void Main()
    {
        string text = string.Empty;
        try
        {
            string path = @"C:\WINDOWS\win.ini"; //Console.ReadLine();
            text = File.ReadAllText(path);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path must not be empty.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine(@"Invalid path. It must not be empty and must not contain invalid characterss. (ASCII chars 1-31; quote (""), less than (<), greater than (>), pipe (|), backspace (\b), null (\0) and tab (\t))");
        }

        catch (PathTooLongException)
        {
            Console.WriteLine("The path must be less than 248 characters and the file name must be below 260 characters for Windows based platforms.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified directory does not exist.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file could not be found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An Input/Output error has occured while trying to open the file. ");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The specified path is either not a file or you do not have access to it.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in unknown or invalid format.");
        }
        Console.WriteLine(text);
    }
}