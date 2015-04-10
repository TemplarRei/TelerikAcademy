using System;
//Write a program to read your birthday from the console and 
//print how old you are now and how old you will be after 10 years.
class AgeAfterTenYears
{
    static void Main()
    {
        //First we use a while loop to create a "Exit? (y/n)" dialog, 
        //along with lines 30-35 More info: http://www.dotnetperls.com/while.  
        while (true)
        {
            //Then we use the try-catch ref to read the users input (his age) 
            //and print a "You have entered an invalid date." message.
            try
            {
                //We ask the user for his birth date, read it and Parse it to local system time.
                Console.Write("Enter your birth date (mm.dd.yyyy): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                //We calculate his age with lines 22 and 23. This used to be very ugly and long, 
                //but I discovered the TimeSpan struct and now the world is a better place!
                TimeSpan age = DateTime.Now - birthDate;
                Console.WriteLine("Your age: {0} years", (int)(age.Days / 365.25));
                Console.WriteLine("Your age after 10 years will be: {0} years", (int)(age.Days / 365.25 + 10));
            }
            //Second part of the try-catch ref and we use Environment.NewLine to add a new line after the printed text.
            catch
            {
                Console.WriteLine("You have entered an invalid date." + Environment.NewLine);
            }
            //Second part of the "Exit?" dialog, here we print the question and with an if ref we exit from the console. 
            //Any other response loops the app. 
            Console.WriteLine("Exit? (y/n)");
            string userValue = Console.ReadLine();

            if (userValue == "y")
            {
                Environment.Exit(0);
            }
        }
    }
}