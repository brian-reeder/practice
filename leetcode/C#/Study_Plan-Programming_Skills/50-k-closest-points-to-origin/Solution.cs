/*
File Name: 
    50-k-closest-points-to-origin/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 4, 2022, 22:26:42

Description:
    Given an array of points where points[i] = [xi, yi] represents a point on
    the X-Y plane and an integer k, return the k closest points to the origin
    (0, 0).

    The distance between two points on the X-Y plane is the Euclidean distance
    (i.e., √(x1 - x2)2 + (y1 - y2)2).

    You may return the answer in any order. The answer is guaranteed
    to be unique (except for the order that it is in).

Constraints:
    1 <= k <= points.length <= 10^4
    -10^4 < xi, yi < 10^4
*/
public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pointSet = new int[k][];
        var pointBuf = new PriorityQueue<int[], double>();
        
        var origin = new int[] {0,0};
        foreach(var point in points)
            pointBuf.Enqueue(point, EuclideanDistance(origin, point));

        for(int i = 0; i < k; i++)
            pointSet[i] = pointBuf.Dequeue();
        
        return pointSet;
    }
    
    public double EuclideanDistance(int[] point1, int[] point2) {
        int x1, x2, y1, y2;
        x1 = point1[0];
        x2 = point2[0];
        y1 = point1[1];
        y2 = point2[1];
        
        return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
    }
}