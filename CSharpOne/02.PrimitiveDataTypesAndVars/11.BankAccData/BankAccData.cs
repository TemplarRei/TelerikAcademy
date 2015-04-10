//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.
using System;
class BankAccData
{
    static void Main()
    {
        string holderFirstName = "John";
        string holderSecondName = "Edard";
        string holderLastName = "Snow";

        int balance = 0;

        string bankName = "Bank of Westeros";
        string IBAN = "WE66 AAАА 1231 1012 3456 78";

        long cardOne = 378282246310005;
        long cardTwo = 378282246310006;
        long cardThree = 378282246310007;
        //Print them all, because the "never used" warnings unnerve me.
        Console.WriteLine("{0} {1} {2} \nBalance: {3} \n{4} \n{5} \n{6} \n{7} \n{8}", holderFirstName, holderSecondName, holderLastName,
            balance, bankName, IBAN, cardOne, cardTwo, cardThree);
    }
}
