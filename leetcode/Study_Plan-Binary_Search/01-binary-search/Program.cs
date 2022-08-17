/*
File Name: 
    01-binary-search/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 17, 2022, 15:33

Description:
    Given an array of integers nums which is sorted in ascending order, and an
    integer target, write a function to search target in nums. If target
    exists, then return its index. Otherwise, return -1.

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 1 <= nums.length <= 10^4
    * -10^4 < nums[i], target < 10^4
    * All the integers in nums are unique.
    * nums is sorted in ascending order.
*/
namespace BinarySearch {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int)[] {
                (new int[] {-1,0,3,5,9,12}, 9, 4),
                (new int[] {-1,0,3,5,9,12}, 2, -1),
                (new int[] {100}, 0, -1),
                (new int[] {100}, 200, -1)
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.Search(test.Item1, test.Item2);
                Console.WriteLine($"Input: nums = [{String.Join(',', test.Item1)}], target = {test.Item2}");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item3.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}