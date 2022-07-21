/*
File Name: 
    14-sum-of-all-odd-length-subarrays/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 21, 2022, 17:12:59

Description:
    Given an array of positive integers arr, return the sum of all possible
    odd-length subarrays of arr.

    A subarray is a contiguous subsequence of the array.
*/
namespace BruteForce {
    public class Solution {
        // Take Odd length slices from the array starting with i
        // Add the sum to the return variable
        public int SumOddLengthSubarrays(int[] arr) {
            var sum = 0;
            for(int i = 0;i < arr.Length; i++)
                for(int j = i+1; j <= arr.Length; j+=2)
                    sum += arr[i..j].Sum();
            return sum;
        }
    }
}

namespace Loop {
    public class Solution {
        public int SumOddLengthSubarrays(int[] arr){
            var sum = 0;
            int numStart, numEnd;
            int numArrays, numOddLength;
            for(int i = 0; i < arr.Length; i++){
                numStart = arr.Length - i;
                numEnd   = i + 1;

                numArrays = (numStart * numEnd);
                numOddLength = (numArrays / 2) + (numArrays % 2);

                sum += numOddLength * arr[i];
            }

            return sum;
        }
    }
}