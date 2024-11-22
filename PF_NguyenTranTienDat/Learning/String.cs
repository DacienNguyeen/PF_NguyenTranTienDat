using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Learning
{
    internal class String
    {
        static void Main(string[] args)
        {
            DisplayGeneralMenu();
            ExecuteAction();
        }

        static string GenerateName()
        {
            return "0";
        }

        static string GetName()
        {
            do
            {
                Console.Write("Enter full name: ");
                string full_name = Console.ReadLine();

                if(string.IsNullOrEmpty(full_name))
                {
                    Console.WriteLine("It's Null!");
                    continue;
                }

                string[] sub_name = full_name.Split(' ');
                bool isValidName = true;

                foreach (string word in sub_name)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!char.IsLetter(word[i]))
                        {
                            Console.WriteLine("Name cannot contain numbers or special characters.");
                            isValidName = false;
                            break; // Exit the inner loop
                        }
                    }
                    if (!isValidName)
                    {
                        break; // Exit the outer loop if an invalid character was found
                    }
                }
                if (isValidName)
                {
                    return full_name; // Return the valid name
                }

            } while(true);
        }

        private static void ExecuteAction()
        {
            int choice = GetIntegerValue();
            switch(choice)
            {
                case 1:
                    GotoNameSeperater();
                    break;
                case 2:
                    break;
                case 3:
                    return;
            }
        }

        private static void GotoNameSeperater()
        {
            Console.WriteLine("Do you want to input a full name or generate one?");
            Console.WriteLine("1. To input, press 1");
            Console.WriteLine("2. To generate, press 2");

            int direction = GetIntegerValue();

            switch (direction)
            {
                case 1:
                    string M_FullName = GetName();
                    M_FullName = NormalizeName(M_FullName);
                    Console.WriteLine($"Full name: {M_FullName}");
                    break;
                case 2:
                    string G_FullName = GenerateName();
                    break;

            }
        }

        private static string NormalizeName(string m_FullName)
        {
            m_FullName = m_FullName.Trim();

        }

        private static int GetIntegerValue()
        {
            Console.Write("Input an integer: ");
            do
            {
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Null input!");
                }
                else if(int.TryParse(input, out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Make sure it an integer!");
                }
            }while(true);
        }

        private static void DisplayGeneralMenu()
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Seperate name");
            Console.WriteLine("2. Concate name");
            Console.WriteLine("3. Exit");
            Console.Write("Your selected action <1...3>, ");
        }

        private static void GetFullName()
        {

        }

        static void SeperateName()
        {
        }
    }
}
