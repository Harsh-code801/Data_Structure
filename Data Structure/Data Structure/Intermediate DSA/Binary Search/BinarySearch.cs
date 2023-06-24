using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
