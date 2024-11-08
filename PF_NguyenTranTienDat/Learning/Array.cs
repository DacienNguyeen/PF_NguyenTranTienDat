using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Diagnostics.Metrics;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Array
    {
        //to test if an array contains a specific value.
        static bool contain(int[] a, int key)
        {
            int[] a_sorted = a.OrderBy(x => x).ToArray();
            int min = 0, max = a.Length - 1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if(key == a_sorted[mid])
                {
                    return true;
                }
                else if(key > a_sorted[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return false;
        }

        //to find the index of an array element.
        static int find_index (int[] a, int key, int return_type)
        {
            switch(return_type)
            {
                //array starting from 1
                case 1:
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == key)
                        {
                            return ++i;
                        }
                    }
                    return -1;
                //array starting from 0
                case 0:
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == key)
                        {
                            return i;
                        }
                    }
                    return -1;
                default:
                    return -1;
            }
        }
        //to remove a specific element from an array
        //static int[] remove_element(int[] a, int idx)
        //{
            
        //}

        static void test_data()
        {
            int[] a = { 1, 6, 4, 6, 2, 3, 9, 10, 12, 11, 16, 20, 1, 2, 18, 19 };
            int val = 19;
            bool find_val = contain(a, val);
            Console.WriteLine($"Value to check if containing: {val}");
            Console.Write(find_val);
            int idx = find_index(a, val, 0);
            Console.WriteLine(idx);
        }

        static void jagged_array_exc1()
        {
            int[][] jagged_a = new int[4][] { // Corrected size to 4
                new int[] {1, 1, 1, 1, 1},
                new int[] {2, 2},
                new int[] {3, 3, 3, 3},
                new int[] {4, 4}
            };
            for (int i = 0; i < jagged_a.Length; i++)
            {
                for (int j = 0; j < jagged_a[i].Length; j++)
                {
                    Console.Write(jagged_a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        //2. Create a Jagged Array with random integer numbers(or by user input) by getting the
        //number of rows and columns from the user and printing the data in the array to the user.
        //Then, create functions to implement following tasks:
        //    1. Print the biggest number of each row and the largest number of the whole array.
        //    2. Sort values ascending of each row.
        //    3. Print items of the array that are prime.
        //    4. Search and print all positions of a number (enter from the user).
        static void jagged_array_exc2()
        {
            Console.Write("input row(s) for a jagged array: ");
            int r = int.Parse(Console.ReadLine());
            int[][] jagged_a = new int[r][];

            List<int> column = new List<int>();
            for (int i = 0; i < r; i++)
            {
                Console.Write($"input column(s) for row {i + 1}: ");
                column.Add(int.Parse(Console.ReadLine()));
            }

            int[] jagged_a_col = column.ToArray();
            for(int j = 0; j < jagged_a_col.Length; j++)
            {
                Console.Write($"Enter {jagged_a_col[j]} value(s) for the {j + 1} row: ");
            }
        }

        static void Main(string[] args)
        {
            jagged_array_exc2();
            Console.ReadKey();
        }    
    }
}
