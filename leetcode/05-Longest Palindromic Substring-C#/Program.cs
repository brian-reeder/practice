/* // //
// FileName: 05-Longest Palindromic Substring-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: Wednesday, July 13, 2022, 15:54:25 UTC
// Description: This file is the Main function that operates the test
//      cases and the Solution program for the problem.
*/ // //
namespace LongestPalindromicSubstring {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Longest Palindromic Substring");

            string[] testcases = {
                "babad"
                ,"cbbd"
                ,"cbbdbabad"
                ,"babadcbbd"
                ,"abcdbbfcba"
            };

            Looper.Solution solve = new Looper.Solution();
            foreach(string test in testcases) {
                Console.WriteLine($"Input: {test}");
                Console.WriteLine($"Output: {solve.LongestPalindrome(test)}\n");
            }

            return;
        }
    }
}