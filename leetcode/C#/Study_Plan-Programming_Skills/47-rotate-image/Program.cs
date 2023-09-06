/*
File Name: 
    47-rotate-image/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 3, 2022, 17:24:39

Description:
    You are given an n x n 2D matrix representing an image, rotate the image by
    90 degrees (clockwise).

    You have to rotate the image in-place, which means you have to modify the
    input 2D matrix directly. DO NOT allocate another 2D matrix and do the
    rotation.

Constraints:
    n == matrix.length == matrix[i].length
    1 <= n <= 20
    -1000 <= matrix[i][j] <= 1000
*/
namespace RotateImage {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int[][])[] {
                (new int[][] {
                    new int[] {5,1,9,11},
                    new int[] {2,4,8,10},
                    new int[] {13,3,6,7},
                    new int[] {15,14,12,16}

                }, new int[][] {
                    new int[] {15,13,2,5},
                    new int[] {14,3,4,1},
                    new int[] {12,6,8,9},
                    new int[] {16,7,10,11}
                })
            };

            var solve = new TransposeAndReflect.Solution();
            foreach(var test in testcases) {
                solve.Rotate(test.Item1);
                var n = test.Item1[0].Length;
                var pass = true;
                for(int i = 0; i < n; i++)
                    for(int j = 0; j < n; j++)
                        if(test.Item1[i][j] != test.Item2[i][j])
                            pass = false;
                Console.WriteLine($"Pass: {pass}");
            }
        }
    }
}