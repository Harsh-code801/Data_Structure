using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structure.Map_And_Set
{
    internal class MapAndSet
    {
        public int MakeUniqueArray(int[] arr)//to Distinct array how many element you remove
        {
            #region Solution 1
            int removeCount = 0;
            return arr.Length - arr.Distinct().ToArray().Length;
            #endregion


            #region Solution 2
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!list.Contains(arr[i]))
                    list.Add(arr[i]);
            }
            return arr.Length - list.Count;
            #endregion
        }
        public char FirstNonRepeatingCharacter(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]) && input[i] != ' ' && input[i] != '\r' && input[i] != '\n')
                {
                    if (input.Count(x => x == input[i]) == 1)
                        return input[i];
                }
            }
            return '0';
        }
        public int[] LongestSubarrayZeroSum(int[] arr)
        {
            List<KeyValuePair<int, string>> lst = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    temp += arr[j];
                    if (temp == 0)
                    {
                        if (j == i)
                            lst.Add(new KeyValuePair<int, string>(1, $"{j}-{j}"));
                        else
                            lst.Add(new KeyValuePair<int, string>((j - i) + 1, $"{i}-{j}"));
                    }
                }
            }
            if (lst.Count > 0)
            {
                var lstRes = lst.OrderByDescending(x => x.Key).FirstOrDefault();
                int[] arr2 = Array.ConvertAll(lstRes.Value.Split('-').ToArray(), S => int.Parse(S));
                int[] result = new int[lstRes.Key];
                Array.Copy(arr, arr2[0], result, 0, lstRes.Key);
                return result;
            }
            else
            {
                return new int[] { };
            }
        }

        public int CountAllSubarraysHavingSumDivisibleByK(int[] arr, int k)
        {
            int ResultCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    temp += arr[j];
                    if ((Double)temp / k == 0.0 || (Double)temp / k == -0.0 || (Double)temp / k == 1 || (Double)temp / k == -1)
                        ResultCount++;
                }
            }
            return ResultCount;
        }
        public List<List<String>> GroupAnagrams(string[] input)
        {
            List<List<string>> lst = new List<List<string>>();
            for(int i = 0; i < input.Length; i++)
            {
                List<string> temp = new List<string>();
                for(int j = i+1; j < input.Length; j++)
                {
                    if (!string.IsNullOrEmpty(input[i]))
                    {
                        char[] arr = input[i].ToCharArray();
                        int charCount = arr.Length;
                        if (input[j].Length == arr.Length)
                        {
                            for (int k = 0; k < arr.Length; k++)
                            {
                                if (input[j].Contains(arr[k]))
                                    charCount--;
                            } 
                        }
                        if(charCount == 0)
                        {
                            temp.Add(input[j]);
                            input[j] = "";
                        }
                    }
                }
                if (temp.Count > 0)
                {
                    temp.Add(input[i]);
                    lst.Add(temp);
                }
            }
            PrintNestedList(lst);
            return lst;
        }
        private void PrintNestedList (List<List<String>> lst)
        {
            for(int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(String.Join(" ||| ", lst[i]));
            }
        }
    }
}
