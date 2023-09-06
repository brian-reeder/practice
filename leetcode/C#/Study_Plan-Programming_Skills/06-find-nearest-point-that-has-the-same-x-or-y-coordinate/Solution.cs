/*
File Name: 
    06-find-nearest-point-that-has-the-same-x-or-y-coordinate/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Monday, July 18, 2022, 16:35:11

Description:
    You are given two integers, x and y, which represent your current location
    on a Cartesian grid: (x, y). You are also given an array points where each
    points[i] = [ai, bi] represents that a point exists at (ai, bi). A point is
    valid if it shares the same x-coordinate or the same y-coordinate as your
    location.

    Return the index (0-indexed) of the valid point with the smallest Manhattan
    distance from your current location. If there are multiple, return the
    valid point with the smallest index. If there are no valid points, return -1.

    The Manhattan distance between two points (x1, y1) and (x2, y2) is 
    abs(x1 - x2) + abs(y1 - y2).
*/
public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {

        var manhattanDistance = int.MaxValue;
        var manhattanIndex = -1;
        for(int i = 0; i < points.Length; i++)
            if(x == points[i][0] || y == points[i][1]) {
                // Abs(x-x1) + Abs(y-y1)
                int md = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
                if(md < manhattanDistance) {
                    manhattanDistance = md;
                    manhattanIndex    =  i;
                }
            }

        return manhattanIndex;
    }
}