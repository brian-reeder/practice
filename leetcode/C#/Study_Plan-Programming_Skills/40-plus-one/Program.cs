/*
File Name: 
    40-plus-one/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 30, 2022, 23:41:19

Description:
    You are given a large integer represented as an integer array digits, where
    each digits[i] is the ith digit of the integer. The digits are ordered from
    most significant to least significant in left-to-right order. The large
    integer does not contain any leading 0's.

    Increment the large integer by one and return the resulting array of
    digits.

Constraints:
    1 <= digits.length <= 100
    0 <= digits[i] <= 9
    digits does not contain any leading 0's.
*/
namespace PlusOne {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[])[] {
                 (new int[] {1,2,3}, new int[] {1,2,4})
                ,(new int[] {4,3,2,1}, new int[] {4,3,2,2})
                ,(new int[] {9}, new int[] {1,0})
                ,(new int[] {9,9,9}, new int[] {1,0,0,0})
                ,(new int[] {8,9,9}, new int[] {9,0,0})
            };

            Console.WriteLine($"{typeof(Program).Namespace}");

            var solve = new Solution();
            foreach(var test in testcases) {
                var prettyTokens = $"[{String.Join(',', test.Item1)}]";
                var output = solve.PlusOne(test.Item1);
                var prettyOutput = $"[{String.Join(',', output)}]";
                Console.WriteLine($"Input: tokens = {prettyTokens}");
                Console.WriteLine($"Output: {prettyOutput}");
                Console.WriteLine($"Pass: {test.Item2.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}