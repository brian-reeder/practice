/*
File Name: 
    35-monotonic-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 28, 2022, 15:38:57

Description:
    Implement strStr().

    Given two strings needle and haystack, return the index of the first
    occurrence of needle in haystack, or -1 if needle is not part of haystack.

Constraints:
    1 <= haystack.length, needle.length <= 104
    haystack and needle consist of only lowercase English characters.
*/
namespace ImplementStrStr {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, string, int)[] {
                 ("a", "a", 0)
                ,("a", "b", -1)
                ,("aa", "a", 0)
                ,("ab", "a", 0)
                ,("ab", "b", 1)
                ,("ab", "c", -1)
                ,("hello", "he", 0)
                ,("hello", "el", 1)
                ,("hello", "ll", 2)
                ,("hello", "lo", 3)
                ,("hello", "world", -1)
                ,("a", "bb", -1)
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                Console.Write($"Input: haystack = \"{test.Item1}\", ");
                Console.WriteLine($"needle = \"{test.Item2}\"");
                var x = solve.StrStr(test.Item1, test.Item2);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {test.Item3.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}