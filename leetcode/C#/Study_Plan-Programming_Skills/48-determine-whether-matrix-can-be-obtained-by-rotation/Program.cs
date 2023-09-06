/*
File Name: 
    48-determine-whether-matrix-can-be-obtained-by-rotation/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 4, 2022, 19:41:22

Description:
    Given two n x n binary matrices mat and target, return true if it is
    possible to make mat equal to target by rotating mat in 90-degree
    increments, or false otherwise.

Constraints:
    n == mat.length == target.length
    n == mat[i].length == target[i].length
    1 <= n <= 10
    mat[i][j] and target[i][j] are either 0 or 1
*/
namespace leetcode48 {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int[][], bool)[] {
                (
                    // Input1
                    new int[][] {
                        new int[]{0,1},
                        new int[]{1,0}
                        },
                    // Input2
                    new int[][] {
                        new int[]{1,0},
                        new int[]{0,1}
                    },
                    true
                ),
                (
                    // Input1
                    new int[][] {
                        new int[]{1,1},
                        new int[]{0,1}
                        },
                    // Input2
                    new int[][] {
                        new int[]{1,1},
                        new int[]{1,0}
                    },
                    true
                ),
                (
                    // Input1
                    new int[][] {
                        new int[]{0,1},
                        new int[]{1,1}
                        },
                    // Input2
                    new int[][] {
                        new int[]{1,0},
                        new int[]{0,1}
                    },
                    false
                ),
                (
                    // Input1
                    new int[][] {
                        new int[]{0,0,0},
                        new int[]{0,1,0},
                        new int[]{1,1,1}
                        },
                    // Input2
                    new int[][] {
                        new int[]{1,1,1},
                        new int[]{0,1,0},
                        new int[]{0,0,0}
                    },
                    true
                )
            };
            
            var solve = new Solution();
            foreach(var test in testcases) {
                //PrintMatrices(test.Item1, test.Item2);
                var output = solve.FindRotation(test.Item1, test.Item2);
                Console.WriteLine($"Input: mat = {MatrixToString(test.Item1)}, target = {MatrixToString(test.Item2)}");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item3.Equals(output)}");
                Console.WriteLine();
            }
        }// Main

        public static string MatrixToString(int[][] m) {
            var sList = new List<string>();
            foreach(var row in m) {
                sList.Add($"[{String.Join(',', row)}]");
            }

            return $"[{String.Join(',',sList)}]";
        }

        public static void PrintMatrices(int[][] m1, int[][] m2) {
            var n = m1[0].Length;
            for(int i = 0; i < n; i++) {
                Console.Write($"[{String.Join("][",m1[i])}]\t");
                Console.WriteLine($"[{String.Join("][",m2[i])}]");
            }
            Console.WriteLine();
        }
    }
}