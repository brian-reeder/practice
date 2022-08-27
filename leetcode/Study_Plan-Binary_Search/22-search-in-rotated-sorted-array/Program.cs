/*
File Name: 
    22-search-in-rotated-sorted-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 27, 2022, 21:15

Description:
    There is an integer array nums sorted in ascending order (with distinct
    values).
    Prior to being passed to your function, nums is possibly rotated at an
    unknown pivot index k (1 <= k < nums.length) such that the resulting array
    is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]]
    (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3
    and become [4,5,6,7,0,1,2].

    Given the array nums after the possible rotation and an integer target,
    return the index of target if it is in nums, or -1 if it is not in nums.

    You must write an algorithm with O(log n) runtime complexity.

Constraints:
    * 1 <= nums.length <= 5000
    * -10^4 <= nums[i] <= 10^4
    * All values of nums are unique.
    * nums is an ascending array that is possibly rotated.
    * -10^4 <= target <= 10^4
*/
namespace SearchInRotatedSortedArray {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int)[] {
                // (new int[] {}, 0, -1),
                (new int[] {0, 1, 2, 3, 4, 5, 6, 7}, 4, 4),
                (new int[] {1, 2, 3, 4, 5, 6, 7, 0}, 4, 3),
                (new int[] {2, 3, 4, 5, 6, 7, 0, 1}, 4, 2),
                (new int[] {3, 4, 5, 6, 7, 0, 1, 2}, 4, 1),
                (new int[] {4, 5, 6, 7, 0, 1, 2, 3}, 4, 0),
                (new int[] {5, 6, 7, 0, 1, 2, 3, 4}, 4, 7),
                (new int[] {6, 7, 0, 1, 2, 3, 4, 5}, 4, 6),
                (new int[] {7, 0, 1, 2, 3, 4, 5, 6}, 4, 5),
                (new int[] {0, 1, 2, 3, 4, 5, 6, 7}, 8, -1),
                (new int[] {4, 5, 6, 7, 0, 1, 2}, 0, 4),
                (new int[] {4, 5, 6, 7, 0, 1, 2}, 3, -1),
                (new int[] {1}, 0, -1),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.Search(test.Item1, test.Item2);
                var pass = test.Item3.Equals(output);

                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: nums = [{String.Join(',', test.Item1)}], target = {test.Item2}");
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine();
                }
            }
        }
    }
}