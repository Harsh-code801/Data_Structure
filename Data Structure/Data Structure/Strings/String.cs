using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Strings
{
    internal class String
    {
        public string ReverseStringWordWise(string inputeString)
        {
            string result = string.Empty;
            string[] splitString =  inputeString.Split(" ");

            for(int i = splitString.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(splitString[i]))
                    result = string.Join(" ", result, splitString[i]);
            }
            return result.Trim(' ');
        }
    }
}
