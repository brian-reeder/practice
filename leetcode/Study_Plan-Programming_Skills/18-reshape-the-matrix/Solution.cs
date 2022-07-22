/*
File Name: 
    18-reshape-the-matrix/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 22, 2022, 15:59:41

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
namespace looper {
    public class Solution {
        public int[][] MatrixReshape(int[][] mat, int r, int c) {
            // Base case, no matrix.
            if(mat.Length == 0)
                return mat;

            var numElem = r * c;
            var oldR = mat.Length;
            var oldC = mat[0].Length;
            // Base case, matrix size mismatch
            if((oldR * oldC) != (numElem))
                return mat;

            // Early termination, same shape
            if((oldR == r) && (oldC == c))
                return mat;

            // Initialize new matrix r x c
            int[][] newMat = new int[r][];
            for(int row = 0; row < r; row++)
                newMat[row] = new int[c];

            // Column/Row iterators; 0:newMat, 1:mat
            var cols = new int[2] {0,0};
            var rows = new int[2] {0,0};
            for(int count = 0; count < numElem; count++) {
                newMat[rows[0]][cols[0]] = mat[rows[1]][cols[1]];

                // Increment columns
                cols[0] = (cols[0] + 1) % c;
                cols[1] = (cols[1] + 1) % oldC;

                // Increment row is column has overflowed
                if(cols[0] == 0)
                    rows[0] = (rows[0] + 1) % r;
                if(cols[1] == 0)
                    rows[1] = (rows[1] + 1) % oldR;
            }

            return newMat;
        }
    }
}

namespace Queue {
    public class Solution {
        public int[][] MatrixReshape(int[][] mat, int r, int c) {
            // Base case, no matrix.
            if(mat.Length == 0)
                return mat;

            var numElem = r * c;
            var oldR = mat.Length;
            var oldC = mat[0].Length;
            // Base case, matrix size mismatch
            if((oldR * oldC) != (numElem))
                return mat;

            // Early termination, same shape
            if((oldR == r) && (oldC == c))
                return mat;
            
            // Flatten input into a Queue
            var buff = new Queue<int>();
            foreach(int[] row in mat)
                foreach(int val in row)
                    buff.Enqueue(val);
            
            // Initialize new matrix r x c
            int[][] newMat = new int[r][];
            for(int row = 0; row < r; row++) {
                newMat[row] = new int[c];
                for(int col = 0; col < c; col++) {
                    newMat[row][col] = buff.Dequeue();
                }
            }

            return newMat;
        }
    }
}