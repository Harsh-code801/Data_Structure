using System;
using System.Collections.Generic;
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
    }
}
