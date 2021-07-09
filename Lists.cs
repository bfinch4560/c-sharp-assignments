using System;
using static System.Console;
using System.Collections.Generic;

class List
{
    static void Main()
    {
        List <int> itemNumber = new List <int> {101, 108, 201, 213, 266, 304, 511, 409, 411, 412 };
        WriteLine("Please enter item number");
        int itemInput = Convert.ToInt32(ReadLine());

        int x = itemNumber.IndexOf(itemInput);  

          while (itemInput != 0)
         {
             if (x >= 0)
             {
                 WriteLine("The item is found");
                 WriteLine("Please enter item number or type 0 to exit");
                 itemInput = Convert.ToInt32(ReadLine());
                 x = itemNumber.IndexOf(itemInput);
            }
             else if (x == -1)
             {
                 WriteLine("Item not found and backordered");
                 itemNumber.Add(itemInput);
                 WriteLine("Please enter item number or type 0 to exit");
                 itemInput = Convert.ToInt32(ReadLine());
                 x = itemNumber.IndexOf(itemInput);
            }

         } 

    }
}
