﻿using Data_Structure.Arrays;
using Data_Structure.Basic_Algorithm;
using Data_Structure.Map_And_Set;
using Data_Structure.Multi_Dimensional_Array;
using Data_Structure.Problems;
using Data_Structure.Two_Pointers;
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

                #region set Matrix Zero
                int[,] setMatrixZero = new int[,] { { 7, 19, 3 }, { 4, 21, 0 } };
                setMatrixZero = new int[,] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
                setMatrixZero = new int[,] { { 0, 1, 2, 0 }, { 3, 4, 5, 2 }, { 1, 3, 1, 5 } };
                multiDimArr.SetMatrixZero(setMatrixZero);
                #endregion

                #region Sprial Order
                int[,] sprialOrder = new int[,] { { 1, 2, 3, 4 }, { 14, 15, 16, 5 }, { 13, 20, 17, 6 }, { 12, 19, 18, 7 }, { 11, 10, 9, 8 } };
                sprialOrder = new int[,] { { 1, 2 }, { 8, 3 }, { 7, 4 }, { 6, 5 } };
                sprialOrder = new int[,] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 } };
                sprialOrder = new int[,] { { 1, 2, 3, 4, 5, 6 }, { 20, 21, 22, 23, 24, 7 }, { 19, 32, 33, 34, 25, 8 }, { 18, 31, 36, 35, 26, 9 }, { 17, 30, 29, 28, 27, 10 }, { 16, 15, 14, 13, 12, 11 } };
                Console.WriteLine(multiDimArr.SpiralOrder(sprialOrder));
                #endregion

                #endregion

                #region Maps And Set

                MapAndSet mapAndSet = new MapAndSet();

                #region Make Unique Array
                int[] UniqueArray = new int[] { 1, 3, 44, 5, 1, 7, 7, 7, 7, 3, 44 };
                Console.WriteLine("UniqueArray: " + mapAndSet.MakeUniqueArray(UniqueArray));
                #endregion

                #region First Non Repeating Character
                string FirstNonRepeatingCharacter = "geeksforgeeks";
                FirstNonRepeatingCharacter = "leetcode";
                FirstNonRepeatingCharacter = "AAAbcdb";
                FirstNonRepeatingCharacter = " ABcdABcd\r\n";
                Console.WriteLine("FirstNonRepeatingCharacter: " + mapAndSet.FirstNonRepeatingCharacter(FirstNonRepeatingCharacter));
                #endregion

                #region Longest Subarray Zero Sum
                int[] longestSubarrayZeroSum = new int[] { 15, -2, 2, -8, 1, 7, 10, 0, 23 };
                //longestSubarrayZeroSum = new int[] { 1, 3, -1, 4, -4 };
                //longestSubarrayZeroSum = new int[] { 1, -1, 2, -2 };
                Console.WriteLine("Longest Subarray With Zero Sum: " + string.Join(",", mapAndSet.LongestSubarrayZeroSum(longestSubarrayZeroSum)));
                #endregion

                #region Count all sub-arrays having sum divisible by k
                int[] subArraySumDividedByK = new int[] { 5, 0, 2, 3, 1 };//k = 5
                subArraySumDividedByK = new int[] { 4, 5, 0, -2, -3, 1 };//k = 5
                Console.WriteLine("Count all sub-arrays having sum divisible by k: " + mapAndSet.CountAllSubarraysHavingSumDivisibleByK(subArraySumDividedByK, 5));
                #endregion

                #region Group Anagrams
                string[] groupAnagrams = new string[] { "abab", "baba", "aabb", "abbc" };
                groupAnagrams = new string[] { "cat", "dog", "tac", "god", "act" };
                groupAnagrams = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
                Console.WriteLine("Group Anagrams: " + mapAndSet.GroupAnagrams(groupAnagrams));
                #endregion

                #endregion

                #region Two Pointers

                TwoPointers twoPointers = new TwoPointers();
                #region pairSum
                int[] pairSum = new int[] { 1, 5, 7, -1 }; int k = 6;
                pairSum = new int[] { 1, 5, 7, -1, 5 }; k = 6;
                pairSum = new int[] { 1, 1, 1, 1 }; k = 2;
                pairSum = new int[] { 10, 12, 10, 15, -1, 7, 6, 5, 4, 2, 1, 1, 1 }; k = 11;
                Console.WriteLine("Pair Sum: " + twoPointers.PairSum(pairSum, k));
                #endregion

                #region Container With Most Water
                int[] containerWithMostWater = new int[] { 1, 5, 4, 3 };
                containerWithMostWater = new int[] { 3, 1, 2, 4, 5 };
                Console.WriteLine("Container With Most Water: " + twoPointers.containerWithMostWater(containerWithMostWater));
                #endregion

                #region Is SubSequence
                string str1 = "AXY", str2 = "YADXCP";
                str1 = "AXY"; str2 = "ADXCPY";
                str1 = "gksrek"; str2 = "geeksforgeeks";
                Console.WriteLine($"Is {str1} is Subsequence of {str2} = " + twoPointers.IsSubSequence(str1, str2));
                #endregion
                #endregion

                #region Basic Algorithm
                BasicAlgorithms basicAlgorithms = new BasicAlgorithms();

                #region Insertion Sort
                int[] insertionSort = new int[] { 4, 3, 2, 10, 12, 1, 5, 6, 25 };
                basicAlgorithms.InsertionSort(insertionSort);
                #endregion

                #region Selection Sort
                int[] selectionSort = new int[] { 4, 3, 2, 10, 12, 1, 5, 6, 25 };
                basicAlgorithms.SelectionSort(selectionSort);
                #endregion

                #region Bubble Sort
                int[] bubbleSort = new int[] { 4, 3, 2, 10, 12, 1, 5, 6, 25 };
                basicAlgorithms.BubbleSort(bubbleSort);
                #endregion

                #region Kadane's Algorithm
                int[] kadanisAlgorithm = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
                basicAlgorithms.kadanisAlgorithm(kadanisAlgorithm);
                #endregion

                #region Dutch National Flag Algorithm
                int[] datchNationalFlagAlgorithm = new int[] { 0, 1, 1, 0, 0, 2, 1, 2, 1 };// Array contains only 0, 1, 2
                basicAlgorithms.DatchNationalFlagAlgorithm(datchNationalFlagAlgorithm);
                #endregion

                #region Majority element ( Moore Voting Algorithm)
                int[] majorityElement = new int[] { 0, 1, 1, 0, 0, 1, 1, 2, 1 };
                majorityElement = new int[] { 2, 3, 9, 2, 2 };
                basicAlgorithms.MooreWatingAlgorithm(majorityElement);
                #endregion

                #endregion
            }
            #region Problem Solving
            ProblemsSolving problemsSolving = new ProblemsSolving();

            #region Check Permutation
            string string1 = "listen", string2 = "silent";
            string1 = "asspl"; string2 = "appsl";
            Console.WriteLine("Is Permutation: " + problemsSolving.CheckPermutation(string1, string2));
            #endregion

            #region Intersection Of Array
            int[] arr1 = new int[] { 4, 1, 5 }, arr2 = new int[] { 3, 4, 5 };
            arr1 = new int[] { 1, 3, 4, 5, 7 }; arr2 = new int[] { 2, 3, 5, 6 };
            arr1 = new int[] { 2, 5, 6 }; arr2 = new int[] { 4, 6, 8, 10 };
            Console.WriteLine("Intersection Of Array: " + problemsSolving.Intersection(arr1, arr2));
            #endregion

            #endregion

        }
    }
}