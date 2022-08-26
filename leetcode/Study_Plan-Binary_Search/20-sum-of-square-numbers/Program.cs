/*
File Name: 
    20-sum-of-square-numbers/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 26, 2022, 17:58

Description:
    Given a non-negative integer c, decide whether there're two integers a and
    b such that a2 + b2 = c

Constraints:
    * 0 <= c <= 231 - 1
*/
namespace SumOfSquareNumbers {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int, bool)[] {
                (0, true),
                (1, true),
                (2, true),
                (3, false),
                (4, true),
                (5, true)
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.JudgeSquareSum(test.Item1);
                var pass = test.Item2.Equals(output);
                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: c = {test.Item1}");
                    Console.WriteLine($"\tOuput: {output}");
                    Console.WriteLine();
                }
            }
        }
    }
}