/*
File Name: 
    12-kth-missing-positive-number/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 22, 2022, 16:02

Description:
    Given an array arr of positive integers sorted in a strictly increasing
    order, and an integer k.

    Return the kth positive integer that is missing from this array

Constraints:
    * 1 <= arr.length <= 1000
    * 1 <= arr[i] <= 1000
    * 1 <= k <= 1000
    * arr[i] < arr[j] for 1 <= i < j <= arr.length
*/
namespace KthMissingPositiveNumber {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int)[] {
                (new int[] {2,3,4,7,11}, 5, 9),
                (new int[] {1,2,3,4}, 2, 6),
            };
            
            Solution solve = new();
            int output;
            bool pass;
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                output = solve.FindKthPositive(test.Item1, test.Item2);
                pass = test.Item3.Equals(output);
                if(pass) {
                    Console.WriteLine($"Passed testcase #{i}");
                }
                else {
                    Console.WriteLine($"Faile test #{i}");
                    Console.WriteLine($"\tInput: arr = [{String.Join(',', test.Item1)}], k = {test.Item2}");
                    Console.WriteLine($"\tOutput: {test.Item3}");
                    Console.WriteLine();
                }
            }

        }
    }
}