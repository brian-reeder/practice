/*
File Name: 
    24-verifying-an-alien-dictionary/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Sunday, July 24, 2022, 16:20:40

Description:
    n an alien language, surprisingly, they also use English lowercase letters,
    but possibly in a different order. The order of the alphabet is some
    permutation of lowercase letters.

    Given a sequence of words written in the alien language, and the order of
    the alphabet, return true if and only if the given words are sorted
    lexicographically in this alien language.
*/
public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var alpha = new Dictionary<char, int>(26);
        var val = 0;
        foreach(char c in order)
            alpha[c] = val++;
        
        int c1, c2;
        for(int i = 1; i < words.Length; i++) {
            for(int j = 0; j < words[i-1].Length; j++) {
                if(j == words[i].Length)
                    return false;

                c1 = alpha[words[i-1][j]];
                c2 = alpha[words[i][j]];
                if(c1 < c2)
                    break;
                if(c1 > c2)
                    return false;
            }
        }

        return true;
    }
}