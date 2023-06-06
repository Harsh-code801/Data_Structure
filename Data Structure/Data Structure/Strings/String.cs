using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Strings
{
    internal class String
    {
        public string ReverseStringWordWise(string inputString)
        {
            string result = string.Empty;
            string[] splitString =  inputString.Split(" ");

            for(int i = splitString.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(splitString[i]))
                    result = string.Join(" ", result, splitString[i]);
            }
            return result.Trim(' ');
        }
        public string encodingMessage(string inputString)
        {
            string resultString = string.Empty;
            if (inputString.Length>0)
            {
                char currentChar = inputString[0];
                int counter = 1;
                for (int i = 1; i < inputString.Length; i++)
                {
                    if (inputString[i] == currentChar)
                        counter++;
                    else
                    {
                        resultString = string.Concat(resultString, currentChar, counter);
                        currentChar = inputString[i];
                        counter = 1;
                    }
                } 
            }
            return resultString;
        }
    }
}
