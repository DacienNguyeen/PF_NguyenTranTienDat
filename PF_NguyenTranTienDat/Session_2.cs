using System;
using System.Security.Cryptography;

class InAndOut
{
    //Add and multiple two integer
    static void ques1()
    {
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());

        var sum = a + b;
        var mul = a * b;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {mul}");
    }
    //swap value of 2 integers
    static void ques2()
    {
        int T;
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());
        T = a;
        a = b;
        b = T;
        Console.WriteLine($"New value of a: {a}");
        Console.WriteLine($"New value of b: {b}");
    }
    //multiple two float numbers
    static void ques3()
    {
        Console.Write("Enter value for a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        float b = float.Parse(Console.ReadLine());
        var mul = a * b;
        Console.WriteLine($"Product: {mul}");
    }
    //Convert Foot to meter 
    static void ques4()
    {
        Console.Write("Enter feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for inches input
        Console.Write("Enter inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double feetToMeters = feet * 0.3048;
        double inchesToMeters = inches * 0.0254;

        // Total meters calculation
        double totalMeters = feetToMeters + inchesToMeters;

        // Output the result
        Console.WriteLine("Total meters: " + totalMeters);
    }

    //convert Celsius to Fahrenheit and vice versa
    static void ques5()
    {
        // Local function to convert Celsius to Fahrenheit
        void ConvertCelsiusToFahrenheit()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }

        // Local function to convert Fahrenheit to Celsius
        void ConvertFahrenheitToCelsius()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: " + celsius);
        }

        // Prompt the user to choose conversion type
        Console.WriteLine("Choose the type of conversion:");
        Console.WriteLine("1: Celsius to Fahrenheit");
        Console.WriteLine("2: Fahrenheit to Celsius");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Call the respective conversion functions based on the choice
        if (choice == 1)
        {
            ConvertCelsiusToFahrenheit();
        }
        else if (choice == 2)
        {
            ConvertFahrenheitToCelsius();
        }
        else
        {
            Console.WriteLine("Invalid choice, please select 1 or 2.");
        }
    }

    // find the Size of data types
    static void ques6()
    {
        Console.WriteLine("Size of Value Types:");
        Console.WriteLine("int: " + sizeof(int) + " bytes");
        Console.WriteLine("double: " + sizeof(double) + " bytes");
        Console.WriteLine("float: " + sizeof(float) + " bytes");
        Console.WriteLine("char: " + sizeof(char) + " bytes");
        Console.WriteLine("bool: " + sizeof(bool) + " bytes");
        Console.WriteLine("byte: " + sizeof(byte) + " bytes");
        Console.WriteLine("short: " + sizeof(short) + " bytes");
        Console.WriteLine("long: " + sizeof(long) + " bytes");
        Console.WriteLine();
    }
    //Print ASCII Value
    static void ques7()
    {
        // Prompt the user for a character
        Console.Write("Enter a character: ");
        char inputChar = Convert.ToChar(Console.ReadLine());

        // Convert the character to its ASCII value
        int asciiValue = Convert.ToInt32(inputChar);

        // Print the ASCII value
        Console.WriteLine("The ASCII value of '" + inputChar + "' is: " + asciiValue);
    }

    //Calculate Area of a Circle
    static int ques8()
    {
        // Local function without 'static' to calculate the area of a circle
        double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        // Prompt user for radius
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        // Call the local function to calculate the area
        double area = AreaOfCircle(radius);

        // Display the result
        Console.WriteLine($"Area of circle: {area}");

        return 0; // Since ques8 has a return type of int
    }

    //Calculate Area of a Square
    static int ques9()
    {
        // Local function without 'static' to calculate the area of a square
        double AreaOfSquare(double s)
        {
            return Math.Pow(s, 2);
        }

        // Prompt user for radius
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine());

        // Call the local function to calculate the area
        double area = AreaOfSquare(side);

        // Display the result
        Console.WriteLine($"Area of Square: {area}");

        return 0; // Since ques8 has a return type of int
    }
    static void ques10()
    {
        Console.Write("Enter the number of days: ");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDaysAfterYears = totalDays % 365;
        int weeks = remainingDaysAfterYears / 7;
        int days = remainingDaysAfterYears % 7;

        Console.WriteLine($"{totalDays} days is equivalent to {years} years, {weeks} weeks, and {days} days.");
    }
    //static void Main(string[] args)
    //{
    //    ques10();
    //    Console.ReadKey();
    //}
}
