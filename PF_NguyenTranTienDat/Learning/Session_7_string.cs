using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Session_7_string
    {
        //static void Main(string[] args)
        //{
        //    string input = GetInputString();
        //    PrintString(input);
        //}

        static string GetInputString()
        {
            Console.Write("Enter your full name: ");
            string inputString = Console.ReadLine();
            inputString = inputString.Trim();
            return inputString;
        }

        static void PrintString(string inputString)
        {
            Console.WriteLine(inputString);
        }

    }
}
