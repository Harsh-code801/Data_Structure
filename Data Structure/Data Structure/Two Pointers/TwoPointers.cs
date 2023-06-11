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
