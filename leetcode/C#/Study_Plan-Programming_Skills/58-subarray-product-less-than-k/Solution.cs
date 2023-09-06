/*
File Name: 
    58-subarray-product-less-than-k/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:16

Description:
    Given an array of integers nums and an integer k, return the number of
    contiguous subarrays where the product of all the elements in the subarray
    is strictly less than k.

Constraints:
    
    1 <= nums.length <= 3 * 10^4
    1 <= nums[i] <= 1000
    0 <= k <= 10^6
*/
public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        var count = 0;
        if(k <= 1)
            return count;

        var prod  = 1;
        var left  = 0;
        var right = 0;
        for(; right < nums.Length; right += 1) {
            prod *= nums[right];
            for(; prod >= k; left += 1)
                prod /= nums[left];
            
            count += right - left + 1;
        }

        return count;
    }
}