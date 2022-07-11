/* // //
// FileName: 03-Longest_Substring_Without_Repeating_Characters-C#/Solution.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 10 JULY 2022 14:00:44 UTC
// Description: This file is the Solution class for the leetcode problem.
//      It uses a HashSet. 
*/ // //
namespace Solution.HashSet {
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            int i, j;
            int max = 0;
            int L = 0;
            int sL = s.Length;

            // Init HashSet with max size of the input string.
            HashSet<char> buffer = new HashSet<char>(sL);

            // Iterate through all chars in the string
            for(i = 0; i < sL; i++) {
                // Begin new substring
                for(j = i; j < sL; j++) {
                    // If the element does not cause a collision
                    if(buffer.Add(s[j])) {
                        if(++L > max)
                        max = L;
                    } 
                    // Early terminate, current char causes a collision.
                    else {
                        buffer.Clear();
                        L = 0;
                        break;
                    }
                }

                // Early Terminate, last substring reached the end of the input string.
                if(j == sL)
                    break;
            }

            return max;
        }
    }
}