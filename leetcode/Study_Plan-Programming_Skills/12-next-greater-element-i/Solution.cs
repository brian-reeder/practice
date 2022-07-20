/*
File Name: 
    11-n-ary-tree-preorder-traversal/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Wednesday, July 20, 2022, 16:32:20 

Description:
    You are given two strings s1 and s2 of equal length. A string swap is an operation where you
    choose two indices in a string (not necessarily different) and swap the characters at these 
    indices.

    Return true if it is possible to make both strings equal by performing at most one string swap
    on exactly one of the strings. Otherwise, return false.
*/
public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var buf = new List<int>();

        // Create search index
        var nextGreater = new Dictionary<int, int> ();
        for(int i = 0; i < nums2.Length; i++){
            var elem = -1;
            for(int j = i+1; j < nums2.Length && elem == -1; j++)
                if(nums2[j] > nums2[i])
                    elem = nums2[j];
            
            nextGreater[nums2[i]] = elem;
        }

        foreach(int n1 in nums1)
            buf.Add(nextGreater[n1]);

        return buf.ToArray();
    }
}