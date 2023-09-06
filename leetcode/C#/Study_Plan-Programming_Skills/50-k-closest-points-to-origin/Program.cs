/*
File Name: 
    50-k-closest-points-to-origin/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 4, 2022, 22:04:06

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
namespace KClosestPointsToOrigin {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int, int[][])[] {
                (new int[][]{
                    new int[] {1,3},
                    new int[] {-2,2}
                },
                1,
                new int[][] {new int[]{-2,2}}),
                (new int[][]{
                    new int[] {3,3},
                    new int[] {5,-1},
                    new int[] {-2,4}
                },
                2,
                new int[][] {
                    new int[]{3,3},
                    new int[]{-2,4}
                    })
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.KClosest(test.Item1, test.Item2);
                Console.WriteLine($"Input: poiints = [{MatrixToString(test.Item1)}], k = {test.Item2}");
                Console.WriteLine($"Output: {MatrixToString(output)}");
                Console.WriteLine($"Pass: {MatrixEquals(test.Item3, output)}");
                Console.WriteLine();
            }
        } // Main
        public static string MatrixToString(int[][] m) {
            var sList = new List<string>();
            foreach(var row in m)
                sList.Add($"[{String.Join(',', row)}]");

            return $"[{String.Join(',', sList)}]";
        } // MatrixToString

        public static bool MatrixEquals(int[][] m1, int[][] m2) {
            if(m1.Length != m2.Length)
                return false;
            for(int i = 0; i < m1.Length; i++)
                if(m1[i].Length == m2[i].Length) {
                    for(int j = 0; j < m1[i].Length; j++)
                        if(m1[i][j] != m2[i][j])
                            return false;
                }
                else
                    return false;
            
            return true;
        }
    }
}