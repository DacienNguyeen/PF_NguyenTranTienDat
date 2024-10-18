using System;

namespace PF_NguyenTranTienDat
{
    internal class Session_3
    {
        static void ex1()
        {
            //Create a C# program to convert from degrees Celsius to Kelvin and
            //Fahrenheit.Request the user the number of degrees celsius to convert
            do
            {
                double number;
                string cel;
                Console.Write("Input degree in Celcius: ");
                cel = Console.ReadLine();

                if (double.TryParse(cel, out number))
                {
                    if (number < -273.15)
                    {
                        Console.WriteLine("Temperature cannot be below absolute zero (-273.15°C). Please try again.");
                        continue;
                    }
                    Console.WriteLine($"The input Celsius degree = {cel}");
                    double K = number + 273.15; // Use `number` for arithmetic
                    double F = (number * 9 / 5) + 32; // Use `number` for arithmetic
                    Console.WriteLine($"In Kelvin degree = {K}");
                    Console.WriteLine($"In Fahrenheit degree = {F}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input numeric value");
                }
            }
            while (true);
        }
        
        //Create a program in C# for calculate the surface and volume of a sphere, given its radius.
        //- surface= 4 * pi * radius squared
        //- volume= 4 / 3 * pi * radius cubed
        static void ex2()
        {
            do
            {
                double r;
                string r_input;
                Console.Write("Input radius to calculate the surface and volume of a sphere: ");
                r_input = Console.ReadLine();
                
                //Deny strirng, and value equal or smaller than 0
                if(double.TryParse(r_input, out r))
                {
                    if(r <= 0)
                    {
                        Console.WriteLine("radius must be greater than 0");
                        continue;
                    }
                    double surface = 4*Math.PI*Math.Pow(r,2);
                    double volume = 4/3*Math.PI*Math.Pow(r,3);
                    Console.WriteLine($"Surface = {surface}");
                    Console.WriteLine($"Volume = {volume}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input numeric value");
                }    
            }
            while (true);
        }

        static void Main(string[] args) 
        {
            ex2();
            Console.ReadKey();
        }
    }
}
