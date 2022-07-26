/*
File Name: 
    31-valid-anagram/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 17:16:26

Description:
    Given two strings s and t, return true if t is an anagram of s, and false
    otherwise.

    An Anagram is a word or phrase formed by rearranging the letters of a
    different word or phrase, typically using all the original letters exactly
    once.
*/
namespace ValidAnagram {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, string, bool)[] {
                 
                 ("anagram", "nagaram", true)
                ,("rat", "car", false)
            };

            var solve = new Solution();
            foreach((string, string, bool) t in testcases) {
                Console.WriteLine($"Input: s=\"{t.Item1}\" t=\"{t.Item2}\"");
                var x = solve.IsAnagram(t.Item1, t.Item2);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {t.Item3 == x}\n");
            }
        }
    }
}