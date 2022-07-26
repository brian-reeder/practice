/*
File Name: 
    32-contains-duplicate/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 17:28:23 

Description:
    Given an integer array nums, return true if any value appears at least
    twice in the array, and return false if every element is distinct.
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var intHash = new HashSet<int>();
        foreach(int i in nums) {
            if(intHash.Contains(i))
                return true;
            else
                intHash.Add(i);
        }
        
        return false;
    }
}