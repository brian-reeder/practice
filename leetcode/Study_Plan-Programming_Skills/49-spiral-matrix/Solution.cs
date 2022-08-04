/*
File Name: 
    49-spiral-matrix/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 4, 2022, 20:14:22

Description:
    Given an m x n matrix, return all elements of the matrix in spiral order.

Constraints:
    m == matrix.length
    n == matrix[i].length
    1 <= m, n <= 10
    -100 <= matrix[i][j] <= 100
*/
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var m = matrix.Length;
        var n = matrix[0].Length;
        IList<int> elems = new List<int>(m*n);
        
        var count = 0;
        var i = 0;
        var j = 0;
        elems.Add(matrix[i][j]);
        // Position has been visited.
        matrix[i][j] = int.MinValue;
        count++;
        int dir = 0;
        for(;count != m*n; count++) {
            
            bool flag = true;
            while(flag) {
                switch(dir) {
                    // Try East.
                    case 0:
                        if(j+1 < matrix[i].Length && matrix[i][j+1] != int.MinValue) {
                            j++;
                            flag = false;
                        }
                        else
                            dir = (dir + 1)%4;
                    break;
                    // Try South.
                    case 1:
                        if(i+1 < matrix.Length && matrix[i+1][j] != int.MinValue) {
                            i++;
                            flag = false;
                        }
                        else
                            dir = (dir + 1)%4;
                    break;
                    // Try West.
                    case 2:
                        if(j-1 >= 0 && matrix[i][j-1] != int.MinValue) {
                            j--;
                            flag = false;
                        }
                        else
                            dir = (dir + 1)%4;
                    break;
                    // Try North.
                    case 3:
                        if(i-1 >= 0 && matrix[i-1][j] != int.MinValue) {
                            i--;
                            flag = false;
                        }
                        else
                            dir = (dir + 1)%4;
                    break;
                }
            }
            elems.Add(matrix[i][j]);
            matrix[i][j] = int.MinValue;
        }
        
        return elems;
    }
}