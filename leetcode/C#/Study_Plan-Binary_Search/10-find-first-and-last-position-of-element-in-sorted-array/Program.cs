/*
File Name: 
    10-find-first-and-last-position-of-element-in-sorted-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 14:06

Description:
    Given an array of integers nums sorted in non-decreasing order, find the
    starting and ending position of a given target value.

    If target is not found in the array, return [-1, -1].

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 0 <= nums.length <= 10^5
    * -10^9 <= nums[i] <= 10^9
    * nums is a non-decreasing array.
    * -10^9 <= target <= 10^9
*/
namespace FindFirstAndLastPositionOfElementInSortedArray {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int[])[] {
                (new int[] {5,7,7,8,8,10}, 8, new int[] {3,4}),
                (new int[] {5,7,7,8,8,10}, 5, new int[] {0,0}),
                (new int[] {5,7,7,8,8,10}, 7, new int[] {1,2}),
                (new int[] {5,7,7,8,8,10}, 10, new int[] {5,5}),
                (new int[] {5,7,7,8,8,10}, 1, new int[] {-1,-1}),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.SearchRange(test.Item1, test.Item2);
                var pass = test.Item3.SequenceEqual(output);
                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: nums = [{String.Join(',',test.Item1)}], target = {test.Item2}");
                    Console.WriteLine($"\tOutput: {test.Item2}");
                    Console.WriteLine();
                }
            }
        }
    }
}