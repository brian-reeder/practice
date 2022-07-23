/*
File Name: 
    19-merge-strings-alternately/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 23, 2022, 13:36:00

Description:
    You are given two strings word1 and word2. Merge the strings by adding 
    letters in alternating order, starting with word1. If a string is longer
    than the other, append the additional letters onto the end of the merged
    string.

    Return the merged string.
*/
public class Solution {
    public string MergeString(string word1, string word2) {
        var newString = new char[word1.Length + word2.Length];
        var i1 = 0;
        var i2 = 0;
        for(int i = 0; i < newString.Length;) {
            if(i1 < word1.Length)
                newString[i++] = word1[i1++];

            if(i2 < word2.Length)
                newString[i++]  = word2[i2++];
        }

        return new String(newString);
    }
}