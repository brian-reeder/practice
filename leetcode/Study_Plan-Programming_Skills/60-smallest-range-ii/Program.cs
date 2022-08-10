/*
File Name: 
    60-smallest-range-ii/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 10, 2022, 16:24

Description:
    You are given an integer array nums and an integer k.
    For each index i where 0 <= i < nums.length, change nums[i] to be either
    nums[i] + k or nums[i] - k.

    The score of nums is the difference between the maximum and minimum
    elements in nums.

    Return the minimum score of nums after changing the values at each index.

Constraints:
    1 <= nums.length <= 10^4
    0 <= nums[i] <= 10^4
    0 <= k <= 10^4
*/
namespace SmallestRangeII {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int)[] {
                (new int[] {1}, 0, 0),
                (new int[] {0,10}, 2, 6),
                (new int[] {1,3,6}, 3, 3),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                Console.WriteLine($"Input: nums = [{String.Join(',', test.Item1)}], k = {test.Item2}");
                var output = solve.SmallestRangeII(test.Item1, test.Item2);
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item3.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}