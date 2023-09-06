/*
File Name: 
    53-next-greater-element-ii/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 6, 2022, 15:36

Description:
    Given a circular integer array nums (i.e., the next element of
    nums[nums.length - 1] is nums[0]), return the next greater number for every
    element in nums.

    The next greater number of a number x is the first greater number to its
    traversing-order next in the array, which means you could search circularly
    to find its next greater number. If it doesn't exist, return -1 for this
    number.

Constraints:
    1 <= nums.length <= 104
    -10^9 <= nums[i] <= 10^9
*/
namespace NextGreaterElementII {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[])[] {
                (   new int[] {1,2,1},
                    new int[] {2,-1,2}
                ),
                (   new int[] {1,2,3,4,3},
                    new int[] {2,3,4,-1,4}
                ),
                (   new int[] {1,2,3,4,5},
                    new int[] {2,3,4,5,-1}
                ),
                (   new int[] {5,4,3,2,1},
                    new int[] {-1,5,5,5,5}
                ),
                (   new int[] {1,2,3,4,5,4,3,2,1},
                    new int[] {2,3,4,5,-1,5,4,3,2}
                ),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.NextGreaterElements(test.Item1);
                Console.WriteLine($"Input: [{String.Join(',', test.Item1)}]");
                Console.WriteLine($"Output: [{String.Join(',', output)}]");
                Console.WriteLine($"Pass: {test.Item2.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}