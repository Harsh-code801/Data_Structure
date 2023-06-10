using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]) && input[i] !=' ' && input[i] != '\r' && input[i] != '\n')
                {
                    if(input.Count(x => x == input[i]) == 1)
                        return input[i];
                }
            }
            return '0';
        }
        public int[] LongestSubarrayZeroSum(int[] arr)
        {
            List<KeyValuePair<int, string>> lst = new List<KeyValuePair<int, string>>(); 
            for(int i= 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    temp += arr[j];
                    if(temp == 0)
                    {
                        if (j == i)
                            lst.Add(new KeyValuePair<int, string>(1, $"{j}-{j}"));
                        else
                            lst.Add(new KeyValuePair<int, string>((j - i)+1, $"{i}-{j}"));
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
    }
}
