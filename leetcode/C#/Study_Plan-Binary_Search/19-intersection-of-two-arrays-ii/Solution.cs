/*
File Name: 
    19-intersection-of-two-arrays-ii/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 26, 2022 17:44

Description:
    Given two integer arrays nums1 and nums2, return an array of their
    intersection. Each element in the result must appear as many times as it
    shows in both arrays and you may return the result in any order.

Constraints:
    * 1 <= nums1.length, nums2.length <= 1000
    * 0 <= nums1[i], nums2[i] <= 1000
*/
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int min, mid, max, lower;
        
        var ans = new List<int>();
        lower = 0;
        mid = 0;
        foreach(var n in nums1) {
            min = lower;
            max = nums2.Length-1;
            
            // No more elements in nums2
            if(min > max || n > nums2[max])
                break;
            
            if(n < nums2[min])
                continue;
            
            while(min <= max) {
                mid = min + (max-min)/2;
                if(nums2[mid] >= n)
                    max = mid-1;
                else
                    min = mid+1;
            }
            if(min < nums2.Length && min >= lower && nums2[min] == n) {
                ans.Add(nums2[min]);
                lower = min+1;
            }
        }
        
        return ans.ToArray();
    }
}