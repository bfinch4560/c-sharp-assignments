using System;
using static System.Console;

class typingGrade
{
    static void Main()
    {
        int[] wordsPerMinuteLow = {20, 40, 60, 80, 81 };
        char[] grade = { 'F', 'D', 'C', 'B', 'A' };
        char gradeOutput = 'o';

        WriteLine("Enter student's words per minute:");
        int wpmInput = Convert.ToInt32(ReadLine());

        for (int i=wordsPerMinuteLow.Length-1; i >= 0; --i)
        {
            if (wpmInput <= wordsPerMinuteLow[i])
                gradeOutput = grade[i];
        }
        WriteLine("The letter grade for that WPM is: " + gradeOutput);

    }
}
