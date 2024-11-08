using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Exception_handling
    {
        static double safe_division(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        //static void Main(string[] args)
        //{
        //    double a = 1, b = 0;
        //    double result;
        //    try
        //    {
        //        result = safe_division(a, b);
        //        Console.WriteLine($"{a} divided by {b} = {result}");
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine("Attempted divide by zero.");
        //        Console.WriteLine(e.StackTrace);
        //    }
        //}
    }
}
