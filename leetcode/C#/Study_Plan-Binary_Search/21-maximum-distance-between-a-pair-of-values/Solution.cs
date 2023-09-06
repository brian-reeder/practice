/*
File Name: 
    21-maximum-distance-between-a-pair-of-values/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 27, 2022, 16:13

Description:
    You are given two non-increasing 0-indexed integer arrays nums1​​​​​​ and nums2​​​​​​.
    A pair of indices (i, j), where 0 <= i < nums1.length and 
    0 <= j < nums2.length, is valid if both i <= j and nums1[i] <= nums2[j].
    The distance of the pair is j - i​​​​.

    Return the maximum distance of any valid pair (i, j). If there are no valid
    pairs, return 0.

    An array arr is non-increasing if arr[i-1] >= arr[i] for every
    1 <= i < arr.length.

Constraints:
    * 1 <= nums1.length, nums2.length <= 10^5
    * 1 <= nums1[i], nums2[j] <= 10^5
    * Both nums1 and nums2 are non-increasing.
*/
public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int min, mid, max, distance, d;
        
        distance = 0;
        for(int i = 0; i < nums1.Length; i++) {
            min = i;
            max = nums2.Length-1;
            d = 0;
            while(min <= max) {
                mid = min+(max-min)/2;
                if(nums1[i] <= nums2[mid]) {
                    d = mid - i;
                    if(d > distance)
                        distance = d;
                    min = mid+1;
                }
                else
                    max = mid-1;
            }
        }
        
        return distance;
    }
}