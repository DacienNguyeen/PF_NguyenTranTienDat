using System;
namespace PF_NguyenTranTienDat
{
    internal class Session_4_Operators
    {
        //1. Write a C# Sharp program that takes two numbers as input and
        // performs an operation(+,-,*, x,/) on them and displays the result of that operation.

        //Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
        // (using integer numbers for y, ranging from -5 to +5).

        static void ex2()
        {
            int y, x = 0;
            for (y = -5; y <= 5; y++)
            {

                x = y * 2 + 2 * y + 1;
            }
            Console.WriteLine($"x = {x}");
        }

        //Write a C# Sharp program that takes distance and time (hours, minutes,
        //seconds) as input and displays speed in kilometers per hour(km/h) and
        //miles per hour(miles/h).

        // Function to calculate velocity in kilometers per hour
        static double to_km_hour(double kilometers, double meters, int hours, int minutes, int seconds)
        {
            // Convert meters to kilometers and add to total kilometers
            double totalDistanceKm = kilometers + (meters / 1000);

            // Convert time to hours
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Calculate velocity in km/h
            return totalDistanceKm / totalTimeHours;
        }

        // Function to calculate velocity in miles per hour
        static double to_mile_hour(double kilometers, double meters, int hours, int minutes, int seconds)
        {
            // Convert kilometers to miles (1 km = 0.621371 miles)
            double totalDistanceMiles = (kilometers + (meters / 1000)) * 0.621371;

            // Convert time to hours
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Calculate velocity in miles/h
            return totalDistanceMiles / totalTimeHours;
        }

        // Main function to execute the program
        static void ex3()
        {
            // Given distance and time values
            double x = 10.5;  // distance in kilometers
            double y = 2768;  // distance in meters
            int a = 2;  // hours
            int b = 37; // minutes
            int c = 48; // seconds

            // Calculate velocities
            double velocity_km_per_hour = to_km_hour(x, y, a, b, c);
            double velocity_mile_per_hour = to_mile_hour(x, y, a, b, c);

            // Display the results
            Console.WriteLine($"Velocity in km/h: {velocity_km_per_hour:F2}");
            Console.WriteLine($"Velocity in miles/h: {velocity_mile_per_hour:F2}");
        }

        static void Main(string[] args)
        {
            ex3();
            Console.ReadKey();
        }
    }
}