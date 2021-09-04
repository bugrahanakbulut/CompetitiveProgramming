using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class DecodeString_Solution
    {
        public string DecodeString(string s) 
        {
            return DecodeString(1, s);
        }

        private string DecodeString(int numberOfRepetition, string s)
        {
            string res = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    string k = "";

                    while (s[i] >= 48 && s[i] <= 57)
                    {
                        k += s[i];

                        i++;
                    }

                    Stack<char> pStack = new Stack<char>();

                    pStack.Push(s[i]);
                    i++;

                    string str = "";

                    while (pStack.Count != 0)
                    {
                        if (s[i] == ']')
                        {
                            pStack.Pop();
                        }

                        else if (s[i] == '[')
                        {
                            pStack.Push(s[i]);
                        }

                        if (pStack.Count != 0)
                        {
                            str += s[i];

                            i++;
                        }
                    }

                    res += DecodeString(Int32.Parse(k), str);
                }
                else
                {
                    res += s[i];
                }
            }

            string multipleRes = "";

            for (int i = 0; i < numberOfRepetition; i++)
            {
                multipleRes += res;
            }

            return multipleRes;
        }
    }
}