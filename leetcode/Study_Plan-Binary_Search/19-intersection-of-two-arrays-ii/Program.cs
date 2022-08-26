/*
File Name: 
    19-intersection-of-two-arrays-ii/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 26, 2022 17:42

Description:
    Given two integer arrays nums1 and nums2, return an array of their
    intersection. Each element in the result must appear as many times as it
    shows in both arrays and you may return the result in any order.

Constraints:
    * 1 <= nums1.length, nums2.length <= 1000
    * 0 <= nums1[i], nums2[i] <= 1000
*/
namespace IntersectionOfTwoArraysII {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[], int[])[] {
                //(new int[] {}, new int[]{}, new int[] {}),
                (new int[] {4,7,9,7,6,7},
                    new int[]{5,0,0,6,1,6,2,2,4},
                    new int[] {4,6}),
                (new int[] {1,1,1,1},
                    new int[]{1},
                    new int[] {1}),
                (new int[] {1,1,1,1},
                    new int[]{1,1},
                    new int[] {1,1}),
                (new int[] {1,1,1,1},
                    new int[]{1,1,1},
                    new int[] {1,1,1}),
                (new int[] {1,1,1,1},
                    new int[]{1,1,1,1},
                    new int[] {1,1,1,1}),
                (new int[] {1,1,1,1},
                    new int[]{1,1,1},
                    new int[] {1,1,1}),
                (new int[] {1,1,1,1},
                    new int[]{1,1},
                    new int[] {1,1}),
                (new int[] {1,1,1,1},
                    new int[]{1},
                    new int[] {1}),
                (new int[] {1,2,2,1},
                    new int[]{2,2},
                    new int[] {2,2}),
                (new int[] {2,2},
                    new int[]{1,2,2,1},
                    new int[] {2,2}),
                (new int[] {4,9,5},
                    new int[]{9,4,9,8,4},
                    new int[] {4,9}),
                (new int[]{9,4,9,8,4},
                    new int[] {4,9,5},
                    new int[] {4,9}),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.Intersect(test.Item1, test.Item2);
                var pass = test.Item3.SequenceEqual(output);
                if(pass) {
                    Console.WriteLine($"Passes test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: nums1 = [{String.Join(',',test.Item1)}], nums2 = [{String.Join(',', test.Item2)}]");
                    Console.WriteLine($"\tOutput: [{String.Join(',', output)}]");
                    Console.WriteLine();
                }
            }
        }
    }
}