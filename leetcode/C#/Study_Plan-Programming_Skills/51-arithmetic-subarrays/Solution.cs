/*
File Name: 
    51-arithmetic-subarrays/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 5, 2022, 16:46

Description:
    A sequence of numbers is called arithmetic if it consists of at least two
    elements, and the difference between every two consecutive elements is the
    same. More formally, a sequence s is arithmetic if and only if
    s[i+1] - s[i] == s[1] - s[0] for all valid i.

    For example, these are arithmetic sequences:
    1, 3, 5, 7, 9
    7, 7, 7, 7
    3, -1, -5, -9

    The following sequence is not arithmetic:
    1, 1, 2, 5, 7
    
    You are given an array of n integers, nums, and two arrays of m integers
    each, l and r, representing the m range queries, where the ith query is the
    range [l[i], r[i]]. All the arrays are 0-indexed.

    Return a list of boolean elements answer, where answer[i] is true if the
    subarray nums[l[i]], nums[l[i]+1], ... , nums[r[i]] can be rearranged to
    form an arithmetic sequence, and false otherwise.

Constraints:
    n == nums.length
    m == l.length
    m == r.length
    2 <= n <= 500
    1 <= m <= 500
    0 <= l[i] < r[i] < n
    -105 <= nums[i] <= 105
*/
public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        IList<bool> ans = new List<bool>(l.Length);

        int[] subNums;
        int diff = 0;
        bool IsArithmeticSubarray;
        for(int i = 0; i < l.Length; i++) {
            IsArithmeticSubarray = true;
            // All single elements are arithmetic arrays.
            if((r[i]+1) - l[i] > 1) {
                subNums = nums[l[i]..(r[i]+1)];

                // A discrete property of arithmetic arrays, is that they
                // must be sorted either ascending or descending.
                Array.Sort(subNums);

                // The difference of the first two elements must be the
                // difference for all pairs.
                diff = subNums[1] - subNums[0];
                for(int j = 1; j < subNums.Length; j++)
                    if(subNums[j] - subNums[j-1] != diff){
                        IsArithmeticSubarray = false;
                        break;
                    }
            }
            ans.Add(IsArithmeticSubarray);
        }

        return ans;
    }
}