/*
File Name: 
    03-search-insert-position/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 18, 2022, 19:43

Description:
    Given a sorted array of distinct integers and a target value, return the
    index if the target is found. If not, return the index where it would be if
    it were inserted in order.

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 1 <= nums.length <= 10^4
    * -10^4 <= nums[i] <= 10^4
    * nums contains distinct values sorted in ascending order.
    * -10^4 <= target <= 10^4
*/
namespace SearchInsertPosition {
    public class Program {
        public static void Main(string[] args) {
            var testcases  = new (int[], int, int)[] {
                (new int[] {1,3,5,6}, 5, 2),
                (new int[] {1,3,5,6}, 2, 1),
                (new int[] {1,3,5,6}, 7, 4),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.SearchInsert(test.Item1, test.Item2);
                Console.WriteLine($"Input: nums = [{String.Join(',', test.Item1)}], target = {test.Item2}");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item3.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}