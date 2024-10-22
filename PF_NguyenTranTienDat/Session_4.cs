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
            int y, x;
            for (y = -5; y <= 5; y++)
            {
                x = y2 + 2y + 1;
            }
            Console.WriteLine($"x = {x}");
        }
        static void Main(string[] args)
        {
            ex2();
            Console.ReadKey();
        }
    }
}