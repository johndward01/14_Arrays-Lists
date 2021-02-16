using System;
using System.Collections.Generic;

namespace Arrays_Lists_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists ------------------------------------------------------------------------------------------------------

            //Declaring an empty list of integers called numbers
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Declaring an integer array of size 3
            int[] myArray = new int[3];

            // Initializing each index with a value
            myArray[0] = 11;
            myArray[1] = 10;
            myArray[2] = 9;

            // Declaring and initializing using object initializer syntax
            int[] arr1 = new int[] { 1, 2, 3 };

            // Inferred typing 
            var arr2 = new int[] { 4, 5, 6, 7, 8, 9 };

            var x = new Methods();

            x.PrintArraysContents(arr2);
            

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine();
            //Console.WriteLine();


            // Filling up the list 
            //for (int i = 2; i < 100; i += 2)
            //{
            //    numbers.Add(i);
            //}

            //// Print out the list to the console
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Add(121212);
            //numbers.Remove(2);
            //Console.WriteLine();
            //// Declare and Initialize a list
            //var words = new List<string>() { "Ray", "RG", "Stephen", "Hajrie" };

            //foreach (var name in words)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();
            //words.Add("Jeremy");
            //words.Add("Kurt");

            //for (int i = 0; i < words.Count; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            // Declaring a variable of type string
            //string firstName;
            // Initializing that string variable
            //firstName = "John";

            // Declaring and Initializing a variable
            //string lastName = "Ward";
            // Lists ------------------------------------------------------------------------------------------------------

            // Arrays --------------------------------------------------------------------------------

            // Declare an array of size 3
            //int[] myArray = new int[4];

            // Initializing the indeces of the array
            //myArray[3] = 4;
            //myArray[0] = 1;
            //myArray[1] = 2;
            //myArray[2] = 3;

            // Declaring and initializing a string array
            var names = new string[3] { "John", "Jeremy", "Nathan" };

            // Declaring and initializing a string array
            var people = new string[] { "John", "Jeremy", "Nathan" };


            //foreach (var number in myArray)
            //{
            //    Console.WriteLine(number);
            //}

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i]);
            //}

        }









        //public static void PrintOutArrayNumbers(int[] arr)
        //{
        //    foreach (var number in arr)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}

        //public static void PrintOutArrayStrings(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
    }
}
