/*
File Name: 
    46-length-of-last-word/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 2, 2022, 16:19:04

Description:
    Given a string s consisting of words and spaces, return the length of the
    last word in the string.

    A word is a maximal substring consisting of non-space characters only.

Constraints:
    1 <= s.length <= 10^4
    s consists of only English letters and spaces ' '.
    There will be at least one word in s.
*/
namespace LengthOfLastWord {
    class Program {
        public static void Main(string[] args) {
            var testcases = new (string, int)[] {
                 ("Hello World", 5)
                ,("   fly me   to   the moon  ", 4)
                ,("luffy is still joyboy", 6)
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.LengthOfLastWord(test.Item1);
                Console.WriteLine($"Input: s = \"{test.Item1}\"");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item2.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}