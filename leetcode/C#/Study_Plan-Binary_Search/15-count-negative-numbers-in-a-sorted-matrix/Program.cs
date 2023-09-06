/*
File Name: 
    15-count-negative-numbers-in-a-sorted-matrix/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 16:27

Description:
    Given a m x n matrix grid which is sorted in non-increasing order both
    row-wise and column-wise, return the number of negative numbers in grid.

Constraints:
    * m == grid.length
    * n == grid[i].length
    * 1 <= m, n <= 100
    * -100 <= grid[i][j] <= 100
*/
namespace CountNegativeNumbersInASortedMatrix {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int)[] {
                ( new int[][] {
                    new int[] {4,3,2,-1},
                    new int[] {3,2,1,-1},
                    new int[] {1,1,-1,-2},
                    new int[] {-1,-1,-2,-3}
                }, 8),
                ( new int[][] {
                    new int[] {3,2},
                    new int[] {1,0},
                }, 0),
                ( new int[][] {
                    new int[] {0},
                }, 0),
                ( new int[][] {
                    new int[] {0},
                    new int[] {0},
                }, 0),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.CountNegatives(test.Item1);
                var pass = test.Item2.Equals(output);

                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.Write($"\tInput grid = ");
                    PrettyPrintMatrix(test.Item1);
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine();
                }
            }
        }

        public static void PrettyPrintMatrix(int[][] m) {
            var rows = new string[m.Length];
            for(int i = 0; i < m.Length; i++)
                rows[i] = $"[{String.Join(',',m[i])}]";

            Console.WriteLine($"[{String.Join(',',rows)}]");
        }
    }
}