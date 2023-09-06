/*
File Name: 
    11-arranging-coins/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 22, 2022, 15:53

Description:
    You have n coins and you want to build a staircase with these coins. The
    staircase consists of k rows where the ith row has exactly i coins. The
    last row of the staircase may be incomplete.

    Given the integer n, return the number of complete rows of the staircase
    you will build.

Constraints:
    * 1 <= n <= 2^31 - 1
*/
namespace ArrangingCoins {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int, int)[] {
                (5, 2),
                (8, 3),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.ArrangeCoins(test.Item1);
                var pass = test.Item2.Equals(output);
                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"Input: n = {test.Item1}");
                    Console.WriteLine($"Output: {output}");
                    Console.WriteLine();
                }
            }
        }
    }
}