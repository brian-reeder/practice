/*
File Name: 
    17-the-k-weakest-rows-in-a-matrix/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 17:18

Description:
    You are given an m x n binary matrix mat of 1's (representing soldiers) and
    0's (representing civilians). The soldiers are positioned in front of the
    civilians. That is, all the 1's will appear to the left of all the 0's in
    each row.

    A row i is weaker than a row j if one of the following is true:
    * The number of soldiers in row i is less than the number of soldiers in
        row j.
    * Both rows have the same number of soldiers and i < j.
    * Return the indices of the k weakest rows in the matrix ordered from
        weakest to strongest.

Constraints:
    * m == mat.length
    * n == mat[i].length
    * 2 <= n, m <= 100
    * 1 <= k <= m
    * matrix[i][j] is either 0 or 1.
*/
namespace TheKWeakestRowsInAMatrix {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int, int[])[] {
                // (new int[][] {}, 0, new int[] {}),
                (new int[][] {
                    new int[] {1,1,0,0,0},
                    new int[] {1,1,1,1,0},
                    new int[] {1,0,0,0,0},
                    new int[] {1,1,0,0,0},
                    new int[] {1,1,1,1,1}
                }, 3, new int[] {2,0,3}),

                (new int[][] {
                    new int[] {1,0,0,0},
                    new int[] {1,1,1,1},
                    new int[] {1,0,0,0},
                    new int[] {1,0,0,0},
                }, 2, new int[] {0,2}),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.KWeakestRows(test.Item1, test.Item2);
                var pass = test.Item3.SequenceEqual(output);

                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: mat = {MatrixToString(test.Item1)}, k = {test.Item2}");
                    Console.WriteLine($"\tOutput: [{String.Join(',', output)}]");
                    Console.WriteLine($"\tExpexted: [{String.Join(',', test.Item3)}]");
                    Console.WriteLine();
                }
            }
        }
        public static string MatrixToString(int[][] m) {
            var rows = new string[m.Length];
            for(int i = 0; i < m.Length; i++)
                rows[i] = $"[{String.Join(',', m[i])}]";

            return $"[{String.Join(',',rows)}]";
        }

    }

}