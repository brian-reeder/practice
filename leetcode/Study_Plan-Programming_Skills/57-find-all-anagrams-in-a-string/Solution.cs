/*
File Name: 
    57-find-all-anagrams-in-a-string/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:46

Description:
    Given two strings s and p, return an array of all the start indices of p's
    anagrams in s. You may return the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters of a
    different word or phrase, typically using all the original letters exactly
    once.

Constraints:
    1 <= s.length, p.length <= 3 * 10^4
    s and p consist of lowercase English letters.
*/
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        
        IList<int> anagrams = new List<int>();
        if(p.Length > s.Length)
            return anagrams;
        
        Dictionary<char, int> subAlpha;
        var seen = new HashSet<string>();
        var pFreq = new Dictionary<char, int>();
        
        // Initialize frequencies of letter in p.
        for(char i = 'a'; i <= 'z'; i++)
            pFreq[i] = 0;
        foreach(var c in p)
            pFreq[c]++;
        
        // Check if i=0 is an anagram.
        string subS = s[0..(p.Length)];
        foreach(var c in subS)
            pFreq[c]--;
        char key;
        for(key = 'a'; key <= 'z'; key++)
            if(pFreq[key] != 0)
                break;
        if(key == 'z'+1)
            anagrams.Add(0);
        
        // Reset head value;
        pFreq[subS[0]]++;
        
        for(int i = 1; i <= s.Length-p.Length; i++) {
            pFreq[s[i+p.Length-1]]--;
            // Check the dictionary if it is in the anagram state.
            for(key = 'a'; key <= 'z'; key++)
                if(pFreq[key] != 0)
                    break;
            if(key == 'z'+1)
                anagrams.Add(i);
                  
            // Reset head value.
            pFreq[s[i]]++;
        }
        return anagrams;
    }
}