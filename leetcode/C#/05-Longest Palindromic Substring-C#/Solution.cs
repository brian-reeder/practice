/* // //
// FileName: 05-Longest Palindromic Substring-C#/Solution.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: Wednesday, July 13, 2022, 15:56:10 UTC
// Description: This file implements a solution for the leetcode problem. It
//      iterates through the input string for starting indexes and shrinks the
//      substirng until a palindrome is found. Sets the buffer only for new
//      largest palindromes.
*/ // //
namespace Looper {
    public class Solution {
        public string LongestPalindrome(string s) {

            int bi = 0, i2, j2;
            int bLength = 0;
            bool isPalindrome;

            // Iterate through all starting characters
            for(int i = 0; i < s.Length; i++) {

                // Shrink substring size until the buffer length is met
                for(int j = s.Length-i; (j > 0) && (j > bLength); j--) {

                    isPalindrome = true;
                    // Set left index
                    i2 = i;
                    // Set right index
                    j2 = j + i - 1;

                    // Move left and right index closer to determine palindrome status
                    while(i2 <= j2) {
                        if(s[i2++] != s[j2--]) {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if(isPalindrome) {
                        bi = i;
                        bLength = j;
                    }
                }
            }

            return s.Substring(bi, bLength);
        }
    }
}