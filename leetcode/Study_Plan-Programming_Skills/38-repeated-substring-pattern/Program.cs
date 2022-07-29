/*
File Name: 
    38-repeated-substring-pattern/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 29, 2022, 18:27:53

Description:
    Given a string s, check if it can be constructed by taking a substring of
    it and appending multiple copies of the substring together.

Constraints:
    1 <= s.length <= 104
    s consists of lowercase English letters.
*/
namespace RepeatedSubstringPattern {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, bool)[] {
                 ("abab", true)
                ,("aba", false)
                ,("abcabcabcabc", true)
                ,("aaaaaaaaaaa", true)
                ,("aaaaaaaaaab", false)
            };

            var solve = new Solution();
            foreach(var t in  testcases) {
                var output = solve.RepeatedSubstringPattern(t.Item1);
                Console.WriteLine($"Input: s = \"{t.Item1}\"");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {t.Item2.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}