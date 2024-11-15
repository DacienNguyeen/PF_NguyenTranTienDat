using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Project
{
    internal class NguyenTranTienDat_31231027217
    {
//        Viết chương trình cho phép nhập ngẫu nhiên một ma trận lởm chởm(jagged) n dòng,
//        mỗi dòng có số cột ki cột(với n và ki, i thuộc [1,100] nhập từ bàn phím) sau đó thực hiện các công việc sau:
        //1.	In ra ma trận đã nhập
        //2.	In ra phần tử lớn nhất, nhỏ nhất trên mỗi dòng và trên toàn bộ ma trận
        //3.	Sắp xếp các dòng theo thứ tự tang dần
        //4.	In ra các phần tử của dòng là số nguyên tố
        //5.	In ra tất cả các vị trí xuất hiện của một số X nhập từ người dùng.
        //6.	Chuyển ma trận này về ma trận chữ nhật với các ô thiếu được điền bằng số 0.
        //7.	Hiển thị menu cho phép người dùng chọn lựa chức năng thực hiện.
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=====Menu=====");
                Console.WriteLine("1. Print generated array");
                Console.WriteLine("2. Print max and min of each row and the whole array");
                Console.WriteLine("3. Sorting each row ascedingly");
                Console.WriteLine("4. Print prime(s) of each row");
                Console.WriteLine("5. Print position(s) of a specific element entered by user");
                Console.WriteLine("6. Convert the generated array to rectangular matrix with missing cell filled by 0");
                Console.WriteLine("7. Exit");
                Console.Write("---Your choice <1...7>: ");

                bool check = int.TryParse(Console.ReadLine(), out int choice);
                if(!check)
                {
                    Console.WriteLine("Make sure to enter interger value!");
                }
                switch (choice)
                {
                    case 1:
                        PrintGeneratedArray();
                        break;
                    case 2:
                        PrintMaxMin();
                        break;
                    case 3:
                        SortingRow();
                        break;
                    case 4:
                        PrintPrimeOfRow();
                        break;
                    case 5:
                        PrintPositionOfElement();
                        break;
                    case 6:
                        ToRectangularMatrix();
                        break;
                    case 7:
                        return; // Exit the program
                    default:
                        Console.WriteLine("Only 6 actions above are currently supported. ");
                        break;
                }
            }while (true);


        }
        private static void ToRectangularMatrix()
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

            Random random = new Random(); // Create Random instance outside the loop

            // Find the maximum number of columns
            int maxColumns = column.Max();

            // Create a new rectangular matrix with zeros
            int[,] rectangular_matrix = new int[r, maxColumns];

            for (int i = 0; i < r; i++)
            {
                jagged_a[i] = new int[column[i]]; // Initialize the inner array *before* accessing it
                for (int j = 0; j < column[i]; j++)
                {
                    jagged_a[i][j] = random.Next(100);
                }

                // Copy elements from jagged array to rectangular matrix
                for (int j = 0; j < column[i]; j++)
                {
                    rectangular_matrix[i, j] = jagged_a[i][j];
                }

                // Fill remaining elements in the row with zeros
                for (int j = column[i]; j < maxColumns; j++)
                {
                    rectangular_matrix[i, j] = 0;
                }
            }

            Console.WriteLine("Your generated jagged array is below: ");
            PrintJaggedArray(jagged_a);

            Console.WriteLine("Converted rectangular matrix with zeros:");
            PrintRectangularMatrix(rectangular_matrix);
        }
        private static void PrintRectangularMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }

        private static void PrintPositionOfElement()
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

            Console.Write("Enter a value to return positions in the jagged array: ");
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < jagged_a.Length; i++)
            {
                foreach (int idx in GetIndex(jagged_a[i], key))
                {
                    Console.WriteLine($"Position(s) of {key} in row #{i} is: ({i},{idx})");
                }
            }
        } //done

        private static void PrintPrimeOfRow()
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


            List<int> PrimeOfJaggedArray = new List<int>();
            for (int i = 0; i < jagged_a.Length; i++)
            {
                Console.Write($"Prime(s) of row {i}: ");
                foreach (int prime in GetPrimeOfArray(jagged_a[i]))
                {
                    Console.Write($"{prime} \t");
                }
                Console.WriteLine();
            }
        } //done

        private static void SortingRow()
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

            for (int i = 0; i < jagged_a.Length; i++)
            {
                SortSingleArray(jagged_a[i]);
            }

            Console.WriteLine("Ascendingly sorted jagged array: ");
            PrintJaggedArray(jagged_a);
        } //done

        private static void PrintMaxMin()
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

            List<int> max_by_row = new List<int>();
            List<int> min_by_row = new List<int>();

            for (int i = 0; i < jagged_a.Length; i++)
            {
                max_by_row.Add(jagged_a[i].Max());
                min_by_row.Add(jagged_a[i].Min());
            }

            Console.WriteLine("Maximum values by row:");
            foreach (int max in max_by_row)
            {
                Console.WriteLine(max);
            }
            Console.WriteLine($"The largest element of whole array: {max_by_row.Max()}");

            foreach (int min in min_by_row)
            {
                Console.WriteLine(min);
            }
            Console.WriteLine($"The smallest element of whole array: {min_by_row.Min()}");
        } //done

        private static void PrintGeneratedArray()
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
        } //done

        static void PrintJaggedArray(int[][] jagged_a)
        {
            for (int i = 0; i < jagged_a.Length; i++)
            {
               for (int j = 0; j < jagged_a[i].Length; j++)
               {
                    Console.Write(jagged_a[i][j] + "\t");
               }
                    Console.WriteLine();
            }
        }

        static int[] SortSingleArray(int[] a)
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
    }
}
