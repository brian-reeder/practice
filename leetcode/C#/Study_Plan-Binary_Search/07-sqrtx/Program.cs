/*
File Name: 
    07-sqrtx/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 17:05

Description:
    Given a non-negative integer x, compute and return the square root of x.

    Since the return type is an integer, the decimal digits are truncated, and
    only the integer part of the result is returned.

    Note: You are not allowed to use any built-in exponent function or
    operator, such as pow(x, 0.5) or x ** 0.5.



Constraints:
    * 0 <= x <= 2^31 - 1
*/
namespace SqrtX {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int, int)[] {
                (0,0),
                (1,1),
                (2,1),
                (3,1),
                (4,2),
                (5,2),
                (6,2),
                (7,2),
                (8,2),
                (9,3),
                (69,8),
                (213,14),
                (125, 11),
            };

            var solve = new Solution();
            (int, int) test;
            int output;
            bool pass;
            for(int i = 1; i <= testcases.Length; i++) {
                test = testcases[i-1];
                output = solve.MySqrt(test.Item1);
                pass = test.Item2.Equals(output);
                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput x = {test.Item1}");
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine();
                }
            }
        }
    }
}