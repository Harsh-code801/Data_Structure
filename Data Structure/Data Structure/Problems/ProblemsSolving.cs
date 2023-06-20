using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structure.Problems
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
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        for (int k = j+1; k < arr.Length; k++)
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
    }
}
