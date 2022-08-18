/*
File Name: 
    03-search-insert-position/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 18, 2022, 19:49

Description:
    Given a sorted array of distinct integers and a target value, return the
    index if the target is found. If not, return the index where it would be if
    it were inserted in order.

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 1 <= nums.length <= 10^4
    * -10^4 <= nums[i] <= 10^4
    * nums contains distinct values sorted in ascending order.
    * -10^4 <= target <= 10^4
*/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int min, mid, max;
        min = 0;
        max = nums.Length-1;
        for(mid = max/2; min <= max && nums[mid] != target; mid = min + (max-min)/2)
            if(target < nums[mid])
                max = mid-1;
            else
                min = mid+1;

        return mid;
    }
}