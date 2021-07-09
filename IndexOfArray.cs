using System;
using static System.Console;

class IndexOf
{
    static void Main()
    {
        int[] validItems = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
        double[] prices = { 0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00 };
        int itemInput;
        double itemPrice = 0;
        bool isValidItem = false;
            
        WriteLine("Enter item number:");
        itemInput = Convert.ToInt32(ReadLine());

        for (int x=0; x<validItems.Length; ++x)
        {
            if (itemInput == validItems[x])
            {
                isValidItem = true;
                itemPrice = prices[x];
            }
        }
        if (isValidItem)
            WriteLine("Price is {0}", itemPrice);
        else
            WriteLine("Not Found");

    }
}
