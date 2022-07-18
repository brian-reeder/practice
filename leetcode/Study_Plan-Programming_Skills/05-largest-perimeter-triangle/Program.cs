/*
File Name: 
    05-largest-perimeter-triangle/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Monday, July 18, 2022, 15:04:08

Description:
    Given an integer array nums, return the largest perimeter of a triangle
    with a non-zero area, formed from three of these lengths. If it is
    impossible to form any triangle of a non-zero area, return 0.


Example 1:
    Input: nums = [2,1,2]
    Output: 5
Example 2:
    Input: nums = [1,2,1]
    Output: 0
Constraints:
    3 <= nums.length <= 10^4
    1 <= nums[i] <= 10^6
*/
namespace LargestPerimeterTriangle {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Largest Perimeter Triangle");

            var testcases = new (int[], int)[] {
                 (new int[] {2,1,2}, 5)
                ,(new int[] {1,2,1}, 0)
            };

            Solution solve = new Solution();
            int output;
            foreach((int[], int) t in testcases) {
                output = solve.LargestPerimeter(t.Item1);
                Console.WriteLine($"Input: [{String.Join(",", t.Item1)}]");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {output == t.Item2}");
                Console.WriteLine();
            }

            return;
        }
    }
}