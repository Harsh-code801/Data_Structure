using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<KeyValuePair<int,int>> lst = new List<KeyValuePair<int,int>>();
            for(int i = 0; i < arr.Length; i++) 
            {
                int count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                lst.Add(new KeyValuePair<int, int>(arr[i], count));
            }
            return string.Join(", ", lst.DistinctBy(x => x.Key).Where(x => x.Value > arr.Length / 3).ToList().Select(x=>x.Key));
        }
    }
}
