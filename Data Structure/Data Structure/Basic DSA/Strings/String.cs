using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Basic_DSA.Strings
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
        public string NextSmallestPalindrome(string inputeString,bool add = true)// add is for recursive call
        {
            string []flow = (inputeString.Length / 2).ToString().Split(".");

            if (inputeString.Count(x=>x == '9') == inputeString.Length)
            {
                return (int.Parse(inputeString) + 1).ToString();
            }
            else if (inputeString.Length % 2 == 0)
            {
                double temp = double.Parse(string.Concat(inputeString.Substring(0, inputeString.Length / 2), string.Join("", string.Concat(inputeString.Substring(0, inputeString.Length / 2).Reverse().ToArray()))));
                if (double.Parse(inputeString) < temp)
                {
                    return temp.ToString();
                }
                else
                {
                    string firstString = (int.Parse(inputeString.Substring(0, inputeString.Length / 2)) + 1).ToString();
                    return string.Concat(firstString, string.Join("", firstString.Reverse().ToArray()));
                }

            }
            else
            {
                int middleNumber = int.Parse(flow[0]);
                string firstString = inputeString.Substring(0, middleNumber);
                string secondString = inputeString.Substring(middleNumber + 1, inputeString.Length - (middleNumber+1));
                int temp = int.Parse(inputeString[middleNumber].ToString());
                if (temp == 9)
                {
                    inputeString = string.Concat((int.Parse(string.Concat(firstString, temp)) + 1).ToString(), secondString);
                    return NextSmallestPalindrome(inputeString, false);
                }
                if(Double.Parse(inputeString)<double.Parse(string.Concat(firstString, add ? (int.Parse(inputeString[middleNumber].ToString())).ToString() : inputeString[middleNumber].ToString(), string.Join("", firstString.Reverse().ToArray()))))
                {
                    return string.Concat(firstString, add ? (int.Parse(inputeString[middleNumber].ToString())).ToString() : inputeString[middleNumber].ToString(), string.Join("", firstString.Reverse().ToArray()));
                }
                return string.Concat(firstString, add ? (int.Parse(inputeString[middleNumber].ToString()) + 1).ToString() : inputeString[middleNumber].ToString(), string.Join("", firstString.Reverse().ToArray()));

            }
        }
    }
}
