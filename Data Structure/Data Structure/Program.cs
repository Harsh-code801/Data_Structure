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
            //Console.WriteLine("Second Largest Number Is " + array.SecondLargestNumber(secondLargest, secondLargest.Length));
            #endregion

            #region RotateElementByK
            int[] rotateArray = new int[] { 100, -3, 95, 100, 55, 177, 3, -4, -3, 95, 100, 95, 177, -5, -4, 177, 101 };
            array.RotateElementByK(rotateArray, rotateArray.Length, 5);
            #endregion

            #region NonDecrisingArray
            int[] nonDecrising = new int[] { 4, 2, 1 };
            Console.WriteLine("IsNonDecrisingArray: " + array.IsNonDecrisingArray(nonDecrising, nonDecrising.Length));
            #endregion

            #region Equilibrium
            int[] Equilibrium = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            Equilibrium = new int[] { 1, 2, 3, 3, 2, 1 };
            //Equilibrium = new int[] { 1,2,-2,-1};
            Console.WriteLine("Equilibrium Index: " + array.Equilibrium(Equilibrium, Equilibrium.Length)); 
            #endregion
        }
    }
}