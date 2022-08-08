/*
File Name: 
    56-group-anagrams/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:22

Description:
    Given an array of strings strs, group the anagrams together. You can return
    the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters of a
    different word or phrase, typically using all the original letters exactly
    once.

Constraints:
    1 <= strs.length <= 104
    0 <= strs[i].length <= 100
    strs[i] consists of lowercase English letters.
*/
namespace GroupAnagrams {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string[], string[][])[] {
                (new string[] {"eat","tea","tan","ate","nat","bat"},
                new string[][] {
                    new string[] {"bat"},
                    new string[] {"nat","tan"},
                    new string[] {"ate","eat","tea"}
                }),
                (new string[] {""}, new string[][] {new string[] {""}}),
                (new string[] {"a"}, new string[][] {new string[] {"a"}}),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.GroupAnagrams(test.Item1);
                var prettyOutput = ListToString(output);
                Console.WriteLine($"Input: strs = [{String.Join(',', test.Item1)}]");
                Console.WriteLine($"Output: {prettyOutput}");
                Console.WriteLine($"Pass: ");
                Console.WriteLine();
            }
        }

        public static string ListToString(IList<IList<string>> strings) {
            var s = new List<string>();
            foreach(var row in strings)
                s.Add($"[{String.Join(',', row)}]");

            return $"{String.Join(',', s)}";
        }
    }
}