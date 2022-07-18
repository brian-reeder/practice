/*
File Name: 
    05-largest-perimeter-triangle/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Monday, July 18, 2022, 15:04:52 

Description:
    Given an integer array nums, return the largest perimeter of a triangle
    with a non-zero area, formed from three of these lengths. If it is
    impossible to form any triangle of a non-zero area, return 0.
*/
public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        for(int i = nums.Length - 1; i >= 2; i--)
            if(nums[i-2] + nums[i-1] > nums[i])
                return nums[i] + nums[i-1] + nums[i-2];

        return 0;
    }
}