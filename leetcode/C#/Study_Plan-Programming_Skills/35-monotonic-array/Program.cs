/*
File Name: 
    35-monotonic-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 28, 2022, 15:16:00 

Description:
    An array is monotonic if it is either monotone increasing or monotone
    decreasing.

    An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j].
    An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].

    Given an integer array nums, return true if the given array is monotonic,
    or false otherwise.

Constraints:
    1 <= nums.Length <= 10^5
    -10^5 <= nums[i] <= 10^5
*/
namespace MonotonicArray {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], bool)[] {
                 (new int[] {1}, true)
                ,(new int[] {1,1}, true)
                ,(new int[] {1,2}, true)
                ,(new int[] {2,1}, true)
                ,(new int[] {1,2,3}, true)
                ,(new int[] {3,2,1}, true)
                ,(new int[] {1,1,1}, true)
                ,(new int[] {1, 2, 1}, false)
                ,(new int[] {3, 2, 3}, false)
                ,(new int[] {1, 1, 1, 1}, true)
                ,(new int[] {1, 2, 2, 3}, true)
                ,(new int[] {1, 2, 2, 1}, false)
                ,(new int[] {3, 2, 2, 3}, false)
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                Console.WriteLine($"Input: nums = [{String.Join(',', test.Item1)}]");
                var x = solve.IsMonotonic(test.Item1);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {test.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}