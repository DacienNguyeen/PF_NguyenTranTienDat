using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PF_NguyenTranTienDat
{
    internal class Session_3
    {
        static void ques1()
        {
            //Create a C# program to convert from degrees Celsius to Kelvin and
            //Fahrenheit.Request the user the number of degrees celsius to convert
            do
            {
                double number; string cel;
                Console.Write("Input degree in Celcius: ");
                cel = Console.ReadLine();

                if (double.TryParse(cel, out number))
                {
                    Console.WriteLine($"The input C = {cel}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input numeric value");
                }
            }
            while (true);
        }
        /// <summary>
        ///         i dom eeaahah
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            ques1 ();
            Console.ReadKey();
        }
    }
}
