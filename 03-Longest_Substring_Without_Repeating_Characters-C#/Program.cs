/* // //
// FileName: 03-Longest_Substring_Without_Repeating_Characters-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 10 JULY 2022 13:59:12 UTC
// Description: This file is the Main function that operates the test
//      cases and the Solution program for the problem.
*/ // //
namespace LongestSubstring {
    public class Program {
        public static void Main(string[] args) {
            string[] testcases = {
                "abcabcbb"
                ,"bbbbb"
                ,"pwwkew"
                ,"12345678"
                ,"12345671"
            };

            Solution.HashSet.Solution solve = new Solution.HashSet.Solution();
            
            int L;
            foreach(string test in testcases) {
                L = solve.LengthOfLongestSubstring(test);
                Console.WriteLine($"{test}\n{L}\n");
            }
        }
    }
}
