﻿/*
File Name: 
    23-find-minimum-in-rotated-sorted-array/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    

Description:
    Suppose an array of length n sorted in ascending order is rotated between
    1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

    [4,5,6,7,0,1,2] if it was rotated 4 times.
    [0,1,2,4,5,6,7] if it was rotated 7 times.
    Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time
    results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

    Given the sorted rotated array nums of unique elements, return the minimum
    element of this array.

    You must write an algorithm that runs in O(log n) time.

Constraints:
    n == nums.length
    1 <= n <= 5000
    -5000 <= nums[i] <= 5000
    All the integers of nums are unique.
    nums is sorted and rotated between 1 and n times.
*/
public class Solution {
    public int FindMin(int[] nums) {
        int min, mid, max;
        min = 0;
        max = nums.Length-1;
        if(max == 0 || nums[min] < nums[max])
            return nums[min];
        
        for(mid=max/2; min <= max; mid = min+(max-min)/2) {
            // Next elem is the minimum value.
            if(nums[mid] > nums[mid+1])
                return nums[mid+1];
            // Current elem is the minumum value;    
            if(nums[mid-1] > nums[mid])
                return nums[mid];
            
            if(nums[mid] > nums[0])
                min = mid+1;
            else
                max = mid-1;
        }
        
        return int.MaxValue;
    }
}