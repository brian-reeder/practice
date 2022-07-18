/*
File Name: 
    06-find-nearest-point-that-has-the-same-x-or-y-coordinate/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Monday, July 18, 2022, 15:30:04

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

Example 1:
    Input: x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]]
    Output: 2
    Explanation: Of all the points, only [3,1], [2,4] and [4,4] are valid. Of
    the valid points, [2,4] and [4,4] have the smallest Manhattan distance from
    your current location, with a distance of 1. [2,4] has the smallest index,
    so return 2.
Example 2:
    Input: x = 3, y = 4, points = [[3,4]]
    Output: 0
    Explanation: The answer is allowed to be on the same location as your
    current location.
Example 3:
    Input: x = 3, y = 4, points = [[2,3]]
    Output: -1
    Explanation: There are no valid points.
Constraints:
    1 <= point.length <= 10^4
    points[i].length == 2
    1 <= x,y,ai,bi <= 10^4
*/
namespace FindNearestPointThatHastheSameXorYCoordinate {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Find Nearest Point That Has the Same X or Y Coordinate");
            var testcases = new (int, int, int[][], int)[] {
                 (3,4,new int[][] { new int[] {1,2}, new int[]{3,1}, new int[]{2,4}, new int[]{2,3}, new int[]{4,4} }, 2)
                ,(3,4,new int[][] { new int[] {3,4} }, 0)
                ,(3,4,new int[][] { new int[] {2,3} }, -1)
            };

            Solution solve = new Solution();
            foreach((int, int, int[][], int) t in testcases) {
                Console.Write($"Input: x = {t.Item1}, y = {t.Item2}, points = ");
                var s = new List<string>();
                for(int i = 0; i < t.Item3.Length; i++) {
                    string x = $"[{String.Join(",",t.Item3[i])}]";
                    s.Add(x);
                }
                Console.WriteLine($"[{String.Join(",", s)}]");
                var output = solve.NearestValidPoint(t.Item1, t.Item2, t.Item3);
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {output == t.Item4}");
                Console.WriteLine();
                
            }
            return;
        }
    }
}