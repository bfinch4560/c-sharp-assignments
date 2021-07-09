using System;
using static System.Console;

class Admission
{
    static void Main()
    {
        WriteLine("Enter high school GPA");
        double gpaInput = Convert.ToDouble(ReadLine());
        WriteLine("Enter admission test score:");
        int testScoreInput = Convert.ToInt32(ReadLine());
        string decision = MakeDecision(gpaInput, testScoreInput);
        WriteLine(decision);
    }
    private static string MakeDecision(double gpa, int testScore)
    {
        string admissionStatus;
        if (gpa >= 3.2 && testScore >= 70)
            return admissionStatus = "Accept";
        else if (gpa < 3.2 && testScore >= 80)
            return admissionStatus = "Accept";
        else
            return admissionStatus = "Reject";
    }
}
