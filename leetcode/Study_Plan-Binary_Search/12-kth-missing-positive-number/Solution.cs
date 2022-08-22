/*
File Name: 
    12-kth-missing-positive-number/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 22, 2022, 16:02

Description:
    Given an array arr of positive integers sorted in a strictly increasing
    order, and an integer k.

    Return the kth positive integer that is missing from this array

Constraints:
    * 1 <= arr.length <= 1000
    * 1 <= arr[i] <= 1000
    * 1 <= k <= 1000
    * arr[i] < arr[j] for 1 <= i < j <= arr.length
*/
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int min, mid, max, missing;
        min = 0;
        max = arr.Length-1;
        
        for(mid=max/2; min<=max; mid=min+(max-min)/2) {
            missing = arr[mid] - mid;
            
            if(missing <= k)
                min = mid+1;
            else
                max = mid-1;
        }
        
        return min+k;
    }
}