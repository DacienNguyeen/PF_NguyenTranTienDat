using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Loops
    {
        static void tach_ho_ten()
        {
            bool recheck = true;

            while(recheck)
            {
                Console.Write("Input your full name: ");
                string full_name = Console.ReadLine().Trim();

                string[] name_part = full_name.Split(' ');

                if (name_part.Length == 2)
                {
                    Console.WriteLine($"Surname: {name_part[0]}");
                    Console.WriteLine($"Name: {name_part[1]}");
                }
                else if (name_part.Length == 3)
                {
                    Console.WriteLine($"Surname: {name_part[0]}");
                    Console.WriteLine($"Middle name: {name_part[1]}");
                    Console.WriteLine($"Name: {name_part[2]}");
                }
                else if (name_part.Length == 4)
                {
                    Console.WriteLine($"Surname: {name_part[0]}");
                    Console.WriteLine($"Middle name: {name_part[1]} {name_part[2]}");
                    Console.WriteLine($"Name: {name_part[3]}");
                }
                else if (name_part.Length > 4)
                {
                    Console.WriteLine($"Surname: {name_part[0]}");
                    string middle_name = string.Join(" ", name_part,1,name_part.Length - 2);
                    Console.WriteLine($"Middle Name: {middle_name}");
                    Console.WriteLine($"Name: {name_part[^1]}");
                }
                Console.WriteLine("Do u wanna take another one? (Y/N)");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();
                if (keyInfo.KeyChar == 'N' || keyInfo.KeyChar == 'n')
                {
                    recheck = false;
                }
            }
        }

        //static void Main( string[] args )
        //{
        //    tach_ho_ten();
        //    Console.ReadKey();
        //}
    }
}
