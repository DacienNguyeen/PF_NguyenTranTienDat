using System;
using System.ComponentModel;
using System.Security.Cryptography;

internal class Flow
{
    //Write a C# Sharp program to check whether a given number is even or odd.
    static void Exc1()
    {
        Console.Write("Input a number to check if it is even or odd: ");
        double num_input = double.Parse(Console.ReadLine());
        if(num_input % 2 == 0 )
        {
            Console.WriteLine("It's even");
        }
        else if (num_input % 2 == 1)
        {
            Console.WriteLine("It's odd");
        }
        else
        {
            Console.WriteLine("Can't determine, make sure to enter integer to check");
        }
    }

    //2. Write a C# Sharp program to find the largest of three numbers.
    static void Exc2()
    {
        Console.Write("Input numbers seperated by 'blank space' or 'comma' to find the largest one: ");
        string input = Console.ReadLine();
        
        string[] nums_input = input.Split(new char[] { ',', ' '},StringSplitOptions.RemoveEmptyEntries);
        double[] nums = new double[nums_input.Length];

        for(int i = 0; i < nums_input.Length; i++)
        {
            nums[i] = double.Parse(nums_input[i]);
        }

        double max = 0;
        for(int i = 0;i < nums_input.Length; i++)
        {
            if(max <= nums[i])
            {
                max = nums[i];
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }

    //Write a C# Sharp program to accept a coordinate point in an XY coordinate system
    //and determine in which quadrant the coordinate point lies.
    static void Exc3()
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
            if (y > 0)
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

        else if (x == 0 && y == 0)
        {
            Console.WriteLine("The coordinate point lies exactly in the origin (0;0)");
        }
        else
        {
            if (y > 0)
            {
                Console.WriteLine($"the coordinate point lies ({x};{y}) in the second quadrant");
            }
            if (y < 0)
            {
                Console.WriteLine($"the coordinate point lies ({x};{y}) in the third quadrant");
            }
        }
    }

    //1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
    static void Exc1_p2()
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
            if (Math.Round(Math.Pow(longestEdge, 2), 2) == Math.Round(Math.Pow(otherEdge1, 2) + Math.Pow(otherEdge2, 2), 2))
            {
                if (otherEdge1 == otherEdge2)
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

            if (otherEdge2 == otherEdge1)
            {
                if (otherEdge2 == longestEdge)
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

            if (otherEdge2 != otherEdge1 && otherEdge2 != longestEdge && Math.Pow(longestEdge, 2) != Math.Pow(otherEdge1, 2) + Math.Pow(otherEdge2, 2))
            {
                Console.WriteLine("The triangle is a Scalene.");
                break;
            }
        }
    }

    //2. Write a program to read 10 numbers and find their average and sum.
    static void Exc2_p2()
    {
        double[] array = new double[10];
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Input 10 numbers, separated by 'blank space' or 'comma' to find average and sum: ");
            string input = Console.ReadLine();

            // Splitting
            string[] arrayStrings = input.Split(new char[] { ' ', ',', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);


            if (arrayStrings.Length != 10)
            {
                Console.WriteLine("Please input exactly 10 values. Try again.");
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
                        Console.WriteLine($"Value at index {i + 1} (= {arrayStrings[i]}) is invalid. Please enter numeric values only. Try again.");
                        break; // Exit the inner loop if an invalid input is found
                    }
                    else
                    {
                        sum_arr += array[i];
                    }
                }

                // Calculate and print average if all inputs are valid
                if (isValid)
                {
                    double avg_arr = sum_arr / array.Length;
                    Console.WriteLine($"Sum = {sum_arr}");
                    Console.WriteLine($"Average = {avg_arr}");
                    validInput = true; // Set validInput to true to exit the outer loop
                }
            }
        }
    }

    //3. Write a program to display the multiplication table of a given integer.
    static void Exc3_p2()
    {
        Console.Write("Input an integer to display its multiplication table: ");
        int num = int.Parse( Console.ReadLine() );
        Console.Write("What's the range do you want to end the table? (e.g: given integer * 10 -> enter: 10): ");
        int end = int.Parse( Console.ReadLine() );

        for (int i = 0;i < end;i++)
        {
            Console.WriteLine($"{num}*{i+1}={num*(i+1)}");
        }
    }

    //4. Write a program to display a pattern like triangles with a number.
    static void Exc4_5_p2()
    {
        bool isValid = true;
        while (isValid)
        {
            Console.Write("Input a number to generate triangle patterns: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 1) 
            { 
                isValid = false;
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
                for (int i = 1;i <= num; i++)
                {
                    for(int j = 1+i; j <= i+1; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Make sure the number is positively larger than 1");
            }
        }
    }

    //Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
    static void Exc6_p2()
    {
        Console.WriteLine("This is a program to display the n terms of harmonic series " +
            "and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms");
        Console.Write("Input n terms: ");
        int n = int.Parse( Console.ReadLine() );
        double sum = 0;

        for(int i = 0;i<n;i++)
        {
            sum = sum + 1.0/(i+1);
            if (i == n - 1)
            {
                Console.Write($"1/{i + 1}");
            }
            else
            {
                Console.Write($"1/{i + 1} + ");
            }
        }
        Console.Write($" = {sum}");
    }

    //Write a program to find the ‘perfect’ numbers within a given number range.
    //perfect number, a positive integer that is equal to the sum of its proper divisors.
    static void Exc7_p2()
    {
        //input a number range
        //check whether is positive -> if positive -> continue -> finding its proper divisors -> if sum of its proper divisors = itself -> Save it to an array
        //                          -> else -> skip                                           -> else -> skip to next number till the end                                               

        Console.Write("Input a number range (seperated by commas or blank space) to find its 'perfect' numbers: ");
        string input = Console.ReadLine();

        string[] input_range = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double[] num_range = new double[input_range.Length];

        for(int i = 0 ; i < input_range.Length; i++)
        {
            num_range[i] = double.Parse( input_range[i] );
        }

        List<List<int>> divisorsList = new List<List<int>>();
        List<int> divisorSums = new List<int>(); // To store the sum of divisors for each number

        for (int i = 0 ;i < num_range.Length ; i++)
        {
            // Initialize a new list to store divisors for the current number
            List<int> divisors = new List<int>();
            int sum = 0; // Variable to accumulate the sum of divisors
            if (num_range[i] >= 0)
            {
                for (int j = 1; j <= num_range[i]/2; j++)
                {
                    if(num_range[i] % j ==0)
                    {
                        divisors.Add(j); // Add divisor to the list
                        sum += j;         // Add divisor to the sum
                    }
                }
            }
            
            else
            {
                continue;
            }

            divisorsList.Add(divisors); // Add the divisors list for the current number to divisorsList
            divisorSums.Add(sum); // Add the sum of divisors to divisorSums list
        }

        for (int i = 0; i < divisorsList.Count; i++)
        {
            if (num_range[i] == divisorSums[i])
            {
                string divisorsString = string.Join(" + ", divisorsList[i]);
                Console.WriteLine($"The 'perfect' number is {num_range[i]} at index {i} as {divisorsString} = {num_range[i]}");
            }
        }
    }

    //8. Write a program to determine whether a given number is prime or not.
    static void Exc8_p2()
    {
        Console.Write("Input a number to check if it is prime: ");
        double num = double.Parse(Console.ReadLine());
        int count = 0;

        if( num > 0 )
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine($"The given number {num} is prime");
            }
            else
            {
                Console.WriteLine($"The given number {num} is not prime");
            }
        }
        else
        {
            Console.WriteLine("Make sure to enter the number positive");
        }
    }

    //static void Main( string[] args )
    //{
    //    Exc4_5_p2();
    //    Console.ReadKey();
    //}
}
