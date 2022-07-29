/*
File Name: 
    38-repeated-substring-pattern/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 29, 2022, 18:28:06

Description:
    Given a string s, check if it can be constructed by taking a substring of
    it and appending multiple copies of the substring together.

Constraints:
    1 <= s.length <= 104
    s consists of lowercase English letters.
*/
public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(int i = 2; s.Length/i >= 1; i++)
            if(s.Length%i == 0)
                if(String.IsNullOrEmpty(s.Replace(s[0..(s.Length/i)], "")))
                    return true;

        return false;
    }
}