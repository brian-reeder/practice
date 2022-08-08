/*
File Name: 
    56-group-anagrams/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:29

Description:
    Given an array of strings strs, group the anagrams together. You can return
    the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters of a
    different word or phrase, typically using all the original letters exactly
    once.

Constraints:
    1 <= strs.length <= 104
    0 <= strs[i].length <= 100
    strs[i] consists of lowercase English letters.
*/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var anagrams = new Dictionary<string, int>();
        IList<IList<string>> groups = new List<IList<string>>();
        IList<string> newGroup;
        
        char[] charWord;
        string sortedWord;
        foreach(var word in strs) {
            // Transform word to anagram key.
            charWord = word.ToCharArray();
            Array.Sort(charWord);
            sortedWord = new string(charWord);
            
            // Check to see if anagram has been encountered before.
            if(!anagrams.ContainsKey(sortedWord)) {
                anagrams[sortedWord] = groups.Count;
                newGroup = new List<string>(1);
                groups.Add(newGroup);
            }
            
            // Add anagram to appropriate group.
            groups[anagrams[sortedWord]].Add(word);
        }
        
        return groups;
    }
}