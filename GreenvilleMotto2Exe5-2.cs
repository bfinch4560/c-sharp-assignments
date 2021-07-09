using System;
using static System.Console;

class GreenvilleMotto2
{
    static void Main()
    {
       

        WriteLine("Enter motto for Greenville:");
        string mottoInput = ReadLine();
        int numberChar = Convert.ToInt32(mottoInput.Length);
        WriteLine('\n');

        for (int x=-1; x<=numberChar; ++x)
        {
            Write("*");
        }

        Write('\n');
        Write("*"+ mottoInput + "*");
        Write('\n');

        for (int x = -1; x <= numberChar; ++x)
        {
            Write("*");
        }
        WriteLine('\n');


    }
}