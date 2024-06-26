﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Intermediate_DSA.Binary_Search
{
    internal class BinarySearch
    {
        public int SquareRoot(int number)
        {
            int result = 0;
            int i = 1;

            while (result <= number)
            {
                i++;
                result = i * i;
            }
            return i - 1;
        }
        #region Search In Rotated Sorted Array (Binary Search)
        public int pivotedBinarySearch(int[] arr, int n, int key)
        {
            int pivot = findPivot(arr, 0, n - 1);

            // If we didn't find a pivot, then
            // array is not rotated at all
            if (pivot == -1)
                return binarySearch(arr, 0, n - 1, key);

            // If we found a pivot, then first
            // compare with pivot and then
            // search in two subarrays around pivot
            if (arr[pivot] == key)
                return pivot;

            if (arr[0] <= key)
                return binarySearch(arr, 0, pivot - 1, key);

            return binarySearch(arr, pivot + 1, n - 1, key);
        }
        private int findPivot(int[] arr, int l, int r)
        {
            if (l > r)
                return -1;
            if (l == r)
                return l;
            int mid = (l + r) / 2;
            if (mid < r && arr[mid] > arr[mid + 1])
                return mid;
            if (mid > l && arr[mid] < arr[mid - 1])
                return mid - 1;

            if (arr[l] >= arr[mid])
                return findPivot(arr, l, mid - 1);

            return findPivot(arr, mid + 1, r);

        }
        private int binarySearch(int[] arr, int l, int r, int key)
        {
            if (l > r)
                return -1;
            int mid = (l + r) / 2;
            if (arr[mid] == key)
                return mid;
            if (key > arr[mid])
                return binarySearch(arr, mid + 1, r, key);

            return binarySearch(arr, l, mid - 1, key);
        }
        #endregion
        public int SingleElementinaSortedArray(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (arr[i] != arr[i + 1])
                        return arr[i];
                }
                else if (i + 1 == arr.Length)
                {
                    if (arr[i] != arr[i - 1])
                        return arr[i];
                }
                else if (!(arr[i] == arr[i - 1] || arr[i] == arr[i + 1]))
                    return arr[i];

            }
            return -1;

            /*int XOR = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                XOR = XOR ^ arr[i];
            }
            return XOR;*/
        }
        public int MatrixMedian(int[,] arr)
        {
            int[] arr2 = new int[arr.GetLength(0) * arr.GetLength(1)];
            int index = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[index] = arr[i, j];
                    index++;
                }
            }
            Array.Sort(arr2);
            return arr2[arr2.Length / 2];
        }
        public int AggressiveCows(int []arr,int cowsCount)
        {
            Array.Sort(arr);
            int max_dist = arr[arr.Length - 1];
            int ans = -1;
            /*
                try out each possible distance 
                from 1 to max_dist
                store the distance in ans, 
                if the arrangement is possible
                otherwise, break.
            */
            for (int dist = 1; dist <= max_dist; dist++)
            {
                if (isPossible(arr, dist, arr.Length, cowsCount))
                {
                    ans = dist;
                }
                else
                {
                    break;
                }
            }
            return ans;
        }
        private bool isPossible(int[] arr, int dist, int N, int K)
        {
            int count = 1;

            // place a cow at 1st position
            int prev = arr[0];

            for (int i = 0; i < N; i++)
            {
                // check if we can place a cow at that position
                if (arr[i] - prev >= dist)
                {
                    prev = arr[i];
                    count++;
                }
            }
            // all the cows are placed
            if (count >= K)
                return true;
            return false;
        }
    }
}
