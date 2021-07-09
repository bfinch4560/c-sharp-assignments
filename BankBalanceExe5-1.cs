using System;
using static System.Console;

class BankBalance
{
    static void Main()
    {
        int controlNumber;
        int yearsToGo = 1;

        WriteLine("Enter initial bank balance:");
        double bankBalance = Convert.ToDouble(ReadLine());

        WriteLine("Enter the annual interest rate");
        int interestRate = Convert.ToInt32(ReadLine());

        WriteLine("Enter how many years you wish to display:");
        int years = Convert.ToInt32(ReadLine());
        controlNumber = years; 

        while (controlNumber > 0)
        {
            bankBalance = bankBalance * (1+(interestRate * .01));
            WriteLine("Year " + yearsToGo + " " + "{0:C}", bankBalance);
            --controlNumber;
            ++yearsToGo;
        }
    }
}