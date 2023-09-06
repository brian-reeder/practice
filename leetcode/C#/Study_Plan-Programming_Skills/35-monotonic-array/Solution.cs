/*
File Name: 
    35-monotonic-array/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 28, 2022, 15:25:55

Description:
    An array is monotonic if it is either monotone increasing or monotone
    decreasing.

    An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j].
    An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].

    Given an integer array nums, return true if the given array is monotonic,
    or false otherwise.

Constraints:
    1 <= nums.Length <= 10^5
    -10^5 <= nums[i] <= 10^5
*/
public class Solution {
    public bool IsMonotonic(int[] nums) {
        var increasing = false;
        var decreasing = false;
        for(int i = 0; i < nums.Length-1; i++) {
            if(increasing) {
                // Escape if change in direction.
                if(nums[i] > nums[i+1])
                    return false;
            }
            else if(decreasing) {
                // Escape if change in direction.
                if(nums[i] < nums[i+1])
                    return false;
            }
            // Monotonic direction needs to be set.
            else {
                if(nums[i] < nums[i+1])
                    increasing = true;
                else if(nums[i] > nums[i+1])
                    decreasing = true;
            }
        }

        return true;
    }
}