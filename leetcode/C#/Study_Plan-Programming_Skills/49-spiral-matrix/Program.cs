/*
File Name: 
    49-spiral-matrix/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 4, 2022, 20:14:27

Description:
    Given an m x n matrix, return all elements of the matrix in spiral order.

Constraints:
    m == matrix.length
    n == matrix[i].length
    1 <= m, n <= 10
    -100 <= matrix[i][j] <= 100
*/
namespace SpiralMatrix {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int[])[] { 
                (new int[][]{
                    new int[] {1,2,3,4},
                    new int[] {5,6,7,8},
                    new int[] {9,10,11,12}
                },
                    new int[] {1,2,3,4,8,12,11,10,9,5,6,7}
                ), (new int[][]{
                    new int[] {1,2,3},
                    new int[] {4,5,6},
                    new int[] {7,8,9}
                },
                    new int[] {1,2,3,6,9,8,7,4,5}
                ),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                Console.WriteLine($"Input: {MatrixToString(test.Item1)}");
                var output = solve.SpiralOrder(test.Item1);
                Console.WriteLine($"Output: [{String.Join(',', output)}]");
                Console.WriteLine($"Pass: {test.Item2.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }

        public static string MatrixToString(int[][] matrix) {
            var m = matrix.Length;

            var sList = new List<string>();
            foreach(var row in matrix)
                sList.Add($"[{String.Join(',', row)}]");

            return $"[{String.Join(',', sList)}]";
        }
    }
}