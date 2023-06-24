using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structure.Basic_DSA.Problems
{
    internal class ProblemsSolving
    {
        public bool CheckPermutation(string str1, string str2)
        {
            int notMatchCount = str1.Length;
            return string.Join("", str1.OrderByDescending(x => x).ToArray()) == string.Join("", str2.OrderByDescending(x => x).ToArray());
        }
        public string Intersection(int[] arr1, int[] arr2)
        {
            int i = 0, j = 0;
            List<int> lst = new List<int>();
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr1[i])
                    j++;
                else
                {
                    lst.Add(arr1[i]);
                    i++;
                }
            }
            return lst.Count > 0 ? string.Join(", ", lst) : "Not found any intersection element";
        }
        public string MajorityElementNby3(int[] arr)
        {
            List<KeyValuePair<int, int>> lst = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                lst.Add(new KeyValuePair<int, int>(arr[i], count));
            }
            return string.Join(", ", lst.DistinctBy(x => x.Key).Where(x => x.Value > arr.Length / 3).ToList().Select(x => x.Key));
        }
        public void RotateArrayRightByK(int[,] arr, int k)
        {
            PrintArray(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int p = 0; p < k; p++)
                {
                    int element = arr[i, 0];
                    arr[i, 0] = arr[i, arr.GetLength(1) - 1];
                    for (int j = 1; j < arr.GetLength(1); j++)
                    {
                        int temp = arr[i, j];
                        arr[i, j] = element;
                        element = temp;
                    }
                }
            }
            PrintArray(arr);
        }
        public string FindKCharacterOfDecryptedString(string encryptedString, int k)
        {
            string decrypetedString = string.Empty;
            string character = string.Empty;
            string count = string.Empty;
            for (int i = 0; i < encryptedString.Length; i++)
            {
                if (char.IsDigit(encryptedString[i]))
                {
                    count = string.Concat(count, encryptedString[i]);
                    string temp = string.Empty;
                    if (i + 1 == encryptedString.Length)
                    {
                        for (int j = 0; j < double.Parse(count); j++)
                        {
                            temp = temp + character;
                        }
                        decrypetedString = string.Concat(decrypetedString, temp);
                    }

                }
                else if (count == string.Empty)
                {
                    character = string.Concat(character, encryptedString[i]);
                }
                else
                {
                    string temp = string.Empty;
                    for (int j = 0; j < double.Parse(count); j++)
                    {
                        temp = temp + character;
                    }
                    decrypetedString = string.Concat(decrypetedString, temp);
                    count = string.Empty;
                    character = string.Empty;
                    i--;
                }
            }
            try
            {
                return $"Result {decrypetedString[k - 1]}, Decrypted String: {decrypetedString}";
            }
            catch (Exception ex)
            {
                return $"Can Not Find Character At {k + 1} Posation, Decrypted String: {decrypetedString}";
            }
        }
        public void Move0ToEnd(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0 && i + 1 != input.Length)
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        int temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join("", input));
        }
        public string SumofTwoElementsEqualstheThird(int[] arr)
        {
            List<string> lst = new List<string>();
            if (arr.Length >= 3)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (arr[i] + arr[j] == arr[k] || arr[j] + arr[k] == arr[i] || arr[i] + arr[k] == arr[j])
                                lst.Add($"[{arr[i]},{arr[j]},{arr[k]}]");
                            break;
                        }
                        break;
                    }
                }

            }
            if (lst.Count > 0)
                return string.Join(", ", lst);
            else
                return "Not Able to find Pairs";
        }
        public int MaximumSumCircularSubarray(int[] arr)
        {
            int size = arr.Length;
            int jSize = arr.Length;
            int maxSum = arr[0];
            bool secondTry = false;
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int j = i; j < jSize; j++)
                {
                    sum = sum + arr[j];
                    if (sum > maxSum)
                        maxSum = sum;
                    if (j + 1 == arr.Length && !secondTry)
                    {
                        j = -1;
                        secondTry = true;
                        jSize = i;
                    }
                }
                secondTry = false;
                jSize = arr.Length;
            }
            return maxSum;
        }
        public string LongestConsecutiveSequence(int[] arr)
        {
            int minStartIndex = 0, minEndIndex = 0;
            int maxStartIndex = 0, maxEndIndex = 0;
            int maxCount = 1;
            int count = 1;
            Array.Sort(arr);
            if (arr.Length == 1)
                return arr[0].ToString();


            if (arr.Length > 0)
            {
                int val = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (val + 1 == arr[i])
                    {
                        count++;
                        minEndIndex++;
                        val = arr[i];
                    }
                    else
                    {

                        minStartIndex = i; minEndIndex = i;
                        count = 1;
                        val = arr[i];
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStartIndex = minStartIndex;
                        maxEndIndex = i;

                    }
                }
                string longContinusString = string.Empty;
                for (int i = maxStartIndex; i <= maxEndIndex; i++)
                {
                    longContinusString = string.Concat(longContinusString, ",", arr[i]);
                }
                return longContinusString.Trim(',');
            }
            return "0";
        }
        private void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=======================================");
        }
        public int MaximumsubarraysumafterK(int[] arr, int k)
        {
            int[] arr2 = new int[] { };
            for (int i = 0; i < k; i++)
            {
                arr2 = arr2.Concat(arr).ToArray();
            }
            //Kadani's Algorithm
            int min = int.MinValue, max = 0;
            int s = 0, start = 0, end = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                max = max + arr2[i];
                if (max > min)
                {
                    min = max;
                    start = s;
                    end = i;
                }
                if (max < 0)
                {
                    max = 0;
                    s++;
                }
            }
            return min;

        }
        public string StringCalculater(string str1, string str2)
        {
            if (str1 == "0" || str2 == "0")
                return "0";
            if (str1.Length != str2.Length && str2.Length > str1.Length)
            {
                string temp = str2;
                str2 = str1;
                str1 = temp;
            }
            int[] arr1 = str1.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
            int[] arr2 = str2.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
            List<string> additionString = new List<string>();
            //Multiply
            for (int i = 0; i < arr2.Length; i++)// small length
            {
                int vaddi = 0;
                string additionStringForOne = new string('0', arr2.Length - 1 - i);
                for (int j = arr1.Length - 1; j >= 0; j--)//Long Lengtth
                {
                    string temp = (arr2[i] * arr1[j] + vaddi).ToString();
                    if (temp.Length > 1)
                        vaddi = int.Parse(temp) / 10;
                    else
                        vaddi = 0;
                    additionStringForOne = temp[temp.Length - 1].ToString() + additionStringForOne;
                }
                additionString.Add(vaddi != 0 ? vaddi + additionStringForOne : additionStringForOne);
            }
            int vaddiforAdd = 0;
            string result = string.Empty;
            int maxLength = additionString.Max(x => x.Length);
            //addition
            for (int i = 0; i < maxLength; i++)
            {
                List<int> Column = new List<int>();
                foreach (var sumString in additionString)
                {
                    if (sumString.Length - 1 - i >= 0)
                        Column.Add(int.Parse(sumString[sumString.Length - 1 - i].ToString()));
                }
                Column.Add(vaddiforAdd);
                string temp = Column.Sum(x => x).ToString();
                if (temp.Length > 1)
                    vaddiforAdd = int.Parse(temp) / 10;
                else
                    vaddiforAdd = 0;
                result = (i + 1 == maxLength ? vaddiforAdd + temp[temp.Length - 1].ToString() : temp[temp.Length - 1].ToString()) + result;
            }
            result = result.TrimStart('0');
            return result;
        }
        public string Missingandrepeatingnumbers(int[] arr)
        {
            Array.Sort(arr);
            int duplicate = -1;
            int missing = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 != arr.Length)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        duplicate = arr[i];
                        break;
                    }
                }
            }
            int[] arr2 = arr.Distinct().ToArray();
            for (int j = 0; j < arr2.Length - 1; j++)
            {
                if (arr2[j] + 1 != arr2[j + 1])
                {
                    missing = arr2[j] + 1;
                }
            }
            if (missing == -1 && arr2.Length + 1 == arr.Length)
                missing = arr2[arr2.Length - 1] + 1;
            return $"Meesing Number: {missing}, Duplicate Number: {duplicate}";
        }
        public void FindFourElementsThatSumsToAGivenValue(int[] arr, int find)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        for (int l = k + 1; l < arr.Length; l++)
                        {
                            if (arr[i] + arr[j] + arr[k] + arr[l] == find)
                            {
                                Console.WriteLine($"{arr[i]}, {arr[j]}, {arr[k]}, {arr[l]} : index of {i}, {j}, {k}, {l}");
                            }
                               
                        }
                    }
                }
            }
        }
        public int CountAllSubarraysWithGivenSum(int[] arr,int k)
        {
            int subArrayCount = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == k)
                    {
                        subArrayCount++;
                        //break;
                    }
                }
            }
            return subArrayCount;
        }
        public int Findnthelementsofspiralmatrix(int [,]arr, int find)
        {
            int counter = 0;
            int left = 0,right = arr.GetLength(1),up=0,down=arr.GetLength(0);
            for (int i = 0; i < down && left != right && up != down; i++)
            {
                for (int j = left; j < right; j++)
                {
                    ++counter;
                    if (counter == find)
                        return arr[up, j];
                    Console.Write(", "+arr[up, j]);
                }
                for(int k = up+1; k < down; k++)
                {
                    ++counter;
                    if (counter == find)
                        return arr[k, right - 1];
                    Console.Write(", "+arr[k, right-1]);
                }
                for(int l = right - 2; l > left; l--)
                {
                    ++counter;
                    if (counter == find)
                        return arr[down - 1, l];
                    Console.Write(", " + arr[down-1, l]);
                }
                for(int m = down - 1; m > up; m--)
                {
                    ++counter;
                    if (counter == find)
                        return arr[m, left];
                    Console.Write(", " + arr[m, left]);
                }
                left++;right--;up++;down--;
            }
            return 0;
        }
    }
}
