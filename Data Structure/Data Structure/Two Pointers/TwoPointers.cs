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
