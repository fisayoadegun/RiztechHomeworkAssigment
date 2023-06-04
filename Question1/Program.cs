using Question1;
using System;

class Program
{
    static void Main(string[] args)
    {
        AngleCalculation calculation = new AngleCalculation();
        Console.WriteLine("Enter the hour (0-12):");
        int hours = calculation.GetValidInput(0, 12);

        Console.WriteLine("Enter the minute (0-59):");
        int minutes = calculation.GetValidInput(0, 59);

        double angle = calculation.CalculateAngle(hours, minutes);

        Console.WriteLine($"The lesser angle between the hour and minute hands is: {angle} degrees.");
    }
}