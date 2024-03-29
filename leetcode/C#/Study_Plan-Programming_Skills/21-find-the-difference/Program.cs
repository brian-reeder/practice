﻿/*
File Name: 
    21-find-the-difference/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 23, 2022, 14:32:24

Description:
    You are given two strings s and t.

    String t is generated by random shuffling string s and then add one more
    letter at a random position.

    Return the letter that was added to t.
*/
namespace FindTheDifference {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, string, char)[] {
                 ("abcd", "abcde", 'e')
                ,("", "y", 'y')
                ,("dcba", "edbca", 'e')
            };

            var solve = new Sorter.Solution();
            foreach((string, string, char) t in testcases) {
                Console.WriteLine($"Input: s = \"{t.Item1}\", s = \"{t.Item2}\"");
                var x = solve.FindTheDifference(t.Item1, t.Item2);
                Console.WriteLine($"Output: \"{x}\"");

                // Check output against the test
                Console.WriteLine($"Pass: {t.Item3 == x}");
                Console.WriteLine();
            }
        }
    }
}