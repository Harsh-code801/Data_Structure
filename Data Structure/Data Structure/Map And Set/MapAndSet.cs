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

    }
}
