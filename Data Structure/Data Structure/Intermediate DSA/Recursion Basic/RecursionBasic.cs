﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Intermediate_DSA.Recursion_Basic
{
    internal class RecursionBasic
    {
        #region MargeSort
        public string MargeSort(int[] arr)
        {
            DivideAndMarge(arr, 0, arr.Length - 1);
            return string.Join(", ", arr);
        }
        private void DivideAndMarge(int[] arr, int l, int r)
        {
            int mid = (l + r - 1) / 2;
            if (l < r)
            {
                DivideAndMarge(arr, l, mid);
                DivideAndMarge(arr, mid + 1, r);

                MargeArrayInOrder(arr, l, mid, r);
            }
        }
        private void MargeArrayInOrder(int[] arr, int l, int mid, int r)
        {
            int n1 = mid - l + 1;
            int n2 = r - mid;
            int[] left = new int[n1];
            int[] right = new int[n2];

            for (int p = 0; p < n1; p++)
            {
                left[p] = arr[l + p];
            }
            for (int q = 0; q < n2; q++)
            {
                right[q] = arr[mid + 1 + q];
            }

            int i = 0;
            int j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else if (left[i] > right[j])
                {
                    arr[k] = right[j];
                    j++;
                }
                else if (left[i] == right[j])
                {
                    i++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
        #endregion

        #region Quick Sort
        public string QuickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int pivote = divide(arr, l, r);

                QuickSort(arr, l, pivote - 1);
                QuickSort(arr, pivote + 1, r);
            }

            return string.Join(", ", arr);
        }
        private int divide(int[] arr, int l, int r)
        {
            int pivote = arr[r];

            int i = l - 1;
            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] < pivote)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }
            int temp2 = arr[r];
            arr[r] = arr[i + 1];
            arr[i + 1] = temp2;

            return i + 1;
        }
        #endregion

        public int FindKthElement(int[] arr1, int[] arr2, int k)
        {
            int i = 0; int j = 0;
            List<int> list = new List<int>();
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    list.Add(arr2[j]);
                    j++;
                }
                else if (arr1[i] == arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                }
            }
            while (i < arr1.Length)
            {
                list.Add(arr1[i]);
                i++;
            }
            while (j < arr2.Length)
            {
                list.Add(arr2[j]);
                j++;

            }
            Console.WriteLine($"\nMarge Sorted Array: {string.Join(", ", list)}");
            return list[k];
        }

        public string FamilyStructure(int level, int child)
        {
            if (level == 1)
                return "Mail";
            Console.WriteLine("Level " + level);
            // Recursively find parent's
            // profession. If parent
            // is a Doctor, this node
            // will be a Doctor if it
            // is at odd position and an
            // engineer if at even position
            if (FamilyStructure(level - 1,
                              (child + 1) / 2) == "Femail")
                return (child % 2 > 0) ?
                                 "Femail" : "Mail";

            // If parent is an engineer,
            // then current node will be
            // an engineer if at add
            // position and doctor if even
            // position.
            return (child % 2 > 0) ?
                             "Mail" : "Femail";
        }
    }
}
