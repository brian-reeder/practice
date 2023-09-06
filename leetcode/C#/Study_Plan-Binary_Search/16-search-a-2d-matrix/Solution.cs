/*
File Name: 
    16-search-a-2d-matrix/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 16:47

Description:
    Write an efficient algorithm that searches for a value target in an m x n
    integer matrix matrix. This matrix has the following properties:
        * Integers in each row are sorted from left to right.
        * The first integer of each row is greater than the last integer of the
            previous row.

Constraints:
    * m == matrix.length
    * n == matrix[i].length
    * 1 <= m, n <= 100
    * -10^4 <= matrix[i][j], target <= 10^4
*/
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int min, mid, max, row;
        min = 0; 
        max = matrix.Length-1;
        for(mid = max/2; min<=max; mid=min+(max-min)/2) {
            var x = matrix[mid][0];
            if(x == target)
                return true;
            else if(x > target)
                max = mid-1;
            else
                min = mid+1;
        }
        
        row = max;
        min = 0;
        max = row >= 0 && row < matrix.Length ? matrix[row].Length-1 : -1;
        for(mid = max/2; min<=max; mid=min+(max-min)/2) {
            var x = matrix[row][mid];
            if(x == target)
                return true;
            else if(x > target)
                max = mid-1;
            else
                min = mid+1;
        }

        return false;
    }
}