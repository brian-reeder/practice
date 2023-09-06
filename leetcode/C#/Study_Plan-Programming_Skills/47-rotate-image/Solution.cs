/*
File Name: 
    47-rotate-image/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 3, 2022, 17:28:14

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
namespace TransposeAndReflect {
    public class Solution {
        public void Rotate(int[][] matrix) {
            Transpose(matrix);
            Reflect(matrix);
        }
        
        public void Transpose(int[][] matrix) {
            var n = matrix[0].Length;
            for(int i = 0; i < n; i++) {
                for(int j = i+1; j < n; j++) {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }
        
        public void Reflect(int[][] matrix) {
            var n = matrix[0].Length;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n/2; j++) {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n-j-1];
                    matrix[i][n-j-1] = temp;
                }
            }
        }
    }
}