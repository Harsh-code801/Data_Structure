using Data_Structure.Basic_DSA.Arrays;
using Data_Structure.Basic_DSA.Basic_Algorithm;
using Data_Structure.Basic_DSA.Map_And_Set;
using Data_Structure.Basic_DSA.Multi_Dimensional_Array;
using Data_Structure.Basic_DSA.Problems;
using Data_Structure.Basic_DSA.Two_Pointers;
using Data_Structure.Intermediate_DSA.Binary_Search;
using Data_Structure.Intermediate_DSA.Recursion_Basic;
using System.Security;

namespace DataStructure
{
    internal class Program
    {
        static void MainBasicDSA(string[] args)
        {
            #region Arrays
            Data_Structure.Basic_DSA.Arrays.Array array = new Data_Structure.Basic_DSA.Arrays.Array();

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
            Data_Structure.Basic_DSA.Strings.String stringOperaations = new Data_Structure.Basic_DSA.Strings.String();

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

            #region majority Element n\2
            int[] majorityElementNBy3 = new int[] { 3, 2, 2, 1, 5, 2, 3 };
            majorityElementNBy3 = new int[] { 7, 4, 4, 9, 7 };
            Console.WriteLine("Majority Element n\\3 : " + problemsSolving.MajorityElementNby3(majorityElementNBy3));
            #endregion

            #region Rotate Matrix Right by k element
            int[,] arrayRotateByRight = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }; int kmove = 3;
            problemsSolving.RotateArrayRightByK(arrayRotateByRight, kmove);
            #endregion

            #region Find K’th Character of Decrypted String (perfomance issue)
            string encryptedString = "ab12c3"; int kval = 20;
            encryptedString = "a2b2c3"; kval = 5;
            encryptedString = "ab4c2ed3"; kval = 9;
            //encryptedString = "ab4c12ed3"; kval = 21;
            encryptedString = "leet2code3"; kval = 10;
            Console.WriteLine(problemsSolving.FindKCharacterOfDecryptedString(encryptedString, kval));
            #endregion

            #region Move Zeroes To End
            int[] move0toEnd = new int[] { 2, 0, 4, 1, 3, 0, 2, 8 };
            problemsSolving.Move0ToEnd(move0toEnd);
            #endregion

            #region Sum of Two Elements Equals the Third.
            int[] sumOfTwoElement = new int[] { 10, 5, 5, 6, 2 };
            sumOfTwoElement = new int[] { 5, 32, 1, 7, 10, 50, 19, 21, 2 };
            sumOfTwoElement = new int[] { 5, 32, 1, 7, 10, 50, 19, 21, 0 };
            Console.WriteLine("Sum of Two Elements Equals the Third. " + problemsSolving.SumofTwoElementsEqualstheThird(sumOfTwoElement));
            #endregion

            #region Maximum Sum Circular Subarray
            int[] maxCircularSum = new int[] { 1, 2, -3, -4, 5 };
            maxCircularSum = new int[] { -2, -3, -1 };
            maxCircularSum = new int[] { 1, 2, 3, 4 };
            maxCircularSum = new int[] { -1000000000, -10000 };
            maxCircularSum = new int[] { 8, -8, 9, -9, 10, -11, 12 };
            Console.WriteLine(problemsSolving.MaximumSumCircularSubarray(maxCircularSum));
            #endregion

            #region Longest Consecutive Sequence
            int[] longestConsecutiveSequence = new int[] { 1, 9, 3, 10, 4, 20, 2 };
            longestConsecutiveSequence = new int[] { 36, 41, 56, 35, 44, 33, 34, 92, 43, 32, 42 };
            longestConsecutiveSequence = new int[] { 1, 9, 3, 10, 4, 20, 2 };
            longestConsecutiveSequence = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            longestConsecutiveSequence = new int[] { };
            Console.WriteLine(problemsSolving.LongestConsecutiveSequence(longestConsecutiveSequence));
            #endregion

            #region Maximum subarray sum after K
            int[] MaximumsubarraysumafterK = new int[] { -1, -2, -3 }; int kmaxsum = 3;
            MaximumsubarraysumafterK = new int[] { -1, 10, 20 }; kmaxsum = 2;
            Console.WriteLine(problemsSolving.MaximumsubarraysumafterK(MaximumsubarraysumafterK, kmaxsum));
            #endregion

            #region Multiply Strings (large string)
            string strVal1 = "4154", strVal2 = "51454";
            strVal1 = "654154154151454545415415454"; strVal2 = "63516561563156316545145146514654";
            strVal1 = "654154154151454545415415454"; strVal2 = "0";
            strVal1 = "140"; strVal2 = "721";
            Console.WriteLine(problemsSolving.StringCalculater(strVal1, strVal2));
            #endregion

