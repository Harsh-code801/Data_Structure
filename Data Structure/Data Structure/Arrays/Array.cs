using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Arrays
{
    internal class Array
    {
        public int SecondLargestNumber(int[] arr,int length)
        {
            //#region First Solution
            //arr = arr.Distinct().Reverse().ToArray();
            //if (arr.Length > 3)
            //    return arr[1];
            //#endregion
            int firstLargest = 0;
            int secondLargest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = arr[i];
                }
                else if (arr[i] < firstLargest && arr[i] > secondLargest)
                    secondLargest = arr[i];
            }
            if(secondLargest == 0)// check is all items in array are same
            {
                int temp = arr[0];
                bool sameNumber = true;
                foreach(int n in arr)
                {
                    if(temp != n)
                        sameNumber = false;
                }
                if (sameNumber)
                    Console.WriteLine("Second Largest Number not found");
            }
            return secondLargest;
        }
        public void RotateElementByK(int[] arr, int length, int k)
        {
            #region Second Solution
            //Console.WriteLine("input: " + string.Join(",", arr));
            //for(int i = 0;i<k; i++)
            //ReverseArray(arr);

            //Console.WriteLine("Result: " + string.Join(",", arr)); 
            #endregion

            Console.WriteLine("Input: " + string.Join(",", arr));
            int[] resultArr = new int[length];
            int mod = k % length;
            for (int i = 0; i < length; ++i)
                resultArr[i] = arr[(i + mod) % length];
            Console.WriteLine("Result: " + string.Join(",", resultArr));
        }
        private int[] ReverseArray(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int temp = arr[i+1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        private int[] ForwordArray(int[] arr)
        {
            int lastnumber = arr[arr.Length - 1];
            for (int i = arr.Length-2; i >=0; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[0] = lastnumber;
            return arr;
        }
        public bool IsNonDecrisingArray(int[] arr,int length)
        {
            bool isChange = false;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                    continue;
                if(isChange)
                    return false;
                if(i==0 || arr[i + 1] >= arr[i-1])
                    arr[i] = arr[i+1];
                else
                    arr[i+1] = arr[i];
                isChange = true;
            }
            return true;
        }
    }
}
