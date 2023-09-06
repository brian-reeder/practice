/*
File Name: 
    17-matrix-diagonal-sum/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 22, 2022, 15:32:52

Description:
    Given a square matrix mat, return the sum of the matrix diagonals.

    Only include the sum of all the elements on the primary diagonal and all
    the elements on the secondary diagonal that are not part of the primary
    diagonal.
*/
namespace MatrixDiagonalSum {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int)[] {
                 (new int[][] {
                     new int[] {1,2,3}
                    ,new int[] {4,5,6}
                    ,new int[] {7,8,9}
                    }, 25)
                ,(new int[][] {
                     new int[] {1,1,1,1}
                    ,new int[] {1,1,1,1}
                    ,new int[] {1,1,1,1}
                    ,new int[] {1,1,1,1}
                    }, 8)
                ,(new int[][] {
                     new int[] {5}
                    }, 5)
            };

            var solve = new Solution();
            foreach((int[][], int) t in testcases) {
                var prettyInput = new List<string>();
                foreach(int[] a in t.Item1)
                    prettyInput.Add($"[{String.Join(",",a)}]");
                Console.WriteLine($"Input: nums1 = [{String.Join(",", prettyInput)}]");
                var x = solve.DiagonalSum(t.Item1);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}