/*
File Name: 
    06-find-nearest-point-that-has-the-same-x-or-y-coordinate/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 16:30:00

Description:
    There is a function signFunc(x) that returns:
        1 if x is positive.
        -1 if x is negative.
        0 if x is equal to 0.

    You are given an integer array nums. Let product be the product of all values in the array nums.

    Return signFunc(product).

Example 1:
    Input: nums = [-1,-2,-3,-4,3,2,1]
    Output: 1
    Explanation: The product of all values in the array is 144, and signFunc(144) = 1
Example 2:
    Input: nums = [1,5,0,2,-3]
    Output: 0
    Explanation: The product of all values in the array is 0, and signFunc(0) = 0
Example 3:
    Input: nums = [-1,1,-1,1,-1]
    Output: -1
    Explanation: The product of all values in the array is -1, and signFunc(-1) = -1 
*/
namespace SignOfTheProductOfAnArray {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int)[] {
                 (new int[]{-1,-2,-3,-4,3,2,1}, 1)
                ,(new int[]{1,5,0,2,-3}, 0)
                ,(new int[]{-1,1,-1,1,-1}, -1)
            };

            var solve = new BitwiseXOR.Solution();
            int x;
            foreach((int[], int) t in testcases) {
                Console.WriteLine($"Input: n = [{String.Join(",", t.Item1)}]");
                x = solve.ArraySign(t.Item1);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {x == t.Item2}");
                Console.WriteLine();
            }
        }
    }
}