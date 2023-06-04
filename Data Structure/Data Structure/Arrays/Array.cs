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
    }
}
