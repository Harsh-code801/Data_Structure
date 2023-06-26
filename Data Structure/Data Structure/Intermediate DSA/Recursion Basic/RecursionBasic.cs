using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Intermediate_DSA.Recursion_Basic
{
    internal class RecursionBasic
    {
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
    }
}
