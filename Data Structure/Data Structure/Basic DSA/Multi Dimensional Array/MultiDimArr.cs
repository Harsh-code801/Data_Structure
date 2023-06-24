using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Basic_DSA.Multi_Dimensional_Array
{
    internal class MultiDimArr
    {
        public bool ISSymmetricMatrix(int[,] arr)
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

        public int[,] RotateMatrixBy90Degree(int[,] oldMatrix)
        {
            PrintMatrix(oldMatrix);
            
            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newRow = 0, newColumn = 0;
            for (int oldColumn = oldMatrix.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
            {
                newColumn = 0;
                for (int oldRow = 0; oldRow < oldMatrix.GetLength(0); oldRow++)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }

            PrintMatrix(newMatrix);

            return newMatrix;
        }
        public int[,] SetMatrixZero(int[,] arr)
        {
            PrintMatrix(arr);

            List<KeyValuePair<int,int>> lstZeroContains = new List<KeyValuePair<int, int>>();

            for(int row = 0; row < arr.GetLength(0); row++)
            {
                for(int column = 0; column < arr.GetLength(1); column++)
                {
                    if (arr[row,column] == 0)
                    {
                        lstZeroContains.Add(new KeyValuePair<int, int>(row, column));
                    }
                }
            }
            foreach(var n in lstZeroContains)
            {
                for (int Column2 = 0; Column2 < arr.GetLength(1); Column2++)
                    arr[n.Key, Column2] = 0;
                for (int Row2 = 0; Row2 < arr.GetLength(0); Row2++)
                    arr[Row2, n.Value] = 0;
            }
            PrintMatrix(arr);
            return arr;
        }

        public string SpiralOrder(int[,] arr)
        {
            int l = 0, R = arr.GetLength(1);
            int u = 0, d = arr.GetLength(0);

            List<int> result = new List<int>();
            for (int row1 = u; row1 < d && l != R && u != d; row1++)
            {
                for(int col1 = l; col1 < R; col1++)//upper L->R
                {
                    result.Add(arr[row1,col1]);
                }
                for(int row2 = u + 1; row2 < d; row2++)//Right U->D
                {
                    result.Add(arr[row2, R-1]);
                }
                for(int col2 = R - 2; col2 > l; col2--)//Down R->L
                {
                    result.Add(arr[d-1, col2]);
                }
                for(int row3 = d - 1; row3 > u; row3--)//Left D->U
                {
                    result.Add(arr[row3, l]);
                }
                l++;R--;u++;d--;

            }
            return string.Join(",", result);
        } 

        private void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("========================================");
        }
    }
}
