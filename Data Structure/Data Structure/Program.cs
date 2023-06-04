using Data_Structure.Arrays;
using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data_Structure.Arrays.Array array = new Data_Structure.Arrays.Array();


            #region SecondLargestNumber
            int[] secondLargest = new int[] { 100, -3, 95, 100, 95, 177, -5, -4, 177, 101 };
            secondLargest = new int[] { 10, 10, 100 };
            Console.WriteLine("Second Largest Number Is " + array.SecondLargestNumber(secondLargest, secondLargest.Length)); 
            #endregion

        }
    }
}