using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    internal class LongestSubstringWithoutRepeating
    {
        // Longest Substring Without Repeating Characters
        public static void Main(string[] args)
        {
            string str = "abcabcbb";

            Hashtable ht = new Hashtable();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < str.Length; right++)
            {
                char ch = str[right];

                if (ht.ContainsKey(ch))
                {
                    left = Math.Max(left, (int)ht[ch] + 1);
                }

                ht[ch] = right;

                int length = right - left + 1;

                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

        }
    }
}
