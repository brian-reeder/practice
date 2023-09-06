/*
File Name: 
    01-binary-search/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 17, 2022, 15:51

Description:
    Given an array of integers nums which is sorted in ascending order, and an
    integer target, write a function to search target in nums. If target
    exists, then return its index. Otherwise, return -1.

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 1 <= nums.length <= 10^4
    * -10^4 < nums[i], target < 10^4
    * All the integers in nums are unique.
    * nums is sorted in ascending order.
*/
public class Solution {
    public int Search(int[] nums, int target) {        
        int r, l, m;
        l = 0;
        r = nums.Length-1;

        
        while(l <= r) {
            m = l  + (r - l)/2;
            if(nums[m] == target)
                return m;
            else if(target < nums[m])
                r = m-1;
            else
                l = m+1;
        }
        
        return -1;
    }
}