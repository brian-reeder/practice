/*
File Name: 
    60-smallest-range-ii/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 10, 2022, 16:29

Description:
    You are given an integer array nums and an integer k.
    For each index i where 0 <= i < nums.length, change nums[i] to be either
    nums[i] + k or nums[i] - k.

    The score of nums is the difference between the maximum and minimum
    elements in nums.

    Return the minimum score of nums after changing the values at each index.

Constraints:
    1 <= nums.length <= 10^4
    0 <= nums[i] <= 10^4
    0 <= k <= 10^4
*/
public class Solution {
    public int SmallestRangeII(int[] nums, int k) {
        var ans = 0;
        var n = nums.Length;
        if(n == 0)
            return ans;

        Array.Sort(nums);
        ans = nums[n-1] - nums[0];

        int a, b, localMax, localMin;
        var a0 = nums[n-1] - k;
        var b0 = nums[0] + k;
        for(int i = 0; i < n-1; i++) {
            a = nums[i]+k;
            b = nums[i+1]-k;
            localMax = Math.Max(a0, a);
            localMin = Math.Min(b0, b);

            ans = localMax - localMin;
        }
        
        return ans;
    }
}