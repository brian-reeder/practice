/*
File Name: 
    19-merge-strings-alternately/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 23, 2022, 8:35:51

Description:
    You are given two strings word1 and word2. Merge the strings by adding 
    letters in alternating order, starting with word1. If a string is longer
    than the other, append the additional letters onto the end of the merged
    string.

    Return the merged string.
*/
namespace ReshapeTheMatrix {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, string, string)[] {
                 ("abc", "pqr", "apbqcr")
                ,("ab", "pqrs", "apbqrs")
                ,("abcd", "pq", "apbqcd")
                ,("", "wxyz", "wxyz")
                ,("abcd", "", "abcd")
                ,("", "", "")
            };

            var solve = new Solution();
            foreach((string, string, string) t in testcases) {
                Console.WriteLine($"Input: word1 = \"{t.Item1}\", word2 = \"{t.Item2}\" ");
                var x = solve.MergeString(t.Item1, t.Item2);
                Console.WriteLine($"Output: \"{x}\"");

                // Check output against the test
                Console.WriteLine($"Pass: {t.Item3.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}