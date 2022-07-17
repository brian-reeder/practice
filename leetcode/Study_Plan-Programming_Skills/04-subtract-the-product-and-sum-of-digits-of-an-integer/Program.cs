/*
File Name: 
    04-subtract-the-product-and-sum-of-digits-of-an-integer/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Sunday, July 17, 2022, 15:14:05

Description:
    Given an integer number n, return the difference between the product of its
        digits and the sum of its digits.


Example 1:
    Input: n = 234
    Output: 15 
    Explanation: 
        Product of digits = 2 * 3 * 4 = 24 
        Sum of digits = 2 + 3 + 4 = 9 
        Result = 24 - 9 = 15
Example 2:
    Input: n = 4421
    Output: 21
    Explanation: 
        Product of digits = 4 * 4 * 2 * 1 = 32 
        Sum of digits = 4 + 4 + 2 + 1 = 11 
        Result = 32 - 11 = 21
Constraints:
    1 <= n <= 10^5
*/
namespace SubtractTheProductAndSumOfDigitsOfAnInteger {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int, int)[] {
                 (234, 15)
                ,(4421, 21)
            };

            Solution solve = new Solution();
            foreach((int, int) t in testcases) {
                int x = solve.SubtractProductAndSum(t.Item1);
                Console.WriteLine($"Inputr: n = {t.Item1}");
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {x == t.Item2}");
                Console.WriteLine();
            }
            return;
        }
    }
}