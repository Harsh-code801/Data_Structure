using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Two_Pointers
{
    internal class TwoPointers
    {
        public int PairSum(int[] arr, int k)
        {
            List<KeyValuePair<int, int>> lst = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == k)
                        lst.Add(new KeyValuePair<int, int>(arr[i], arr[j]));
                }
            }
            DisplayKeyValuePairList(lst);
            return lst.Count;
        }
        public int containerWithMostWater(int[] arr)
        {
            List<KeyValuePair<int, string>> lst = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    lst.Add(new KeyValuePair<int, string>((j - i) * Math.Min(arr[i], arr[j]), $"{i}-{j}"));
                }
            }
            var result = lst.OrderByDescending(x => x.Key).FirstOrDefault();
            Console.WriteLine("Max Water Capicity With Pol Between " + result.Value);
            return result.Key;
        }

        public bool IsSubSequence(string str1, string str2)
        {
            if (str1.Length == 0)
                return true;
            if (str2.Length == 0)
                return false;

            int secondLoopStartingWith = 0;
            int matchCount = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = secondLoopStartingWith; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        secondLoopStartingWith = j + 1;
                        matchCount++;
                        break;
                    }
                }
            }
            return matchCount == str1.Length;
        }
        private void DisplayKeyValuePairList(List<KeyValuePair<int, int>> lst)
        {
            Console.WriteLine("========================================");
            foreach (var n in lst)
            {
                Console.WriteLine($"[{n.Key},{n.Value}]");
            }
            Console.WriteLine("========================================");
        }
    }
}
