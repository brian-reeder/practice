/* // //
// FileName: 06-Zigzag_Conversion-C#/Solution.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: Thursday, July 14, 2022, 14:58:36 PM
// Description: This file implements a solution for the leetcode problem.
//      It iterates through the input string and adds the character to the
//      next row.
*/ // //
namespace Looper {
    public class Solution {
        public string Convert(string s, int numRows) {

            // Base case, early termination
            // Saves the potential divide by 0
            if(numRows == 1 || s.Length <= numRows)
                return s;

            // Initialize rows to empty strings
            string[] rows = new string[numRows];
            for(int row = 0; row < numRows; row++)
                rows[row] = "";

            // Append character to each row
            // Chang direction when numRows barrier is met
            int i = 0, mod = 1;
            foreach(char c in s.ToCharArray()) {
                rows[i] +=c;
                i = i + mod;

                // If the row boundaries are met, change directions
                if(i % (numRows-1) == 0)
                    mod = mod*-1;

            }

            // Flatten rows to output string
            string r = "";
            foreach(string row in rows)
                r += row;
            
            return r;
        }
    }
}