using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Exc
{
    internal class PracticeForMidTerm
    {
        //Create a function to check input
        //Expect: 
        static void Main3( string[] args )
        {
            //Console.WriteLine("===Menu===");
            //Console.WriteLine("1. Press 1 to generate a random array");

            //do
            //{
            //    Console.Write("Your choice: ");
            //    string input = Console.ReadLine();
            //    if (IsValid(input, out int intValue))
            //    {
            //        Console.WriteLine($"Your input value is: {intValue}");
            //        break;
            //    }
            //    else if(string.IsNullOrEmpty(input))
            //    {
            //        Console.WriteLine("Make sure input is not null!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Make sure to input integer number!");
            //    }
            //} while (true);
            int IntValue = GetIntegerInput();
            Console.WriteLine($"IntValue = {IntValue}");
        }

        static bool IsValid<T>(string input, out T value) where T : struct
        {
            if (string.IsNullOrEmpty(input))
            {
                value = default(T);
                return false;
            }

            var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
            if (converter != null && converter.IsValid(input))
            {
                value = (T)converter.ConvertFromString(input);
                return true;
            }
            value = default(T);
            return false;
        }

        static int GetIntegerInput()
        {
            Console.Write("Input an integer: ");
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not Null");
                    Console.Write("Try again: ");
                }
                else if (int.TryParse(input, out int intvalue))
                {
                    return intvalue;
                }
                else
                {
                    Console.WriteLine("Integer!");
                    Console.Write("Try again: ");
                }

            } while (true);
        }
    }
}
