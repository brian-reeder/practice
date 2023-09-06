/*
File Name: 
    53-next-greater-element-ii/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 6, 2022, 15:42

Description:
    Given a circular integer array nums (i.e., the next element of
    nums[nums.length - 1] is nums[0]), return the next greater number for every
    element in nums.

    The next greater number of a number x is the first greater number to its
    traversing-order next in the array, which means you could search circularly
    to find its next greater number. If it doesn't exist, return -1 for this
    number.

Constraints:
    1 <= nums.length <= 104
    -10^9 <= nums[i] <= 10^9
*/
public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var n   = nums.Length;
        var ans = new int[n];
        var intBuff = new Stack<int>();
        
        intBuff.Push(0);
        for(int i = 1; i < n*2 && intBuff.Count != 0;i++) {
            // i Out of bounds protection.
            var safeI = i % n;

            // While the current value is greater than the stack.
            while(intBuff.Count != 0 && nums[intBuff.Peek()] < nums[safeI])
                ans[intBuff.Pop()] = nums[safeI];
            
            // Stack positions within nums.
            if(i < n)
                intBuff.Push(i);
        }
        
        // Set any remaining values to -1.
        while(intBuff.Count != 0)
            ans[intBuff.Pop()] = -1;
        
        return ans;
    }
}