            #region Missing and repeating numbers
            int[] missingAndRepeating = new int[] { 6, 4, 3, 5, 5, 1 };
            missingAndRepeating = new int[] { 4, 3, 6, 2, 1, 1 };
            missingAndRepeating = new int[] { 3, 1, 3 };
            missingAndRepeating = new int[] { 2, 4, 3, 5, 5, 1 };
            Console.WriteLine(problemsSolving.Missingandrepeatingnumbers(missingAndRepeating));
            #endregion

            #region Find Four Elements That Sums To A Given Value
            int[] sumoffourelement = new int[] { 10, 2, 3, 4, 5, 9, 7, 8 }; int x = 23;
            sumoffourelement = new int[] { 2, 2, 2, 2, 2 }; x = 8;
            problemsSolving.FindFourElementsThatSumsToAGivenValue(sumoffourelement, x);
            #endregion

            #region Count All Subarrays With Given Sum
            int[] subarraywithsum = new int[] { 3, 1, 2, 4 }; int kofsum = 6;
            subarraywithsum = new int[] { 10, 2, -2, -20, 10 }; kofsum = -10;
            subarraywithsum = new int[] { 9, 4, 20, 3, 10, 5 }; kofsum = 33;
            subarraywithsum = new int[] { 1, -1, 0 }; kofsum = 0;
            Console.WriteLine("Count All Subarrays With Given Sum : " + problemsSolving.CountAllSubarraysWithGivenSum(subarraywithsum, kofsum));
            #endregion

            #region Find nth elements of spiral matrix
            int[,] nElementInSpiral = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }; int find = 6;
            nElementInSpiral = new int[,] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 } }; find = 17;
            Console.WriteLine($"\nValue at Index {find} Is {problemsSolving.Findnthelementsofspiralmatrix(nElementInSpiral, find)}");
            #endregion

            #endregion

        }
        static void Main(string[] args)
        {
            #region Binary Search

            BinarySearch binarySearch = new BinarySearch();

            #region Square Root
            int squareRoot = 11;
            squareRoot = 8;
            squareRoot = 15;
            Console.WriteLine($"Square Root of {squareRoot} Is {binarySearch.SquareRoot(squareRoot)}");
            #endregion

            #region Search In Rotated Sorted Array (Binary Search)
            int[] bSearch = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 }; int find = 6;
            bSearch = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; find = 9;
            bSearch = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 }; find = 30;
            bSearch = new int[] { 30, 40, 50, 10, 20 }; find = 10;
            Console.WriteLine($"Binary Search: {find} found at {binarySearch.pivotedBinarySearch(bSearch, bSearch.Length, find)}");
            #endregion

            #region Single Element in a Sorted Array
            int[] findNotTwisePrintElement = new int[] { 1, 1, 3, 3, 6, 8, 8 };
            findNotTwisePrintElement = new int[] { 1,18, 18 };
            findNotTwisePrintElement = new int[] { 1,1, 18 };
            findNotTwisePrintElement = new int[] { 55 };
            Console.WriteLine($"Single Element in Array: {binarySearch.SingleElementinaSortedArray(findNotTwisePrintElement)}");
            #endregion

            #region Matrix Median
            int[,] matrixMedian = new int [,]{ { 1, 3, 5 }, { 2, 6, 9 }, { 3, 6, 9 } };
            matrixMedian = new int[,] { { 1, 3, 4 }, { 2, 5, 6 }, { 7, 8, 9 } };
            matrixMedian = new int[,] { { 1, 3, 8 }, { 2, 3, 4 }, { 1, 2, 5 } };
            matrixMedian = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine($"Matrix Median Is: {binarySearch.MatrixMedian(matrixMedian)}");
            #endregion

            #region Aggressive Cows
            int[] aggressiveCows = new int[] { 1, 2, 4, 8, 9 };int cowsCount = 3;
            Console.WriteLine($"Minimum Distance {binarySearch.AggressiveCows(aggressiveCows, cowsCount)}");
            #endregion
            #endregion

            #region Recursion Basic

            RecursionBasic recursionBasic = new RecursionBasic();

            #region Marge Sort
            int[] margeSort = new int[] { 5, 8, 1, 0, 4, 2, 6, 7 };
            margeSort = new int[] { 5, 5, 1, 0, 4, 2, 6, 7 };
            Console.WriteLine($"Marge Sort: of {string.Join(", ", margeSort)} Is {recursionBasic.MargeSort(margeSort)}");
            #endregion

            #region Quick Sort
            int[] quickSort = new int[] { 5, 7, 1, 0, 3, 9 };
            quickSort = new int[] { 7, 2, 5, 5, 3, 4 };
            Console.WriteLine($"Quick Sort: of {string.Join(", ", quickSort)} Is {recursionBasic.QuickSort(quickSort,0,quickSort.Length-1)}");
            #endregion

            #endregion
        }
    }
}