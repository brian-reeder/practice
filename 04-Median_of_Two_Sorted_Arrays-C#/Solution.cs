/* // //
// FileName: 04-Median_of_Two_Sorted_Arrays-C#/Solution.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 12 JULY 2022 14:45:26 UTC
// Description: This file is the Solution class for the leetcode problem.
//      It uses 2 int buffers to store the median value as it loops 
//      through the lists.
*/ // //
namespace MedianOfTwoSortedArrays.Looper {
    public class Solution {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int mi, a, b;
            int m1, m2, i1, i2; 
            int sum = nums1.Length + nums2.Length;

            m1 = m2 = i1 = i2 = 0;
            // Calculate m1 to be the middle index of the sorted nums1+nums2
            // Iterate until you reach the middle index
            for(mi = sum/2; mi >= 0; mi--) {
                // Set comparators to array index or Max Int32
                // By using Max Int32, you can reduce the amount of conditional checks
                a = i1 < nums1.Length ? nums1[i1] : Int32.MaxValue;
                b = i2 < nums2.Length ? nums2[i2] : Int32.MaxValue;

                // Shift middle value to buffer for even length arrays
                m2 = m1;

                // Move the lesser number into the middle value buffer
                // Incremement the appropriate array index
                // Incrementing here is safe within the definition of the problem, normally you would need to be mindful of your max index.
                m1 = a < b ? nums1[i1++] : nums2[i2++];
            }

            // Calculate the return value for Odd length input
            if(sum%2 == 1)
                return Convert.ToDouble(m1);
            // Calculate the return value for Even length input
            else
                return Convert.ToDouble(m1+m2)/2.0;
        }
    }
}