/*
// FileName: 07-Reverse_Integer-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: Friday, July 15, 2022, 16:51:02 AM
// Description: This file contains the solution for the leetcode problem.
//      It uses a for loop to shift the return buffer up, and exceptions
//      to detect the overflow.
*/
namespace looper {
    public class Solution {
        public int Reverse(int x) {
            var r = 0;
            
            // Each pass, upgrade the return buffer by 10
            // Append the 1's place to the return buffer
            // Shift the input value down by 10
            for(int sign = x < 0 ? -1 : 1; x*sign > 0; x = x/10) {
                try{
                    r = checked(r * 10);
                    r = checked(r + (x % 10));
                }
                // The return buffer has overflowed.
                catch(System.OverflowException) {
                    return 0;
                }
            }

            return r;
        }
    }
}