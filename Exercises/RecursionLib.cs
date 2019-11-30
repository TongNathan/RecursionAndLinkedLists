using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class RecursionLib
    {
        public int FactorialRec(int num, int ans = 1)
        {
            if (num == 0)
            {
                return ans;
            }

            return FactorialRec(num - 1, ans * num);
        }

        public List<int> CountRec(int num, List<int> numsList)
        {
            int lCount = numsList.Count;
            if (lCount == num)
            {
                return numsList;
            }

            numsList.Add(lCount + 1);
            return CountRec(num, numsList);
        }
        public long ExponentialRec(int num, int pow, long ans = 1)
        {
            if (pow == 0)
            {
                return ans;
            }
            ans = ans * num;

            pow--;
            return ExponentialRec(num, pow, ans);
        }

        public string WordReverseRec(string word, string revWord = "")
        {
            int counter = revWord.Length;
            if (revWord.Length == word.Length)
            {
                return revWord;
            }

            revWord += word[word.Length - 1 - counter];
            return WordReverseRec(word, revWord);
        }
    }
}