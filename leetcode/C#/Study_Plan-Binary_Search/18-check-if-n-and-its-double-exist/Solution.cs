/*
File Name: 
    18-check-if-n-and-its-double-exist/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 17:59

Description:
    Given an array arr of integers, check if there exists two integers N and M
    such that N is the double of M ( i.e. N = 2 * M).

    More formally check if there exists two indices i and j such that :
    * i != j
    * 0 <= i, j < arr.length
    * arr[i] == 2 * arr[j]

Constraints:
    * 2 <= arr.length <= 500
    * -10^3 <= arr[i] <= 10^3
*/
public class Solution {
    public bool CheckIfExist(int[] arr) {
        Array.Sort(arr);
        for(int i = 0; i < arr.Length; i++)
            if(SearchNum(arr, arr[i]*2, i)) return  true;

        return false;
    }

    private bool SearchNum(int[] a, int N, int i) {
        int min, mid, max;
        min = 0;
        max = a.Length-1;
        for(mid = max/2; min <= max; mid=min+(max-min)/2)
            if(i != mid && a[mid] == N)
                return true;
            else if(a[mid] > N)
                max = mid-1;
            else
                min = mid+1;

        return false;
    }
}