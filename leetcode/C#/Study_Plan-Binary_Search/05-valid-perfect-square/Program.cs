/*
File Name: 
    05-valid-perfect-square/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 19, 2022, 16:48

Description:
    Given a positive integer num, write a function which returns True if num is
    a perfect square else False.

    Follow up: Do not use any built-in library function such as sqrt.

Constraints:
    * 1 <= num <= 2^31 - 1
*/
namespace ValidPerfectSquare {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int, bool)[] {
                (16, true),
                (14, false),
                (49, true),
                (100, true),
                (10000, true),
                (100000, false),
                (696913, false),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.IsPerfectSquare(test.Item1);
                if(!test.Item2.Equals(output)) {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: num = {test.Item1}");
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine($"\tPass: {test.Item2.Equals(output)}");
                }
                else
                    Console.WriteLine($"Passed test #{i}");
            }
            
        }
    }
}