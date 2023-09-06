/*
File Name: 
    10-check-if-one-string-swap-can-make-strings-equal/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 23:58:32

Description:
    You are given two strings s1 and s2 of equal length. A string swap is an operation where you
    choose two indices in a string (not necessarily different) and swap the characters at these 
    indices.

    Return true if it is possible to make both strings equal by performing at most one string swap
    on exactly one of the strings. Otherwise, return false.

Example 1:
    Input: s1 = "bank", s2 = "kanb"
    Output: true
    Explanation: For example, swap the first character with the last character of s2 to make 
    "bank".
Example 2:
    Input: s1 = "attack", s2 = "defend"
    Output: false
    Explanation: It is impossible to make them equal with one string swap.
Example 3:
    Input: s1 = "kelb", s2 = "kelb"
    Output: true
    Explanation: The two strings are already equal, so no string swap operation is required.
Constraints:
    1 <= s1.length, s2.length <= 100
    s1.length == s2.length
    s1 and s2 consist of only lowercase English letters.
*/
namespace CheckIfOneStringSwapCanMakeStringsEqual {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, string, bool)[] {
                 ("bank", "kanb", true)
                ,("attack", "defend", false)
                ,("kelb", "kelb", true)
            };

            var solve = new Solution();
            foreach((string, string, bool) t in testcases) {
                Console.WriteLine($"Input: s1 = {t.Item1}, s2 = {t.Item2}");
                var x = solve.AreAlmostEqual(t.Item1, t.Item2);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {x == t.Item3}");
                Console.WriteLine();
            }
        }
    }
}