/*
File Name: 
    22-search-in-rotated-sorted-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 27, 2022, 21:17

Description:
    There is an integer array nums sorted in ascending order (with distinct
    values).
    Prior to being passed to your function, nums is possibly rotated at an
    unknown pivot index k (1 <= k < nums.length) such that the resulting array
    is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]]
    (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3
    and become [4,5,6,7,0,1,2].

    Given the array nums after the possible rotation and an integer target,
    return the index of target if it is in nums, or -1 if it is not in nums.

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 1 <= nums.length <= 5000
    * -10^4 <= nums[i] <= 10^4
    * All values of nums are unique.
    * nums is an ascending array that is possibly rotated.
    * -10^4 <= target <= 10^4
*/
public class Solution {
    public int Search(int[] nums, int target) {
        int min, mid, max;
        min = 0; 
        max = nums.Length-1;
        for(mid = max/2; min <= max; mid = min+(max-min)/2) {
            if(nums[mid] == target)
                return mid;
            else {
                if(nums[min] <= nums[max]) {
                    if(nums[mid] < target)
                        min = mid+1;
                    else
                        max = mid-1;
                }
                else {
                    if(nums[min] > target)
                        min += 1;
                    if(nums[max] < target)
                        max -= 1;
                }
            }
        }

        return -1;
    }
}