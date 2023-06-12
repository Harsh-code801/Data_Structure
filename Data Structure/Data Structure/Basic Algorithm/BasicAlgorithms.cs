using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Basic_Algorithm
{
    internal class BasicAlgorithms
    {
        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            Console.WriteLine("Insertion Sort: " + String.Join(", ", arr));
        }

        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int remainingSmallestNumberIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[remainingSmallestNumberIndex])
                    {
                        remainingSmallestNumberIndex = j;
                    }
                }
                int temp = arr[remainingSmallestNumberIndex];
                arr[remainingSmallestNumberIndex] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("Selection Sort: " + string.Join(", ", arr));
        }
    }
}
