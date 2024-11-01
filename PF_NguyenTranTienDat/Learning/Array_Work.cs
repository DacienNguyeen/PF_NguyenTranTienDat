//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PF_NguyenTranTienDat.Learning
//{
//    internal class Array_work
//    {
//        static void Swap(ref double a, ref double b)
//        {
//            double temp = a;
//            a = b; 
//            b = temp;
//        }

//        //static void Main(string[] args)
//        //{
//        //    double[] a = { 1, 6, 4, 6, 2, 3, 9, 10, 12, 11, 16, 20, 1, 2, 18, 19 };

//        //    for (int i = 0; i < a.Length - 1; i++)
//        //    {
//        //        for(int j = i + 1; j < a.Length; j++)
//        //        {
//        //            if(a[i] >= a[j])
//        //            {
//        //                Swap(ref a[i], ref a[j]);
//        //            }
//        //        }
//        //    }
//        //    //or you can use function Array.Sort('your array');

//        //    // Output sorted array
//        //    Console.Write("Sorted Array: ");
//        //    for (int i = 0; i < a.Length; i++)
//        //    {
//        //        if (i == a.Length - 1)
//        //        {
//        //            Console.Write($"{a[i]}");
//        //        }
//        //        else
//        //        {
//        //            Console.Write($"{a[i]}, ");
//        //        }
//        //    }

//        //    Console.WriteLine();

//        //    Console.Write("Sorted unique-value array: ");
//        //    for (int i = 0; i < a.Length; i++)
//        //    {
//        //        // Check if the current element is unique
//        //        if ((i == 0 || a[i] != a[i - 1]) && (i == a.Length - 1 || a[i] != a[i + 1]))
//        //        {
//        //            Console.Write($"{a[i]} ");
//        //        }
//        //    }

//        //    Console.WriteLine();

//        //    Console.Write("Number that is duplicated: ");
//        //    for (int i = 0; i < a.Length - 1; i++)
//        //    {
//        //        // Check if the current element is unique
//        //        if (a[i] == a[i + 1])
//        //        {
//        //            Console.Write($"{a[i]} ");
//        //        }
//        //    }

//        //    Console.WriteLine();
//        //    Console.Write("No duplicate value sorted array: ");
//        //    for (int i = 0; i < a.Length-1; i++)
//        //    {
//        //        // Check if the current element is unique
//        //        if (a[i] == a[i+1])
//        //        {
//        //            continue;
//        //        }
//        //        else
//        //        {
//        //            Console.Write($"{a[i]} ");
//        //        }
//        //    }
//        //    // Print the last element if it’s unique
//        //    if(a.Length > 1 && a[a.Length-2] != a[a.Length-1])
//        //    {
//        //        Console.Write($"{a[a.Length - 1]} ");
//        //    }
//        //    else if(a.Length == 1)
//        //    {
//        //        Console.Write($"{a[0]} ");
//        //    }
//        }
//    }
//}
