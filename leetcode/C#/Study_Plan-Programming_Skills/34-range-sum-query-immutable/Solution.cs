/*
File Name: 
    34-range-sum-query-immutable/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 27, 2022, 16:30:39

Description:
    Given an integer array nums, handle multiple queries of the following type:
    Calculate the sum of the elements of nums between indices left and right
    inclusive where left <= right.

    Implement the NumArray class:
    NumArray(int[] nums) Initializes the object with the integer array nums.

    int sumRange(int left, int right) Returns the sum of the elements of nums
    between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
*/
public class NumArray {
    
    int[] _nums;
    
    public NumArray(int[] nums) {
        _nums = new int[nums.Length];
        Array.Copy(nums, _nums, _nums.Length);
    }
    
    public int SumRange(int left, int right) {
        right++;
        return _nums[left..right].Sum();
    }
}