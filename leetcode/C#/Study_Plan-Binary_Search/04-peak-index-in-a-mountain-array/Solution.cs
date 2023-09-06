/*
File Name: 
    04-peak-index-in-a-mountain-array/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 18, 2022, 20:07

Description:
    An array arr a mountain if the following properties hold:
        * arr.length >= 3
        * There exists some i with 0 < i < arr.length - 1 such that:
            * arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
            * arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
    Given a mountain array arr, return the index i such that 
    arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

    You must solve it in O(log(arr.length)) time complexity.

Constraints:
    * 3 <= arr.length <= 105
    * 0 <= arr[i] <= 106
    * arr is guaranteed to be a mountain array
*/
public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int min, mid, max;
        min = 0;
        max = arr.Length-1;
        for(mid = max/2; min < max; mid = min + (max - min)/2)
            if(arr[mid] < arr[mid+1])
                min = mid+1;
            else
                max = mid;
        
        return min;
    }
}