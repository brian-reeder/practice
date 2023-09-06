/*
File Name: 
    10-find-first-and-last-position-of-element-in-sorted-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 14:06

Description:
    Given an array of integers nums sorted in non-decreasing order, find the
    starting and ending position of a given target value.

    If target is not found in the array, return [-1, -1].

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 0 <= nums.length <= 10^5
    * -10^9 <= nums[i] <= 10^9
    * nums is a non-decreasing array.
    * -10^9 <= target <= 10^9
*/
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int min, mid, max;
        int[] ans = {-1,-1};

        min = 0;
        max = nums.Length-1;
        for(mid=max/2; min <= max; mid = min+(max-min)/2) {
            if(nums[mid]==target) {
                ans[0] = mid;
                max = mid-1;
            }
            else if(nums[mid] < target)
                min = mid+1;
            else
                max = mid-1;
        }

        min = 0;
        max = nums.Length-1;
        for(mid=max/2; min <= max; mid = min+(max-min)/2) {
            if(nums[mid]==target) {
                ans[1] = mid;
                min = mid+1;
            }
            else if(nums[mid] < target)
                min = mid+1;
            else
                max = mid-1;
        }

        return ans;
    }
}