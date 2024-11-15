using PriceGuessingGame;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PF_NguyenTranTienDat.Learning
{
    internal class Session_6
    {
        static void Main2(string[] args)
        {
            //Console.WriteLine("How many item(s) will be in your array? ");
            //int N = int.Parse(Console.ReadLine());
            //int[] a = new int[N];
            ////manually_input_array(a, N);
            //randomize_element_array(a, N);
            //print_array(a);
            //Console.WriteLine(sum_array(a));
            //increase_value(a, 2);
            //print_array(a);
            //Console.WriteLine(sum_array(a));
            //single_dimension_array_exc();
            Matrix_exc();

        }

        static void manually_input_array(int[] a, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter value for the #{i + 1} element: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void randomize_element_array(int[] a, int N)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
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

        static void increase_value(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += value;
            }
        }

        static int sum_array(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        static void single_dimension_array_exc()
        {
            Random rnd = new Random();
            int N = rnd.Next(10, 31);
            int[] a = new int[N];

            //assign value for array
            for (int i = 0; i < N; i++)
            {
                a[i] = rnd.Next(100);
            }

            print_array(a);
            Console.WriteLine($"Average: {get_avg(a)}");
            Random rnd_key = new Random();
            int key = rnd.Next(100);
            Console.WriteLine($"Does the array contain {key}? {containkey(a, key)}");
            int element = a[rnd.Next(a.Length)];
            Console.WriteLine($"The index of element {element} is: {find_index(a, element, 0)}");
            int[] newly_updated_a = remove_element(a, element);
            Console.Write($"The array after removed {element}: ");
            print_array(newly_updated_a);
            Console.WriteLine($"Max and Min respectively of the above array is: {GetMax(newly_updated_a)}, {GetMin(newly_updated_a)}");
            Console.Write("The reversed array is: ");
            print_array(ReverseArray(newly_updated_a));
            int[] dup_ele = GetDuplicatedElement(newly_updated_a);
            Console.Write("Duplicated element of the array above is: ");
            foreach (int ele in dup_ele)
                Console.Write(ele + " ");

            Console.WriteLine();
            Console.Write("The distinct-element array: ");
            print_array(RemoveDuplicatedElement(newly_updated_a));
            int[] sorted_a = BubbleSort(RemoveDuplicatedElement(newly_updated_a));
            print_array(BubbleSort(sorted_a));

            double get_avg(int[] a)
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum / a.Length;
            }

            //to test if an array contains a specific value.
            bool containkey(int[] a, int key)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == key)
                        return true;
                }
                return false;
            }

            //to find the index of an array element.
            int find_index(int[] a, int key, int return_type)
            {
                switch (return_type)
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

            //to remove a specific element of the array
            int[] remove_element(int[] a, int element)
            {
                List<int> list = new List<int>();
                foreach (int i in a)
                {
                    if (i != element)
                    {
                        list.Add(i);
                    }
                }
                return list.ToArray();
            }

            //GetMax
            int GetMax(int[] a)
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                        max = a[i];
                }
                return max;
            }
            //GetMin
            int GetMin(int[] a)
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                { if (a[i] < min) min = a[i]; }
                return min;
            }

            int[] ReverseArray(int[] a)
            {
                int left = 0, right = a.Length - 1;
                while (left < right)
                {
                    int temp = a[left];
                    a[left] = a[right];
                    a[right] = temp;
                    left++;
                    right--;
                }
                return a;
            }

            int[] GetDuplicatedElement(int[] a)
            {
                List<int> duplicate = new List<int>();
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1;
                        j < a.Length; j++)
                    {
                        if (a[i] == a[j] && !duplicate.Contains(a[i]))
                        {
                            duplicate.Add(a[i]);
                            break;
                        }
                    }
                }
                return duplicate.ToArray();
            }

            int[] RemoveDuplicatedElement(int[] a)
            {
                //method 1: return array.Distinct().ToArray();

                List<int> result = new List<int>();
                int[] dup = GetDuplicatedElement(a); // Get the distinct duplicate values
                HashSet<int> duplicates = new HashSet<int>(dup); // Use a HashSet for efficient lookups

                foreach (int num in a)
                {
                    if (!duplicates.Contains(num)) // Check if the element is NOT a duplicate
                    {
                        result.Add(num);
                    }
                    else if (!result.Contains(num))
                    { // if num is a duplicate, check if it's already in the result
                        result.Add(num);
                    }
                }
                return result.ToArray();
            }

            int[] BubbleSort(int[] a)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - i - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
                return a;
            }
        }

        static void SearchWord()
        {
            Console.Write("Input a sentence: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            Console.Write("Enter a word you want to search: ");
            string word_searched = Console.ReadLine();
            string word_searched_normalized = word_searched.ToLower();

            string[] word = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool contain = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word_searched_normalized)
                {
                    contain = true;
                }
            }

            Console.WriteLine($"The sentence contains {word_searched}? {contain}");
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

        static void jagged_array_exc2()
        {

            Console.Write("Input row(s) for a jagged array: ");
            int r = int.Parse(Console.ReadLine());
            int[][] jagged_a = new int[r][];

            List<int> column = new List<int>();
            for (int i = 0; i < r; i++)
            {
                Console.Write($"Input column(s) for row {i + 1}: ");
                column.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Press 1 to manually enter element, Press 2 to randomize element: ");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    for (int i = 0; i < r; i++)
                    {
                        Console.Write($"Enter {column[i]} value(s) for row {i + 1} (space or comma-separated): ");
                        string input = Console.ReadLine();

                        // Split the input string by space or comma
                        string[] values = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        // Check if the number of entered values matches the expected column count
                        if (values.Length != column[i])
                        {
                            Console.WriteLine($"Incorrect number of values entered. Expected {column[i]}, got {values.Length}. Please try again.");
                            i--; // Decrement i to re-enter values for this row
                            continue;
                        }

                        jagged_a[i] = new int[column[i]];
                        for (int j = 0; j < column[i]; j++)
                        {
                            jagged_a[i][j] = int.Parse(values[j]);
                        }
                    }
                    Console.WriteLine("Your created jagged array is below: ");
                    PrintJaggedArray(jagged_a);
                    break;

                case 2:
                    Random random = new Random(); // Create Random instance outside the loop
                    for (int i = 0; i < r; i++)
                    {
                        jagged_a[i] = new int[column[i]]; // Initialize the inner array *before* accessing it
                        for (int j = 0; j < column[i]; j++)
                        {
                            jagged_a[i][j] = random.Next(100);
                        }
                    }
                    Console.WriteLine("Your generated jagged array is below: ");
                    PrintJaggedArray(jagged_a);
                    break;

                default:
                    Console.WriteLine("We currently support the 2 options above"); // Clarified message
                    break;
            }


            void PrintJaggedArray(int[][] jagged_a)
            {
                for (int i = 0; i < jagged_a.Length; i++)
                {
                    for (int j = 0; j < jagged_a[i].Length; j++)
                    {
                        Console.Write(jagged_a[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            List<int> max_by_row = new List<int>();
            for (int i = 0; i < jagged_a.Length; i++)
            {
                max_by_row.Add(jagged_a[i].Max());
            }

            Console.WriteLine("Maximum values by row:");
            foreach (int max in max_by_row)
            {
                Console.WriteLine(max);
            }

            Console.WriteLine($"The largest element of whole array: {max_by_row.Max()}");

            //sort values ascending each row
            for (int i = 0; i < jagged_a.Length; i++)
            {
                SortArray(jagged_a[i]);
            }
            Console.WriteLine("Ascendingly sorted jagged array: ");
            for (int i = 0; i < jagged_a.Length; i++)
            {
                print_array(jagged_a[i]);
            }

            for (int i = 0; i < jagged_a.Length; i++)
            {
                Console.Write($"Prime Elements of array #{i}: ");
                foreach (int item in GetPrimeOfArray(jagged_a[i]))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            List<int> PrimeOfJaggedArray = new List<int>();
            for (int i = 0; i < jagged_a.Length; i++)
            {
                PrimeOfJaggedArray.AddRange(GetPrimeOfArray(jagged_a[i]));
            }

            // Distinct should be called *after* the loop
            int[] uniquePrimes = PrimeOfJaggedArray.Distinct().ToArray();
            SortArray(uniquePrimes);

            Console.Write("All prime elements of jagged array are: ");
            foreach (int prime in uniquePrimes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();

            Console.Write("Enter a value to return positions in the jagged array: ");
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < jagged_a.Length; i++)
            {
                foreach (int idx in GetIndex(jagged_a[i], key))
                {
                    Console.WriteLine($"Position(s) of {key} in row #{i} is: ({i},{idx})");
                }
            }
        }
        //public function
        static int[] SortArray(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        SwapTwoElements(ref a[j], ref a[j + 1]);
                    }
                }
            }
            return a.ToArray();
        }

        static void SwapTwoElements(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static bool IsPrime(int x)
        {
            if (x <= 1) return false; // Handle 0 and 1 (not prime)
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int[] GetPrimeOfArray(int[] a)
        {
            List<int> PrimeList = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (IsPrime(a[i]))
                    PrimeList.Add(a[i]);
            }
            return PrimeList.ToArray();
        }

        static int[] GetIndex(int[] a, int key)
        {
            List<int> IndexList = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == key)
                {
                    IndexList.Add(i);
                }
            }
            return IndexList.ToArray();
        }

        //Create a program with following functions
        //- Create an integermatrix N x M(N, M was prompted from user) randomly.
        //- Printthe matrix.
        //- Print the ith row/column. (i was prompted from user)
        //- Find the max value of the matrix.
        //- Find the min value of ith row/col of the matrix.
        //- Transpose the matrix.
        //- Print the main/secondarydiagonal values of the matrix.

        static void Matrix_exc()
        {
            int[,] matrix = InitializeMatrix();
            GenerateElement(matrix);
            PrintMatrix(matrix);
            int num = initializenum();
            PrintSelectively(matrix, num);
            int max = GetMax(matrix);
            Console.WriteLine();
            Console.WriteLine($"Max = {max}");
            int min = GetMinofIndex(matrix, num);
            Console.WriteLine($"Min of column {num} = {min}");

            int[,] matrix_transposed = Transpose(matrix);
            PrintMatrix(matrix_transposed);

        }

        private static int[,] InitializeMatrix()
        {
            Console.Write("Enter the number(s) of row: "); int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the numbers(s) of column: "); int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            return matrix;
        }

        static void GenerateElement(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintSelectively(int[,] matrix, int index)
        {
            //while (true)
            //{
            //    Console.WriteLine("Choose an action:");
            //    Console.WriteLine("1. Select row");
            //    Console.WriteLine("2. Select column");
            //    Console.WriteLine("3. Exit");

            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //        case 2:
            //        case 3:
            //            return;
            //        default:
            //            Console.WriteLine("Invalid choice.");
            //            break;
            //    }
            //}

            //}

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write($"{matrix[i, index]}\t");
            }
        }
        static int initializenum()
        {
            Console.Write("index = ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int GetMax(int[,] matrix)
        {
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max) { max = matrix[i, j]; }
                }
            }
            return max;
        }

        static int GetMinofIndex(int[,] matrix, int index)
        {
            int min = 100000;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if ((matrix[i, index] < min))
                {
                    min = matrix[i, index];
                }
            }
            return min;
        }

        static int[,] Transpose(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i+1; j < matrix.GetLength(0); j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            return matrix;
        }
    }
}

    
