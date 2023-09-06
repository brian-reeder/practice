/*
File Name: 
    48-determine-whether-matrix-can-be-obtained-by-rotation/Solution.cs
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
public class Solution {
    public bool FindRotation(int[][] mat, int[][] target) {
        if(MatrixEqual(mat, target))
            return true;

        for(int i = 1; i <= 3; i++) {
            // Rotate 90 degrees
            Transpose(mat);
            Reflect(mat);
            if(MatrixEqual(mat, target))
                return true;
        }

        return false;
    }

    public bool MatrixEqual(int[][] m1, int[][]m2) {
        var n = m1.Length;
        for(int i = 0; i < n; i++) {
            if(!m1[i].SequenceEqual(m2[i]))
                return false;
        }

        return true;
    }

    public void Transpose(int[][] m) {
        var n = m[0].Length;
        for(int i = 0; i < n; i++) {
            for(int j = i+1; j < n; j++) {
                var t = m[i][j];
                m[i][j] = m[j][i];
                m[j][i] = t;
            }
        }
    }

    public void Reflect(int[][] m) {
        var n = m[0].Length;
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n /2; j++) {
                var t = m[i][j];
                m[i][j] = m[i][n-j-1];
                m[i][n-j-1] = t;
            }
        }
    }
}