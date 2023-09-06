/*
File Name: 
    18-reshape-the-matrix/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 22, 2022, 15:59:09

Description:
    In MATLAB, there is a handy function called reshape which can reshape an
    m x n matrix into a new one with a different size r x c keeping its 
    original data.

    You are given an m x n matrix mat and two integers r and c representing the
    number of rows and the number of columns of the wanted reshaped matrix.

    The reshaped matrix should be filled with all the elements of the original 
    matrix in the same row-traversing order as they were.

    If the reshape operation with given parameters is possible and legal,
    output the new reshaped matrix; Otherwise, output the original matrix.
*/
namespace ReshapeTheMatrix {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int, int, int[][])[] {
                 (new int[][] {
                     new int[] {1,2}
                    ,new int[] {3,4}
                    }, 1, 4
                    ,new int[][] {
                        new int[] {1,2,3,4}
                    })
                ,(new int[][] {
                     new int[] {1,2}
                    ,new int[] {3,4}
                    }, 2, 4
                    ,new int[][] {
                     new int[] {1,2}
                    ,new int[] {3,4}
                    })
            };

            var solve = new Queue.Solution();
            foreach((int[][], int, int, int[][]) t in testcases) {
                var prettyInput = new List<string>();
                foreach(int[] a in t.Item1)
                    prettyInput.Add($"[{String.Join(",",a)}]");
                Console.Write($"Input: nums1 = [{String.Join(",", prettyInput)}], ");
                Console.WriteLine($"r = {t.Item2}, c = {t.Item3}");
                var x = solve.MatrixReshape(t.Item1, t.Item2, t.Item3);
                var prettyOutput = new List<string>();
                foreach(int[] a in x)
                    prettyOutput.Add($"[{String.Join(",",a)}]");
                var outputString = $"[{String.Join(",", prettyOutput)}]";
                Console.WriteLine($"Output: {outputString}");

                var prettyTest = new List<string>();
                foreach(int[] a in t.Item4)
                    prettyTest.Add($"[{String.Join(",",a)}]");
                var testString = $"[{String.Join(",", prettyTest)}]";
                Console.WriteLine($"Pass: {testString.SequenceEqual(outputString)}");
                Console.WriteLine();
            }
        }
    }
}