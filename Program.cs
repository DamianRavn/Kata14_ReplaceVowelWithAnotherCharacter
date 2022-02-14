using System;
using System.Collections.Generic;
using System.Text;

namespace Replace_Vowel_with_Another_Character
{
    class Program
    {
        static Dictionary<char, int> lookUp = new Dictionary<char, int>() { { 'a', 1 }, { 'e', 2 }, { 'i', 3 }, { 'o', 4 }, { 'u', 5 } };
        static void Main(string[] args)
        {


            replaceVowel("karAchi", "k1r1ch3"); // ➞ "k1r1ch3"

            replaceVowel("chEmBur", "ch2mb5r"); // ➞ "ch2mb5r"

            replaceVowel("khandbari", "kh1ndb1r3"); // ➞ "kh1ndb1r3"

            replaceVowel("LexiCAl", "l2x3c1l"); // ➞ "l2x3c1l"

            replaceVowel("fuNctionS", "f5nct34ns"); // ➞ "f5nct34ns"

            replaceVowel("EASY", "21sy"); // ➞ "21sy"

        }

        static void replaceVowel(string vs, string expectedOutcome)
        {
            vs = vs.ToLower();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < vs.Length; i++)
            {
                if (lookUp.TryGetValue(vs[i], out int val))
                {
                    result.Append(val.ToString());
                    continue;
                }
                result.Append(vs[i]);
            }
            Console.WriteLine("result is: " + result.ToString() + " expected result is: " + expectedOutcome + " outcome is: " + (result.ToString() == expectedOutcome));
        }
    }
}
