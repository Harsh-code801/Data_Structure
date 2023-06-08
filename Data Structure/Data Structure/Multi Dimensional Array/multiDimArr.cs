using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Multi_Dimensional_Array
{
    internal class MultiDimArr
    {
        public bool iSSymmetricMatrix(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
                return false;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != arr[j, i])
                        return false;
                }
            }
            return true;
        }
    }
}
