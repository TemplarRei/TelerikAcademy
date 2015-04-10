/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.*/
using System;
class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Your first name is:");

        string firstName = Console.ReadLine();

        Console.WriteLine("Your last name is:");
        string lastName = Console.ReadLine();

        /*The code breaks if you input non-numeric chars here, so I simply used an object and let the user 
         * input whatevs without validation, because I frankly couldn't figure out how to validate it. :/ */   
        Console.WriteLine("Your age is:");
        object age = Console.ReadLine();
        
        //It's ugly, but I couldn't figure out a prettier way to do it :(
        //We use a do loop to validate the info, by leaving open only the M and F symbols for breaking the loop.
        //This way the system is going to ask the poor soul for his sex until it concedes to one of the two.
        Console.WriteLine("Your Sex is (M/F):");
        char sex = Console.ReadLine().Trim()[0];

        {
            do
            {
                if (sex == 'M' || sex == 'F')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is not a valid option for sex.\nPlease, enter M or F.", sex);
                    sex = Console.ReadLine().Trim()[0];
                }
            } while (true);
            Console.WriteLine("Your Personal ID number is:");
            int iDNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Unique employee number is:");
            int uniqueNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} \nAge: {2}\nSex: {3} \nPersonal ID: {4}\nUnique employee number: {5}",
                firstName, lastName, age, sex, iDNumber, uniqueNumber);
        }

        Environment.Exit(0);
    }
}