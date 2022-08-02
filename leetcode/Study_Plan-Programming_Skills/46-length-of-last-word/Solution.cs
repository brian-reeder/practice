/*
File Name: 
    46-length-of-last-word/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 2, 2022, 16:24:16

Description:
    Given a string s consisting of words and spaces, return the length of the
    last word in the string.

    A word is a maximal substring consisting of non-space characters only.

Constraints:
    1 <= s.length <= 10^4
    s consists of only English letters and spaces ' '.
    There will be at least one word in s.
*/
public class Solution {
    public int LengthOfLastWord(string s) {
        int i,j;
        for(i = s.Length-1; i >= 0; i--)
            if(s[i] != ' ')
                break;
        for(j = i; j >=0; j--)
            if(s[j] == ' ')
                break;
        return i-j;
    }
}