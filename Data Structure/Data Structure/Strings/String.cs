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
        public string EncodingMessage(string inputString)
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
        public int MiniumParanthesis(string inputString) 
        {
            int OpeningBracketCount = 0;
            int missingCount = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ')' && OpeningBracketCount <= 0)
                {
                    missingCount++;
                }
                else if (inputString[i] == ')' && OpeningBracketCount >0)
                {
                    OpeningBracketCount--;
                }
                else if (inputString[i] == '(')
                    OpeningBracketCount++;

            }
            if (OpeningBracketCount > 0)
                missingCount += OpeningBracketCount;
            return missingCount;
        }
        public int BeautifyStringWithMinChanges(string inputString)
        {
            //int changesCount = 0;
            //char[] inputStringarr = inputString.ToCharArray();
            //for (int i = 1; i < inputStringarr.Length - 1; i++)
            //{
            //    if (inputStringarr[i-1] == '0' && inputStringarr[i] == '1' && inputStringarr[i+1] == '0')
            //    {
            //        inputStringarr[i+1] = '1';
            //        changesCount++;
            //    }
            //}
            //return changesCount;



            int t1 = 0,t2 = 0;
            char s1 = '0', s2 = '1';


            for(int i=0;i<inputString.Length;i++)
            {
                if (inputString[i] == '1')
                {
                    if (s1 == '1')
                        t1++;
                    else
                        t2++;
                }
                else
                {
                    if (s1 == '0')
                        t1++;
                    else
                        t2++;
                }
                if(s1 == '1')
                {
                    s1 = '0';
                    s2 = '1';
                }
                else
                {
                    s1 = '1';
                    s2 = '0';
                }
            }
            return Math.Min(t1,t2);
        }
    }
}
