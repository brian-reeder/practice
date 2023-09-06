/*
File Name: 
    23-decrypt-string-from-alphabet-to-integer-mapping/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 24, 2022, 15:19:54

Description:
    You are given a string s formed by digits and '#'. We want to map s to 
    English lowercase characters as follows:
        1. Characters ('a' to 'i') are represented by ('1' to '9') respectively.
        2. Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.

    Return the string formed after mapping.

    The test cases are generated so that a unique mapping will always exist.
*/
namespace DecryptStringFromAlphabetToIntegerMapping {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, string)[] {
                 ("10#11#12", "jkab")
                ,("1326#", "acz")
            };

            var solve = new LookAhead.Solution();
            foreach((string, string) t in testcases) {
                Console.WriteLine($"Input: s = \"{t.Item1}");
                var x = solve.FreqAlphabets(t.Item1);
                Console.WriteLine($"Output: \"{x}\"");

                // Check output against the test
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}