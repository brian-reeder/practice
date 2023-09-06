/*
File Name: 
    17-matrix-diagonal-sum/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 22, 2022, 15:33:19

Description:
    Given a square matrix mat, return the sum of the matrix diagonals.

    Only include the sum of all the elements on the primary diagonal and all
    the elements on the secondary diagonal that are not part of the primary
    diagonal.
*/
public class Solution {
    public int DiagonalSum(int[][] mat) {
        var sum = 0;
        var rightD = mat.Length-1;
        for(var leftD = 0; leftD < mat.Length;leftD++) {
            sum += leftD == rightD ? mat[leftD][leftD] : mat[leftD][leftD] + mat[leftD][rightD];
            rightD--;
        }
        return sum;
    }
}