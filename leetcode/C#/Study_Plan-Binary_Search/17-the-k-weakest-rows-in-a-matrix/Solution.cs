/*
File Name: 
    17-the-k-weakest-rows-in-a-matrix/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 17:20

Description:
    You are given an m x n binary matrix mat of 1's (representing soldiers) and
    0's (representing civilians). The soldiers are positioned in front of the
    civilians. That is, all the 1's will appear to the left of all the 0's in
    each row.

    A row i is weaker than a row j if one of the following is true:
    * The number of soldiers in row i is less than the number of soldiers in
        row j.
    * Both rows have the same number of soldiers and i < j.
    * Return the indices of the k weakest rows in the matrix ordered from
        weakest to strongest.

Constraints:
    * m == mat.length
    * n == mat[i].length
    * 2 <= n, m <= 100
    * 1 <= k <= m
    * matrix[i][j] is either 0 or 1.
*/
public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var ans = new int[k];
        var rowsWeighted = new PriorityQueue<int, (int,int)>();
        for(int i = 0; i < mat.Length; i++)
            rowsWeighted.Enqueue(i, (Count1s(mat[i]), i));

        for(int i = 0; i < k; i++)
            ans[i] = rowsWeighted.Dequeue();

        return ans;
    }

    public int Count1s(int[] row) {
        int min, mid, max;
        min = 0; 
        max = row.Length-1;
        for(mid=max/2; min<=max; mid=min+(max-min)/2)
            if(row[mid] == 0)
                max = mid-1;
            else
                min = mid+1;
        return min;
    }
}