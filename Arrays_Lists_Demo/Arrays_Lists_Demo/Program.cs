using System;
using System.Collections.Generic;

namespace Arrays_Lists_Demo
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3 }; // single-dimensional array

            int[,] arr2 = new int[2, 3] // multi-dimensional array
            {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            int[][] arr3 = new int[][] // jagged array
            {
                new int[] { 1, 2, 3 },
                new int[] {10, 11, 12, 13, 14, 15 },
                new int[] {20, 21, 22, 23 }
            };

            Console.WriteLine(arr2[1, 2]);

        }
    }
}
