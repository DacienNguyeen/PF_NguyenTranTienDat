using System;

internal class Operator
{
    //Write a C# Sharp program to display certain values of the function
    //x = y^2 + 2y + 1 (using integer numbers for y, ranging from - 5 to + 5).

    static void exc2()
    {
        double y, x = 0;
        for (y = -5; y <= 5; y++)
        {

            x = Math.Pow(y, 2) + 2 * y + 1;
            Console.WriteLine($"x = {x}");
        }
    }
    //Write a C# Sharp program that takes distance and time (hours, minutes, seconds)
    //as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
    static void exc3()
    {
        // Function to calculate velocity in kilometers per hour
        double to_km_hour(double kilometers, double meters, int hours, int minutes, int seconds)
        {
            // Convert meters to kilometers and add to total kilometers
            double totalDistanceKm = kilometers + (meters / 1000);

            // Convert time to hours
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Calculate velocity in km/h
            return totalDistanceKm / totalTimeHours;
        }

        // Function to calculate velocity in miles per hour
        double to_mile_hour(double kilometers, double meters, int hours, int minutes, int seconds)
        {
            // Convert kilometers to miles (1 km = 0.621371 miles)
            double totalDistanceMiles = (kilometers + (meters / 1000)) * 0.621371;

            // Convert time to hours
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Calculate velocity in miles/h
            return totalDistanceMiles / totalTimeHours;
        }
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

    //5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
    static void exc5()
    {
        // Input a character
        Console.Write("Input a character: ");
        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();  // New line for readability

        // Correctly initialize the vowel array
        char[] vowel = { 'u', 'e', 'o', 'a', 'i' };

        // Flag to track if the character is a vowel
        bool isVowel = false;

        // Loop to check if the input is a vowel
        for (int i = 0; i < vowel.Length; i++)
        {
            if (vowel[i] == input || vowel[i] == char.ToLower(input))  // Check both lower and uppercase
            {
                isVowel = true;
                break;
            }
        }

        // Output the result based on the input
        if (isVowel)
        {
            Console.WriteLine("Input character is a vowel");
        }
        else if (char.IsDigit(input))
        {
            Console.WriteLine("Input character is a digit");
        }
        else
        {
            Console.WriteLine("Input character is other symbol");
        }
    }

    //static void Main(string[] args)
    //{
    //    exc5();
    //    Console.ReadKey();
    //}
}
