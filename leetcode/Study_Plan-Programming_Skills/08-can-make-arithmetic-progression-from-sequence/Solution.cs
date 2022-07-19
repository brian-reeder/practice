/*
File Name: 
    08-can-make-arithmetic-progression-from-sequence/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 17:44:03

Description:
    A sequence of numbers is called an arithmetic progression if the difference
    between any two consecutive elements is the same.
    
    Given an array of numbers arr, return true if the array can be rearranged
    to form an arithmetic progression. Otherwise, return false.
*/
public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        var difference = arr[1] - arr[0];
        for(int i = 2; i < arr.Length; i++)
            if(arr[i] - arr[i-1] != difference)
                return false;
        return true;
    }
}