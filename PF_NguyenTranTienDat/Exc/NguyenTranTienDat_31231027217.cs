using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat.Exc
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
        static void Main67(string[] args)
        {
            //Initialize element for jagged array
            int[][] jagged_a = Generate_Int_Jagged_Array();
            //Execute menu
            RunProgram(jagged_a);
        }

        static void RunProgram(int[][] jagged_array)
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Print generated array");
            Console.WriteLine("2. Print max and min of each row and the whole array");
            Console.WriteLine("3. Sorting each row ascedingly and print");
            Console.WriteLine("4. Print prime(s) of each row");
            Console.WriteLine("5. Print position(s) of an inputted element");
            Console.WriteLine("6. Convert the generated array to rectangular matrix with missing cell filled by 0");
            Console.WriteLine("7. Generate other array and print it");
            Console.WriteLine("8. Reprint the menu");
            Console.WriteLine("9. Exit");
            Console.Write("---Your choice <1...9>, ");

            do
            {
                int choice = GetIntegerInput();
                switch (choice)
                {
                    case 1:
                        PrintGeneratedArray(jagged_array);
                        break;
                    case 2:
                        PrintMaxMin(jagged_array);
                        break;
                    case 3:
                        SortingEachRow(jagged_array);
                        break;
                    case 4:
                        PrintPrimeOfRow(jagged_array);
                        break;
                    case 5:
                        PrintPositionOfElement(jagged_array);
                        break;
                    case 6:
                        ToRectangularMatrix(jagged_array);
                        break;
                    case 7:
                        //assign new element for the gererated array -> new generated array
                        jagged_array = Generate_Int_Jagged_Array();
                        PrintGeneratedArray(jagged_array);
                        break;
                    case 8:
                        PrintMenu();
                        break;
                    case 9:
                        return; // Exit the program
                    default:
                        Console.WriteLine("Only 8 actions above are currently supported. ");
                        break;
                }
                char direction = GetDirection();
                if (direction == 'N')
                    return;
            } while (true);
        }

        static char GetDirection()
        {
            Console.WriteLine("Do you want to take another action? (Y/N)");
            do
            {
                string input = Console.ReadLine();
                input = input.ToUpper();
                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You've enter nothing!");
                }
                else if(!input.Equals("Y") && !input.Equals("N"))
                {
                    Console.WriteLine("Please type 'Y/N' to continue");
                }
                else
                {
                    return char.Parse(input);
                }
            }while (true);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Print generated array");
            Console.WriteLine("2. Print max and min of each row and the whole array");
            Console.WriteLine("3. Sorting each row ascedingly");
            Console.WriteLine("4. Print prime(s) of each row");
            Console.WriteLine("5. Print position(s) of a specific element entered by user");
            Console.WriteLine("6. Convert the generated array to rectangular matrix with missing cell filled by 0");
            Console.WriteLine("7. Generate other array");
            Console.WriteLine("8. Reprint the menu");
            Console.WriteLine("9. Exit");
            Console.Write("---Your choice <1...9>: ");
        }

        static int [][] Generate_Int_Jagged_Array()
        {
            Console.Write("Input row(s) for a jagged array, ");
            int r = GetIntegerInput();
            int[][] jagged_a = new int[r][];

            List<int> column = new List<int>();
            for (int i = 0; i < r; i++)
            {
                Console.Write($"Input column(s) for row {i + 1}, ");
                column.Add(GetIntegerInput());
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
            return jagged_a;
        }

        static int GetIntegerInput()
        {
            Console.Write("Input an integer: ");
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Make sure input not Null");
                    Console.Write("Try again: ");
                }
                else if (int.TryParse(input, out int intvalue))
                {
                    return intvalue;
                }
                else
                {
                    Console.WriteLine("Make sure input is an integer!");
                    Console.Write("Try again: ");
                }

            } while (true);
        }

        private static void ToRectangularMatrix(int[][] jagged_a)
        {
            int max_col = 0;
            for (int i = 0; i < jagged_a.Length; i++)
            {
                if(jagged_a[i].Length > max_col)
                {
                    max_col = jagged_a[i].Length;
                }
            }
            int[,] RecMatrix = new int[jagged_a.Length, max_col];
            
            for (int i = 0;i < RecMatrix.GetLength(0);i++)
            {
                for(int j = 0; j < RecMatrix.GetLength(1);j++)
                {
                    if(j < jagged_a[i].Length)
                    {
                        RecMatrix[i, j] = jagged_a[i][j];
                    }
                    else
                    {
                        RecMatrix[i, j] = 0;
                    }
                }
            }
            PrintRectangularMatrix(RecMatrix);
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

        private static void PrintPositionOfElement(int[][] jagged_a)
        {
            Console.Write("Enter an integer to search position, ");
            int element_searched = GetIntegerInput();
            bool found = false;
            Console.Write($"Position(s) of {element_searched} (row, column): ");
            for(int i = 0; i < jagged_a.Length; i++)
            {
                for(int j = 0;j < jagged_a[i].Length; j++)
                {
                    if(element_searched == jagged_a[i][j])
                    {
                        Console.Write($"({i},{j}), ");
                        found = true;
                    }
                }
            }
            if(!found )
            {
                Console.Write("(-1, -1), ");
            }

        } //done

        private static void PrintPrimeOfRow(int[][] jagged_a)
        {
            for(int i = 0;i < jagged_a.Length;i++)
            {
                Console.Write($"Prime(s) of row #{i + 1}: ");
                for (int j = 0;j  < jagged_a[i].Length;j++)
                {
                    //In reality the output should be in a vector like (a1, a2, ..., a(n)) with a is a prime
                    if(IsPrime(jagged_a[i][j]))
                    {
                        Console.Write(jagged_a[i][j]+ " ");
                    }
                }
                Console.WriteLine();
            }
        } //done

        private static void SortingEachRow(int[][] jagged_a)
        {
            for(int i = 0;i < jagged_a.Length;i++)
            {
                SortRow(jagged_a[i]);
            }
            PrintGeneratedArray(jagged_a);
        } //done

        static void SortRow(int[]a)
        {
            for(int i = 0;i < a.Length - 1;i++)
            {
                for(int j = 0;j < a.Length - i - 1;j++)
                {
                    if (a[j] > a[j+1])
                    {
                        SwapTwoElements(ref a[j], ref a[j+1]);
                    }
                }
            }
        }

        private static void PrintMaxMin(int[][] jagged_a)
        {
            for(int i = 0;i < jagged_a.Length;i++)
            {
                Console.Write($"Row {i+1}: (max, min) = ({GetMaxInSingleArray(jagged_a[i])}, " +
                    $"{GetMinInSingleArray(jagged_a[i])})");
                Console.WriteLine();
            }
            Console.WriteLine($"Of the whole jagged array: (max, min) = ({GetMaxInJaggedArray(jagged_a)}," +
                $"{GetMinInJaggedArray(jagged_a)})");
        } //done

        static int GetMaxInJaggedArray(int[][] jagged_a)
        {
            int max = 0;
            for( int i = 0;i<jagged_a.Length;i++)
            {
                for( int j = 0;j < jagged_a[i].Length;j++)
                {
                    if(jagged_a[i][j] > max)
                    {
                        max = jagged_a[i][j];
                    }
                }
            }
            return max;
        }

        static int GetMinInJaggedArray(int[][] jagged_a)
        {
            int min = 100000;
            for (int i = 0; i < jagged_a.Length; i++)
            {
                for (int j = 0; j < jagged_a[i].Length; j++)
                {
                    if (jagged_a[i][j] < min)
                    {
                        min = jagged_a[i][j];
                    }
                }
            }
            return min;
        }

        static int GetMaxInSingleArray(int[] a)
        {
            int max = 0;
            for(int i = 0;i < a.Length;i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static int GetMinInSingleArray(int[]a)
        {
            int min = 10000;
            for(int i = 0;i<a.Length;i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        static void PrintGeneratedArray(int[][] jagged_a)
        {
            Console.WriteLine("Below is your generated jagged array: ");
            for(int i = 0;i < jagged_a.Length;i++)
            {
                for(int j = 0;j < jagged_a[i].Length;j++)
                {
                    Console.Write($"{jagged_a[i][j]} \t ");
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
