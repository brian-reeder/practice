/*
File Name: 
    31-valid-anagram/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 17:21:04

Description:
    Given two strings s and t, return true if t is an anagram of s, and false
    otherwise.

    An Anagram is a word or phrase formed by rearranging the letters of a
    different word or phrase, typically using all the original letters exactly
    once.
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        var alpha = new Dictionary<char, int>();
        foreach(char c in s) {
            if(alpha.ContainsKey(c)) {
                alpha[c]++;
            }
            else
                alpha[c] = 1;
        }
        
        foreach(char c in t) {
            if(alpha.ContainsKey(c)) {
                if(alpha[c] == 1) {
                    alpha.Remove(c);
                }
                else {
                    alpha[c]--;
                }
            }
            else {
                return false;
            }
        }
        
        return alpha.Count == 0;
    }
}