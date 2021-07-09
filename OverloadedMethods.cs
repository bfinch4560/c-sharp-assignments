using System;
using static System.Console;

class MealPriceCalculation
{
    static void Main()
    {
        WriteLine("Please enter the meal price in dollar amount:");
        double mealPrice1 = Convert.ToDouble(ReadLine());
        WriteLine("Please enter the tip in dollar amount: ");
        double tipDouble= Convert.ToDouble(ReadLine());
        double totalPrice1 = CalPrice(mealPrice1, tipDouble);
        WriteLine("The meal price is {0:C2}", totalPrice1);
        Write('\n');

        WriteLine("Please enter the meal price in dollar amount:");
        double mealPrice2 = Convert.ToDouble(ReadLine());
        WriteLine("Please enter the tip percentage as a whole number (15% = 15):");
        int tipInt = Convert.ToInt32(ReadLine());
        double totalPrice2 = CalPrice(mealPrice2, tipInt);        
        WriteLine("The meal price is {0:C2}", totalPrice2);
    }
    private static double CalPrice(double mealPrice, double tip)
    {
        double totalPrice = mealPrice + tip;
        return totalPrice;
    }
    private static double CalPrice(double mealPrice, int tip)
    {
        double tipConverted = tip * .01;
        double totalPrice = mealPrice * (tipConverted + 1);
        return totalPrice;
    }

}
