/*
File Name: 
    24-verifying-an-alien-dictionary/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 24, 2022, 16:13:06

Description:
    n an alien language, surprisingly, they also use English lowercase letters,
    but possibly in a different order. The order of the alphabet is some
    permutation of lowercase letters.

    Given a sequence of words written in the alien language, and the order of
    the alphabet, return true if and only if the given words are sorted
    lexicographically in this alien language.
*/
namespace VerifyingAnAlienDictionary {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string[], string, bool)[] {
                 (new string[] {
                     "hello"
                    ,"leetcode"
                 },
                 "hlabcdefgijkmnopqrstuvwxyz",
                 true)
                ,(new string[] {
                     "word"
                    ,"world"
                    ,"row"
                 },
                 "worldabcefghijkmnpqstuvxyz",
                 false)
                ,(new string[] {
                     "apple"
                    ,"app"
                 },
                 "abcdefghijklmnopqrstuvwxyz",
                 false)
            };

            var solve = new Solution();
            foreach((string[], string, bool) t in testcases) {
                Console.Write($"Input: words = [\"{String.Join("\",\"", t.Item1)}\"], ");
                Console.WriteLine($"order = \"{t.Item2}\"");
                var x = solve.IsAlienSorted(t.Item1, t.Item2);
                Console.WriteLine($"Output: {x}");

                // Check output against the test
                Console.WriteLine($"Pass: {t.Item3 == x}");
                Console.WriteLine();
            }
        }
    }
}