/*
File Name: 
    35-monotonic-array/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 28, 2022, 15:51:03

Description:
    Implement strStr().

    Given two strings needle and haystack, return the index of the first
    occurrence of needle in haystack, or -1 if needle is not part of haystack.

Constraints:
    1 <= haystack.length, needle.length <= 104
    haystack and needle consist of only lowercase English characters.
*/
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle == "")
            return 0;

        for(int i = 0; i <= (haystack.Length-needle.Length); i++)
            if(needle.SequenceEqual(haystack[i..(i+needle.Length)]))
                return i;

        return -1;
    }
}