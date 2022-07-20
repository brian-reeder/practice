/*
File Name: 
    10-check-if-one-string-swap-can-make-strings-equal/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 23:58:39

Description:
    You are given two strings s1 and s2 of equal length. A string swap is an operation where you
    choose two indices in a string (not necessarily different) and swap the characters at these 
    indices.

    Return true if it is possible to make both strings equal by performing at most one string swap
    on exactly one of the strings. Otherwise, return false.
*/
public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        // Problem description assume s1.Length == s2.Length

        var count = 0;
        var dif = new int[] {-1,-1};
        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != s2[i]) {
                count++;
                // Basecase, more than 1 swap required. Early termination
                if(count > 2)
                    return false;
                
                dif[count-1] = i;
            }
        }

        // 0 swaps required
        if(count == 0)
            return true;
        // Not enough characters to swap
        else if(count == 1)
            return false;
        // Strings not equal
        else if(s1[dif[0]] != s2[dif[1]] || s1[dif[1]] != s2[dif[0]])
            return false;

        return true;
    }
}