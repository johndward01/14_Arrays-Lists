using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Lists_Demo
{
    public class Methods
    {
        public void PrintArraysContents(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
