/*
File Name: 
    58-subarray-product-less-than-k/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:10

Description:
    Given an array of integers nums and an integer k, return the number of
    contiguous subarrays where the product of all the elements in the subarray
    is strictly less than k.

Constraints:
    
    1 <= nums.length <= 3 * 10^4
    1 <= nums[i] <= 1000
    0 <= k <= 10^6
*/
namespace SubarrayProductLessThanK {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int)[] {
                (new int[] {10,5,2,6}, 100, 8),
                (new int[] {1,2,3}, 0, 0),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.NumSubarrayProductLessThanK(test.Item1, test.Item2);

                Console.WriteLine($"Input: nums = [{String.Join(',', test.Item1)}], k = {test.Item2}");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item3.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}