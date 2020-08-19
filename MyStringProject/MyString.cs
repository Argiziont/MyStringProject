using System;
using System.Collections.Generic;
using System.Linq;

namespace MyStringProject
{
    class MyString
    {
        public char[] CharArray { get { return CharList.ToArray(); } private set { } }
        public int Length { get { return CharList.Count; } private set { } }

        private List<char> CharList;
        public MyString()
        {
            CharList = new List<char>();
        }
        public MyString(params char[] charArr)
        {
            CharList = charArr.ToList();
        }
        public MyString(string charArr)
        {
            CharList = charArr.ToCharArray().ToList();
        }
        public MyString(int charArr)
        {
            CharList = charArr.ToString().ToCharArray().ToList();
        }
        public MyString(float charArr)
        {
            CharList = charArr.ToString().ToCharArray().ToList();
        }
        public MyString(double charArr)
        {
            CharList = charArr.ToString().ToCharArray().ToList();
        }
        public MyString(decimal charArr)
        {
            CharList = charArr.ToString().ToCharArray().ToList();
        }
        public void AppendAtStart(params char[] appendChars)
        {
            for (int i = appendChars.Length-1; i >= 0; i--)
            {
                CharList.Insert(0, appendChars[i]);
            }
        }
        public void AppendAtEnd(params char[] appendChars)
        {
            foreach (char appendChar in appendChars)
            {
                CharList.Add(appendChar);
            }
        }
        public char[] SubString(int index)
        {
            return new char[] { CharList[index] };
        }
        public char[] SubString(int index, int count)
        {
            return CharList.GetRange(index, count).ToArray();
        }
        public int CountWords()
        {
            bool startCounting = true;
            int counter = 0;
            for (int i = 0; i < CharList.Count; i++)
            {
                if (CharList[i] == ' ')
                    startCounting = true;

                if (startCounting&& CharList[i]!=' ')
                {
                    counter++;
                    startCounting = false;
                }
            }
            return counter;
        }
        public int CountSentences()
        {
            bool startCounting = true;
            int counter = 0;
            for (int i = 0; i < CharList.Count; i++)
            {
                if (CharList[i] == '.')
                    startCounting = true;

                if (startCounting && CharList[i] != '.')
                {
                    counter++;
                    startCounting = false;
                }
            }
            return counter;
        }
    }
}
