using Data_Structure.Arrays;
using Data_Structure.Multi_Dimensional_Array;
using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                #region Arrays
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

                #region First Missing Posative Number
                int[] firstMissingPosativeNumber = new int[] { 3, 4, -1, 1 };
                firstMissingPosativeNumber = new int[] { 2, -9, 5, 11, 1, -10, 7 };
                firstMissingPosativeNumber = new int[] { 4, 6, 5, 3, 8 };
                firstMissingPosativeNumber = new int[] { 2, 1, 0, 4 };
                firstMissingPosativeNumber = new int[] { 0, 0, 2, 1 };
                firstMissingPosativeNumber = new int[] { 1, 2, 3, 4 };
                Console.WriteLine("First Missing Posative Value :" + array.firstMissingPosativeNumber(firstMissingPosativeNumber, firstMissingPosativeNumber.Length));
                #endregion

                #endregion

                #region String
                Data_Structure.Strings.String stringOperaations = new Data_Structure.Strings.String();

                #region reverseStringByWords
                string reverseStringByWords = "Hello My Name Is Groot";
                reverseStringByWords = "I love programming very much";
                reverseStringByWords = "a good   example";
                Console.WriteLine("Reverse String WordWise : " + stringOperaations.ReverseStringWordWise(reverseStringByWords));
                #endregion

                #region Encoding Message
                string encodingMessage = "bbbeeeeeibceeed";//Output = "b3e5i1b1c1e3d1"
                Console.WriteLine("EncodingMessage: " + stringOperaations.EncodingMessage(encodingMessage));
                #endregion

                #region Minium Paranthesis
                string miniumParanthesis = "))(";
                miniumParanthesis = "())";
                miniumParanthesis = ")))((";
                Console.WriteLine("Minium Paranthesis " + stringOperaations.MiniumParanthesis(miniumParanthesis));
                #endregion

                #region Beautify String
                string beautifuString = "0100101010";
                beautifuString = "111111";
                beautifuString = "1010";
                Console.WriteLine("Beautify string Change Count " + stringOperaations.BeautifyStringWithMinChanges(beautifuString));
                #endregion

                #region Next Smallest Palindrome
                string NextSmallestPalindrome = "23545";
                NextSmallestPalindrome = "1337";
                NextSmallestPalindrome = "8999";
                NextSmallestPalindrome = "999";
                NextSmallestPalindrome = "1234628";
                NextSmallestPalindrome = "713322";
                NextSmallestPalindrome = "14587678322";
                NextSmallestPalindrome = "125322";
                NextSmallestPalindrome = "783322";
                NextSmallestPalindrome = "94187978322";
                Console.WriteLine("Next Smallest Palindrome " + stringOperaations.NextSmallestPalindrome(NextSmallestPalindrome));
                #endregion

                #endregion
            }
            #region Multi-Dimensional Arrays
            
            MultiDimArr multiDimArr = new MultiDimArr();

            #region SymmetricMatrix
            int[,] SymmetricMatrix = new int[,] { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 8 } };
            SymmetricMatrix = new int[,] { { 3, 5, 8 }, { 3, 4, 7 }, { 8, 5, 3 } };
            Console.WriteLine(multiDimArr.ISSymmetricMatrix(SymmetricMatrix));
            #endregion

            #region RotateMatrix By 90 Degree
            int[,] rotate90Degree = new int[,] { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 8 } };
            rotate90Degree = new int[,] { { 3, 5, 8 }, { 3, 4, 7 }, { 8, 5, 3 } };
            rotate90Degree = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            multiDimArr.RotateMatrixBy90Degree(rotate90Degree);
            #endregion

            #endregion

        }
    }
}