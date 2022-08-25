/*
File Name: 
    16-search-a-2d-matrix/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 16:47

Description:
    Write an efficient algorithm that searches for a value target in an m x n
    integer matrix matrix. This matrix has the following properties:
        * Integers in each row are sorted from left to right.
        * The first integer of each row is greater than the last integer of the
            previous row.

Constraints:
    * m == matrix.length
    * n == matrix[i].length
    * 1 <= m, n <= 100
    * -10^4 <= matrix[i][j], target <= 10^4
*/
namespace SearchA2dMatrix {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int, bool)[] {
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 0, false),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 1, true),
                 ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 3, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 5, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 7, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 8, false),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 10, true),
                 ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 11, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 16, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 20, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 21, false),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 23, true),
                 ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 30, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 34, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 60, true),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 69, false),
                ( new int[][] {
                    new int[] {1,3,5,7},
                    new int[] {10,11,16,20},
                    new int[] {23,30,34,60},
                }, 35, false),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var matrix = PrettyPrintMatrix(test.Item1);
                var output = solve.SearchMatrix(test.Item1, test.Item2);
                var pass = test.Item3.Equals(output);

                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput matrix = {matrix}, target = {test.Item2}");
                    
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine();
                }
            }
        }

        public static string PrettyPrintMatrix(int[][] m) {
            var rows = new string[m.Length];
            for(int i = 0; i < m.Length; i++)
                rows[i] = $"[{String.Join(',',m[i])}]";

            return $"[{String.Join(',',rows)}]";
        }
    }
}