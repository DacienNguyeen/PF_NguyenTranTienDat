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
        static void Main5(string[] args)
        {
            PrintString(TestString1());
            Console.WriteLine($"Length of test tring is: {GetStringLength(TestString1())}");
            SeperateChar(TestString1());
            Console.WriteLine();
            SeperateCharReversed(TestString1());
            Console.WriteLine();
            PrintTotalWords(TestString1());
            Console.WriteLine();
            PrintString(TestString2());
            Console.WriteLine();
            CountAlDiSpeChar(TestString1());
            Console.WriteLine();
            CountVowelOrConsonant(TestString1(), 1);
            Console.WriteLine();
            CheckPresence(TestString1(), "Dacien");
            Console.WriteLine();
            SearchPositionOfSubstring(TestString1(), "acien");
            Console.WriteLine();
            char c = 'I';
            IsLetterAndCaseType(c);
            Console.WriteLine($"The appearance times of \"ee\" in \"Dacieenn Nguyeen1904\" is: {GetAppearanceTimes(TestString1(), "ee")}");

            Console.WriteLine(InsertB4FirstOccurrence(TestString1(),"Dacien","very"));//need debugging
        }

        static string TestString1()
        {
            string input = /*"Hi there, my name is Dacien. I am a K49 sophomore at UEH university. Nice to meet you!";*/ "Dacieenn Nguyeen1904";
            return input;
        }

        static string TestString2()
        {
            string input = "dacien Nguyeen";
            return input;
        }

        static void PrintString(string input)
        {
            Console.WriteLine(input);
        }

        static void SeperateChar(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + "\t");
            }
        }
        static void SeperateCharReversed(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + "\t");
            }
        }
        static int GetStringLength(string input)
        {
            int l = 0;
            foreach (char c in input) l++;
            return l;
        }

        static void PrintTotalWords(string input)
        {
            NormalizeName(input);
            string[] Words = input.Split(' ');
            Console.WriteLine(Words.Length);
        }

        static void CompareTwoStrings(string input1, string intput2)
        {

        }

        static void CountAlDiSpeChar(string input)
        {
            int letter = 0;
            int digit = 0;
            int SpeChar = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letter++;
                }
                else if (char.IsDigit(input[i]))
                {
                    digit++;
                }
                else
                {
                    SpeChar++;
                }
            }
            Console.WriteLine($"Number of letter: {letter}");
            Console.WriteLine($"Number of digit: {digit}");
            Console.WriteLine($"Number of special character: {SpeChar}");
        }

        static void CountVowelOrConsonant(string input, int choice)
        {
            input = input.ToLower();
            char[] vowels = { 'u', 'e', 'o', 'a', 'i' };
            int vowel_count = 0;
            int consonant_count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    foreach (char vowel in vowels)
                    {
                        if (char.Equals(input[i], vowel))
                            vowel_count++;
                        else
                            consonant_count++;
                    }
                }
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Number of vowel is: {vowel_count}");
                    break;
                case 2: //consonant
                    Console.WriteLine($"Number of consonant is: {consonant_count}");
                    break;
            }
        }

        static void CheckPresence(string input, string substring)
        {
            Console.WriteLine(DoesPresent(input, substring));
        }

        static void SearchPositionOfSubstring(string input, string substring)
        {
            if (DoesPresent(input, substring))
            {
                Console.WriteLine($"Position: (Index, Length) = ({input.IndexOf(substring[0])},{substring.Length})");
            }
            else { Console.WriteLine($"Position: (Index, Length) = (-1;{substring.Length})"); }
        }

        static void IsLetterAndCaseType(char c)
        {
            bool IsLetter = false;
            if (char.IsLetter(c))
            {
                IsLetter = true;
                if (char.Equals(c, char.ToUpper(c)))
                {
                    Console.WriteLine($"{c} is an alphabet? {IsLetter} and has upper case");
                }
                else if (char.Equals(c, char.ToLower(c)))
                {
                    Console.WriteLine($"{c} is an alphabet? {IsLetter} and has lower case");
                }
            }
            else
                Console.WriteLine($"{c} is an alphabet? {IsLetter}");
        }

        static bool DoesPresent(string input, string substring)
        {
            if (input.Contains(substring))
                return true;
            return false;
        }

        static int GetAppearanceTimes(string input, string substring)
        {
            int appearanceTimes = 0;
            int index = input.IndexOf(substring);

            // Continue searching while the substring can still be found
            while (index != -1)
            {
                appearanceTimes++;
                // Move the index to the character after the current found substring
                index = input.IndexOf(substring, index + substring.Length);
            }

            return appearanceTimes;
        }

        static string InsertB4FirstOccurrence(string input, string target, string substring)
        {
            int index = input.IndexOf(target);
            if(index == -1)
            {
                return input;
            }

            return input.Substring(0, index) + substring + input.Substring(index);
        }

        //--------------------//
        static string GenerateFullName()
        {
            return "0";
        }
        static string GetFullName()
        {
            do
            {
                Console.Write("Enter full name: ");
                string full_name = Console.ReadLine();

                if (string.IsNullOrEmpty(full_name))
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

            } while (true);
        }

        private static void ExecuteAction()
        {
            int choice = GetIntegerValue();
            switch (choice)
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
                    string M_FullName = GetFullName();
                    M_FullName = NormalizeName(M_FullName);
                    Console.WriteLine($"Full name: {M_FullName}");
                    break;
                case 2:
                    string G_FullName = GenerateFullName();
                    break;
            }
        }

        private static string NormalizeName(string m_FullName)
        {
            m_FullName = m_FullName.Trim();
            //Replace '  ' with ' ' if length = 1 break (normalize space among words)

            while (m_FullName.IndexOf("  ") != -1)
            {
                m_FullName = m_FullName.Replace("  ", " ");
            }

            //Normalize each word. Tolower all char of word, ToUpper every first letter of word
            string[] NameSub = m_FullName.Split(" ");
            string Result = "";
            for (int i = 0; i < NameSub.Length; i++)
            {
                string FirstChar = NameSub[i].Substring(0, 1);
                string OtherChar = NameSub[i].Substring(1);
                NameSub[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                Result += NameSub[i] + " ";
            }
            return Result;
        }

        private static int GetIntegerValue()
        {
            Console.Write("Input an integer: ");
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Null input!");
                }
                else if (int.TryParse(input, out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Make sure it an integer!");
                }
            } while (true);
        }

        private static void DisplayGeneralMenu()
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Seperate name");
            Console.WriteLine("2. Concate name");
            Console.WriteLine("3. Exit");
            Console.Write("Your selected action <1...3>, ");
        }

        static void SeperateName()
        {

        }
    }
}
