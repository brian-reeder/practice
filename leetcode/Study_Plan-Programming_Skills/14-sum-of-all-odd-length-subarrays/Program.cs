/*
File Name: 
    14-sum-of-all-odd-length-subarrays/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 21, 2022, 17:11:19

Description:
    Given an array of positive integers arr, return the sum of all possible
    odd-length subarrays of arr.

    A subarray is a contiguous subsequence of the array.
*/
namespace SumOfAllOddLengthSubarrays {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int)[] {
                 (new int[] {1,4,2,5,3}, 58)
                ,(new int[] {1,2}, 3)
                ,(new int[] {10,11,12}, 66)
            };

            var solve = new BruteForce.Solution();
            foreach((int[], int) t in testcases) {
                Console.WriteLine($"Input: nums1 = [{String.Join(",", t.Item1)}]");
                var x = solve.SumOddLengthSubarrays(t.Item1);
                Console.WriteLine($"Output: {String.Join(",", x)}");
                Console.WriteLine($"Pass: {t.Item2 == x}");
                Console.WriteLine();
            }
        }
    }
}