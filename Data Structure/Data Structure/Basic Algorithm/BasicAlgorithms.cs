using System;
using System.Collections;
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
            Console.WriteLine("=====================================");
        }
        public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Bubble Sort: " + string.Join(", ", arr));
            Console.WriteLine("=====================================");
        }
        public void kadanisAlgorithm(int[] arr)
        {
            int min = int.MinValue, max = 0;
            int s = 0, start = 0, end = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max = max + arr[i];
                if (min < max)
                {
                    min = max;
                    start = s;
                    end = i;
                }
                if (max < 0)
                {
                    max = 0;
                    s++;
                }
            }
            Console.WriteLine("Input: " + string.Join(", ", arr));
            Console.WriteLine("Max sum Is " + min + " With Rage of " + start + " - " + end);
            Console.WriteLine("=====================================");
        }
        public void DatchNationalFlagAlgorithm(int[] arr)
        {
            Console.WriteLine("Input: " + string.Join(", ", arr));
            int lo = 0, mid = 0, max = arr.Length - 1;
            while (mid <= max)
            {
                if (arr[mid] == 0)
                {
                    int temp = arr[mid];
                    arr[mid] = arr[lo];
                    arr[lo] = temp;
                    lo++;
                    mid++;
                }
                if (arr[mid] == 1)
                    mid++;
                if (arr[mid] == 2)
                {
                    int temp = arr[mid];
                    arr[mid] = arr[max];
                    arr[max] = temp;
                    max--;
                }
            }
            Console.WriteLine("Datch National Flag Algorithm: " + string.Join(", ", arr));
            Console.WriteLine("=====================================");
        }

        public void MooreWatingAlgorithm(int[] arr)
        {
            int index = -1, maxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count > maxSum)
                {
                    maxSum = count;
                    index = i;
                }
            }
            if (maxSum > arr.Length / 2)
                Console.WriteLine("Majority Element: " + arr[index]);
            else
                Console.WriteLine("No Majority Element Found");

            Console.WriteLine("=====================================");
        }
    }
}
