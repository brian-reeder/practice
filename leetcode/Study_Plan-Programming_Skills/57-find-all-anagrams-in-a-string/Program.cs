/*
File Name: 
    57-find-all-anagrams-in-a-string/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:41

Description:
    Given two strings s and p, return an array of all the start indices of p's
    anagrams in s. You may return the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters of a
    different word or phrase, typically using all the original letters exactly
    once.

Constraints:
    1 <= s.length, p.length <= 3 * 10^4
    s and p consist of lowercase English letters.
*/
namespace FindAllAnagramsInAString {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, string, int[])[] {
                ("cbaebabacd", "abc", new int[] {0,6}),
                ("abab", "ab", new int[] {0,1,2}),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.FindAnagrams(test.Item1, test.Item2);
                Console.WriteLine($"Input: s = \"{test.Item1}\", p = \"{test.Item2}\"");
                Console.WriteLine($"Output: [{String.Join(',', output)}]");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}