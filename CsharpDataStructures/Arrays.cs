using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    public static class Arrays
    {
        internal static void Run()
        {
            int anInt = 0;

            anInt = 10;

            int[] employeeNumbers = { 1, 2, 3, 4, 5 };

            // 2 types: single dimensional vs multi-dimensional

            // single dimensional
            int[] employeeNumbers2 = new int[5];

            // multi-dimensional
            int[,] employeeNumbers3 = new int[5, 5];

            // jagged array
            int[][] employeeNumbers4 = new int[5][];

            // declare and then initialize
            int[] a = new int[5];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;

            // declare and initialize at the same time
            int[] b = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] is {a[i]}");
            }

            int[] c = new int[5];

            Console.WriteLine("Initial values of an int array");
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine($"c[{i}] is {c[i]}");
            }

            Console.WriteLine("assiging values to array elements in loop");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = i * 10;
                Console.WriteLine($"c[{i}] is {c[i]}");
            }

            Console.WriteLine("ForEach demo");
            foreach (int i in c)
            {
                Console.WriteLine($"i is {i}");
            }

            Console.WriteLine("Methods of arrays");

            int[] unSortedNumbers = { 17, 28, 3, 9, 45, 11, 92, 7, 15, 39 };

            Console.WriteLine("Sorted elements...");

            Array.Sort(unSortedNumbers);

            foreach (var item in unSortedNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Reversed elements...");
            Array.Reverse(unSortedNumbers);

            foreach (var item in unSortedNumbers)
            {
                Console.WriteLine(item);
            }

            int[] newNumbers = new int[unSortedNumbers.Length];
            Console.WriteLine("Copied elements...");
            Array.Copy(unSortedNumbers, newNumbers, unSortedNumbers.Length);
            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }

            // 2-D arrays: Rectangular arrays

            // int[,] matrix = new int[3, 3];

            Console.WriteLine("2-2 Rectangular array");
            int[,] matrix =
                {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine($"{matrix[row, col]} ");
                }
                Console.WriteLine("-------");
            }

            Console.WriteLine("Dynamic initialization of 2-D Array");
            int[,] rectangularArray = new int[4, 4];

            Console.WriteLine("Default values:");
            foreach (var item in rectangularArray)
            {
                Console.WriteLine(item + " ");
            }

            for (int i = 0; i < rectangularArray.GetLength(0); i++)
            {
                for (int j = 0; j < rectangularArray.GetLength(1); j++)
                {
                    rectangularArray[i, j] = i * j + 1;
                }
            }

            Console.WriteLine("Values after initialization:");
            for (int i = 0; i < rectangularArray.GetLength(0); i++)
            {
                for (int j = 0; j < rectangularArray.GetLength(1); j++)
                {
                    Console.WriteLine($"{rectangularArray[i, j]} ");
                }
            }

            //1. Adding two matrices (should have same dimensions)
            //2. Multiplying two matrices

            Console.WriteLine("Jagged Arrays");

            // <datatype>[][] arrayname = new <datatype>[rows][cols];
            int[][] arr = new int[5][];

            arr[0] = new int[5];
            arr[1] = new int[1];
            arr[2] = new int[2];
            arr[3] = new int[5];
            arr[4] = new int[10];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    arr[row][col] = row * col;
                }
            }

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    Console.Write($"{arr[row][col]} ");
                }
                Console.WriteLine();
                Console.WriteLine("--------");
            }

            // arr[1][0] = "123";
        }
    }
}
