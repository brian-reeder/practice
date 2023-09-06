/*
File Name: 
    06-find-the-distance-value-between-two-arrays/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 19, 2022, 17:02

Description:
    Given two integer arrays arr1 and arr2, and the integer d, return the
    distance value between the two arrays.

    The distance value is defined as the number of elements arr1[i] such that
    there is not any element arr2[j] where |arr1[i]-arr2[j]| <= d.

Constraints:
    * 1 <= arr1.length, arr2.length <= 500
    * -1000 <= arr1[i], arr2[j] <= 1000
    * 0 <= d <= 100
*/
public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        Array.Sort(arr2);
        int min, mid, max, count;

        count = 0;
        foreach(var n in arr1) {
            min = 0;
            max = arr2.Length-1;
            mid = max/2;
            for(; min <= max; mid = min + (max-min)/2) {
                if(Math.Abs(n - arr2[mid]) <= d) {
                    count++;
                    break;
                }
                else if(arr2[mid] > n)
                    max = mid-1;
                else
                    min = mid+1;
            }
        }

        return arr1.Length-count;
    }
}