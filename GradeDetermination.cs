using System;
using static System.Console;

class Grade
{
    static void Main()
    {
        WriteLine("Enter your score:");
        string inputScore = ReadLine();
        double inputScoreConverted = Convert.ToDouble(inputScore);

        if (inputScoreConverted >= 90.00)
            WriteLine("Your score of {0} earns you a letter grade of {1}", inputScoreConverted, "A" + ", congratulations!");
        else
            if (inputScoreConverted >= 80.00)
            WriteLine("Your score of {0} earns you a letter grade of {1}", inputScoreConverted, "B");
        else
            if (inputScoreConverted >= 70.00)
            WriteLine("Your score of {0} earns you a letter grade of {1}", inputScoreConverted, "C");
        else
            if (inputScoreConverted >= 60.00)
            WriteLine("Your score of {0} earns you a letter grade of {1}", inputScoreConverted, "D");
        else
            WriteLine("Your score of {0} earns you a letter grade of {1}", inputScoreConverted, "F");
       

    }
}
