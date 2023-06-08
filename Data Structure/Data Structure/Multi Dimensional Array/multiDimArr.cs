using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Multi_Dimensional_Array
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
            for (int i = 0; i < oldMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < oldMatrix.GetLength(1); j++)
                {
                    Console.Write(oldMatrix[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("======================================");
            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newRow = 0, neweColumn = 0;
            for(int i = oldMatrix.GetLength(1); i >= 0; i++)
            {
                for (j = 0; j > oldMatrix.GetLength(0); j++)
                {
                    newMatrix[newRow,newColumn]
                }
            }


























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

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write(newMatrix[i,j]+" ");
                }
                Console.WriteLine("\n");
            }

            return newMatrix;
        }
    }
}
