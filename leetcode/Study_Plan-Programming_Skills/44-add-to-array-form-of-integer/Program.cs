/*
File Name: 
    44-add-to-array-form-of-integer/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 1, 2022, 17:21:46

Description:
    The array-form of an integer num is an array representing its digits in left to right order.

    For example, for num = 1321, the array form is [1,3,2,1].
    Given num, the array-form of an integer, and an integer k, return the array-form of the integer num + k.

Constraints:
    1 <= num.length <= 104
    0 <= num[i] <= 9
    num does not contain any leading zeros except for the zero itself.
    1 <= k <= 104
*/
namespace AddToArrayFormOfInteger {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int[])[] {
                // (new int[] {}, 0, new int[] {})
                 (new int[] {1,2,0,0}, 34, new int[] {1,2,3,4})
                ,(new int[] {2,7,4}, 181, new int[] {4,5,5})
                ,(new int[] {2,1,5}, 806, new int[] {1,0,2,1})
                ,(new int[] {0}, 0, new int[] {0})
                ,(new int[] {9}, 9, new int[] {1,8})
                ,(new int[] {9,9}, 9, new int[] {1,0,8})
                ,(new int[] {9}, 99, new int[] {1,0,8})
                ,(new int[] {9,9}, 99, new int[] {1,9,8})
                ,(new int[] {9,9,9}, 99, new int[] {1,0,9,8})
                ,(new int[] {9,9}, 999, new int[] {1,0,9,8})
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.AddToArrayForm(test.Item1, test.Item2);
                Console.WriteLine($"Input: num = [{String.Join(',', test.Item1)}], k = {test.Item2}");
                Console.WriteLine($"Output: [{String.Join(',', output)}]");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}