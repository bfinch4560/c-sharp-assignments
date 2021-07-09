using System;
using static System.Console;

class PaintingEstimate
{
    static void Main()
    {
        WriteLine("Enter length of room in feet:");
        int lengthInput = Convert.ToInt32(ReadLine());
        WriteLine("Enter width of room in feet:");
        int widthInput = Convert.ToInt32(ReadLine());

        int totalCost = CalcPaintingCost(lengthInput, widthInput);
        WriteLine("The total cost of this project is: {0:C2}", totalCost);
       /* DisplayPaintingCost(lengthInput, widthInput); */
    }
        private static int CalcPaintingCost(int length, int width)
    {
        int height = 9;
        // I first find the sqaure footage of the 2 walls opposite of each other because they will have the same dimensions. I also determine the price by multiplying the square footage by 6, the given price. 
        int wallPrice = (length * height * 2 * 6);
        // same idea as the previous wall calculations, except using the width instead of length.
        int secondWallPrice = (width * height * 2 * 6);
        // this does not have to be multiplied by 2 because we are only tasked with painting the ceiling, not the floor as well. 
        int ceilingPrice = (length * width * 6);
        int finalPrice = wallPrice + secondWallPrice + ceilingPrice;
        return finalPrice;
    }
}