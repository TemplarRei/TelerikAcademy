using System;
class PrintCompanyInfo
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter your company name:");
        string compName = Console.ReadLine();
        Console.WriteLine("Enter your company's address:");
        string compAddress = Console.ReadLine();
        Console.WriteLine("Enter your company's phone number:");
        string compPhone = Console.ReadLine();
        Console.WriteLine("Enter your fax number:");
        string faxNum = Console.ReadLine();
        Console.WriteLine("Enter your web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your phone number:");
        string usersPhone = Console.ReadLine();

        //output
        Console.WriteLine(compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Tel. {0}", compPhone);
        Console.WriteLine("Fax: {0} (Does anyone still use this?!)", faxNum);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, usersPhone);

    }
}