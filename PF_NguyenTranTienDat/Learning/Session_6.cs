using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Session_6
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("How many item(s) will be in your array? ");
        //    int N = int.Parse(Console.ReadLine());
        //    int[] a = new int[N];
        //    //manually_input_array(a, N);
        //    randomize_element_array(a, N);
        //    print_array(a);
        //    Console.WriteLine(sum_array(a));
        //    increase_value(a, 2);
        //    print_array(a);
        //    Console.WriteLine(sum_array(a));
        //}

        static void manually_input_array(int[]a, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter value for the #{i + 1} element: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void randomize_element_array(int[]a, int N)
        {
            Random random = new Random();
            for(int i = 0;i < N; i++)
            {
                a[i] = random.Next(100);
            }
        }

        static void print_array(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1)  // Check the index, not the value
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        static void increase_value(int[]a, int value)
        {
            for(int i =0;i<a.Length;i++)
            {
                a[i] += value;
            }
        }

        static int sum_array(int[]a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
