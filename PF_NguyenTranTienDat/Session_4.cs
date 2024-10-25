using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
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
            double y, x = 0;
            for (y = -5; y <= 5; y++)
            {

                x = Math.Pow(y,2) + 2 * y + 1;
                Console.WriteLine($"x = {x}");
            }
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

        //5. Write a C# Sharp program that takes a character as input and checks if it
        //is a vowel, a digit, or any other symbol.
        static void ex5()
        {
            //Step - by - Step Breakdown:
            //Take input from the user: We will ask the user to input a single character.
            //Check if the character is a vowel: Vowels include 'a', 'e', 'i', 'o', 'u' and their uppercase equivalents.
            //Check if the character is a digit: We can use the built -in Char.IsDigit() method to check if the input is a digit.
            //Check if it's another symbol: If the character is not a vowel or a digit, we'll classify it as "other symbol."
            Console.Write("Input a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();   
            char[] vowel = { 'u', 'e', 'o', 'a', 'i' };

            // Flag to track if the character is a vowel
            bool isVowel = false;

            // Loop to check if the input is a vowel
            for(int i = 0; i < vowel.Length; i++)
            {
                if(vowel[i] == input || vowel[i]==char.ToLower(input))
                {
                    isVowel=true;
                    break;
                }
            }

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

        //Write a C# Sharp program to accept a coordinate point in an XY
        //coordinate system and determine in which quadrant the coordinate
        //point lies.
        static void ques3_flow()
        {
            Console.Write("Enter coordinates (X;Y) -> X = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinates (X;Y) -> Y = ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine($"the coordinate point lies ({x};{y}) in the first quadrant");
                }
                else
                {
                    Console.WriteLine($"the coordinate point lies ({x};{y}) in the fourth quadrant");
                }
            }
            else if (x == 0 && y != 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("it will lies in the head of y axis");
                }
                else
                {
                    Console.WriteLine("it will lies in the tail of y axis");
                }
            }

            else if (x != 0 && y == 0)
            {
                if (x > 0)
                {
                    Console.WriteLine("it will lies on the right of x axis");
                }
                else
                {
                    Console.WriteLine("it will lies on the left of x axis");
                }
            }

            else if (x == 0 && y ==0)
            {
                Console.WriteLine("The coordinate point lies exactly in the origin (0;0)");
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine($"the coordinate point lies ({x};{y}) in the second quadrant");
                }
                if(y < 0)
                {
                    Console.WriteLine($"the coordinate point lies ({x};{y}) in the third quadrant");
                }
            }
        }

        //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        static void ques1_flow_p2()
        {
            ////Choose input options
            //Console.WriteLine("Choose input option to check a triangle");
            //Console.WriteLine("Press 1, to input 3 edge lengths");
            //Console.WriteLine("Press 2, to input 2 edge lengths and 1 angle");
            //Console.WriteLine("Press 3, to input 1 edge length and 2 angles");

            //static double GetTriangleSides2(double a, double b, double angleC)
            //{

            //}

            //static double GetTriangleSides3(double sideA, double angleA, double angleB)
            //{

            //}

            while (true)
            {
                Console.Write("Input the lengths of 3 edges seperated by commas (,), spaces (  ), or semicolons (;): ");
                string input = Console.ReadLine();

                //splitting
                string[] edgeStrings = input.Split(new char[] { ' ', ',', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                //Check if 3 values are provides
                if (edgeStrings.Length != 3)
                {
                    Console.WriteLine("Please provide exactly 3 edge lengths!");
                    continue;
                }

                //Try to parse the input as positive numeric values
                double[] edges = new double[3];
                bool isValid = true;

                for (int i = 0; i < edgeStrings.Length; i++)
                {
                    if (!double.TryParse(edgeStrings[i], out edges[i]) || edges[i] <= 0)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Ensure all values are positive numbers and numeric");
                    continue;
                }

                double longestEdge = Math.Max(edges[0], Math.Max(edges[1], edges[2]));

                double otherEdge1, otherEdge2;

                // Determine which two are the other edges
                if (longestEdge == edges[0])
                {
                    otherEdge1 = edges[1];
                    otherEdge2 = edges[2];
                }
                else if (longestEdge == edges[1])
                {
                    otherEdge1 = edges[0];
                    otherEdge2 = edges[2];
                }
                else
                {
                    otherEdge1 = edges[0];
                    otherEdge2 = edges[1];
                }

                // Check the Pythagorean theorem: longestEdge^2 == otherEdge1^2 + otherEdge2^2
                if (Math.Round(Math.Pow(longestEdge, 2),2) == Math.Round(Math.Pow(otherEdge1, 2) + Math.Pow(otherEdge2, 2),2))
                {
                    if(otherEdge1 == otherEdge2)
                    {
                        Console.WriteLine("The triangle is a right Isoscele.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The triangle is a right triangle.");
                        break;
                    }
                }

                if(otherEdge2 == otherEdge1)
                {
                    if(otherEdge2 == longestEdge)
                    {
                        Console.WriteLine("The triangle is Equilateral.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The triangle is an Isoscele.");
                        break;
                    }
                }
                
                if(otherEdge2 != otherEdge1 &&  otherEdge2 != longestEdge && Math.Pow(longestEdge, 2) != Math.Pow(otherEdge1, 2) + Math.Pow(otherEdge2, 2))
                {
                    Console.WriteLine("The triangle is a Scalene.");
                    break;
                }
            } 
        }

        //read 10 num as an array and find avg and sum
        static void ex3_flow()
        {
            Console.Write("Input an array of numbers separated by commas (,), spaces (  ), or semicolons (;): ");
            string input = Console.ReadLine();

            // Splitting
            string[] arrayStrings = input.Split(new char[] { ' ', ',', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            double[] array = new double[arrayStrings.Length];

            if (arrayStrings.Length > 10)
            {
                Console.WriteLine("The array cannot contain more than 10 values");
            }
            else
            {
                    // Read values and check for blank or non-numeric inputs
                    bool isValid = true;
                    double sum_arr = 0;
                    for (int i = 0; i < arrayStrings.Length; i++)
                    {
                        // Check if the string is empty or cannot be parsed as a double
                        if (string.IsNullOrEmpty(arrayStrings[i]) || !double.TryParse(arrayStrings[i], out array[i]))
                        {
                            isValid = false;
                            Console.WriteLine($"value in order {i} = {arrayStrings[i]} is Invalid: Please enter a numeric value.");
                        }
                        else
                        {
                            sum_arr += array[i];
                        }
                    }

                    // Calculate and print average if all inputs are valid
                    if (isValid)
                    {
                        double avg_arr = sum_arr / arrayStrings.Length;
                        Console.WriteLine($"sum = {sum_arr}");
                        Console.WriteLine($"average = {avg_arr}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input detected. Please try again.");
                    }
            }
        }

        static void Main(string[] args)
        {
            ex3_flow();
            Console.ReadKey();
        }
    }
}