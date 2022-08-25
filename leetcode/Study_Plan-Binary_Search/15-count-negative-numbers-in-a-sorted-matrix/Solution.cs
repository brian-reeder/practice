/*
File Name: 
    15-count-negative-numbers-in-a-sorted-matrix/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 16:29

Description:
    Given a m x n matrix grid which is sorted in non-increasing order both
    row-wise and column-wise, return the number of negative numbers in grid.

Constraints:
    * m == grid.length
    * n == grid[i].length
    * 1 <= m, n <= 100
    * -100 <= grid[i][j] <= 100
*/
public class Solution {
    public int CountNegatives(int[][] grid) {
        var count = 0;
        foreach(var row in grid)
            count += row.Length-BinarySearchNegative(row);
            
        return count;
    }
    
    public int BinarySearchNegative(int[] row) {
        int left, mid, right;
        
        left = 0;
        right = row.Length-1;
        for(mid=right/2; left <= right; mid = left+(right-left)/2)
            if(row[mid] >= 0)
                left = mid+1;
            else
                right = mid-1;
        
        return left;
    }
}