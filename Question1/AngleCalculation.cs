using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class AngleCalculation
    {
        public int GetValidInput(int min, int max)
        {
            int input;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input) && input >= min && input <= max)
                    break;

                Console.WriteLine($"Invalid input! Please enter a number between {min} and {max}.");
            }
            return input;
        }

        public double CalculateAngle(int hours, int minutes)
        {
            const int DegreesPerHour = 30;
            const int DegreesPerMinute = 6;
            const int MinutesPerHour = 60;

            double hourAngle = (hours % 12 + (double)minutes / MinutesPerHour) * DegreesPerHour;
            double minuteAngle = minutes * DegreesPerMinute;

            double angle = Math.Abs(hourAngle - minuteAngle);
            return Math.Min(angle, 360 - angle);
        }
    }
}
