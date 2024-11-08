using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Session_5
    {
        //Exc1
        static double max(params double[] data)
        {
            double maxva = 0;
            foreach (var item in data)
            {
                if (item > maxva)
                {
                    maxva = item;
                }
            }
            return maxva;
        }

        //Exc2
        static double factorial(int num)
        {
            double factorial = 1;
            for (int i = num; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        //Exc3
        //Write a C# function that takes a number as a parameter and checks whether the number is prime or not.

        static bool IsPrime(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
            //Check one-way out
        }

        //Write a C# function to print 1. all prime numbers that less than a number (enter prompt keyboard). 2. the first N prime numbers
        // require 1 array, 1 barrier number, Limit with 5 numb

        static int[] GetPrime(int n, int N, params int[] data)
        {
            List<int> prime = new List<int>();
            for(int i = 0; i < N && i < data.Length; i++)
            {
                if (data[i] < n && IsPrime(data[i]))
                {
                    prime.Add(data[i]);
                }
            }
            return prime.ToArray();
        }

        //5. Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.

        static bool IsPerfect(int num)
        {
            int sum = 0;
            for(int i = 1; i <= num/2; i++)
            {
                if(num%i == 0)
                {
                    sum += i;
                }
            }
            if(sum == num)
                return true;
            else 
                return false;
        }

        //Write a C# function to check whether a string is a pangram or not.
        static bool IsPangram(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            input = input.Trim();
            input = input.ToLower();

            //method 1
            //for(char letter = 'a';  letter <= 'z';letter++)
            //{
            //    if (!input.Contains(letter))
            //    {
            //        return false;
            //    }
            //}

            bool[] letter_presence = new bool[26];
            foreach(char ch in input)
            {
                if(ch >= 'a' &&  ch <='z')
                {
                    letter_presence[ch - 'a'] = true;
                }
            }

            for(int i = 0;i < letter_presence.Length;i++)
            {
                if(!letter_presence[i])
                {
                    return false ;
                }
            }
            return true;
        }

        //static void Main(string[] args)
        //{
        //    //double[] a = { 4, 56, 12, 34, 23, 123, 0 };
        //    //double max_value = a.Max();
        //    double max_value = max(4, 56, 12, 34, 23, 123, 0);
        //    Console.WriteLine(max_value);
        //    double factorial_value = factorial(10);
        //    Console.WriteLine(factorial_value);
        //    int num = 6;
        //    bool check_prime = IsPrime(num);
        //    bool check_perfect = IsPerfect(num);
        //    Console.WriteLine(check_prime);
        //    Console.WriteLine(check_perfect);
        //    int[] a = { 4, 56, 12, 34, 23, 11, 123, 0 };
        //    int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        //    int[] a_prime = GetPrime(30, 6, a);
        //    for (int i = 0; i < a_prime.Length; i++)
        //    {
        //        Console.Write($"{a_prime[i]} ");
        //    }
        //    Console.WriteLine();

        //    for (int i = 1; i < 1000; i++)
        //    {
        //        if (IsPerfect(i))
        //        {
        //            Console.Write($"{i} ");
        //        }
        //    }
        //    Console.WriteLine();
        //    string testString = "The quick brown fox jumps over the laz dog";
        //    Console.WriteLine(IsPangram(testString));
        //}
    }

}
