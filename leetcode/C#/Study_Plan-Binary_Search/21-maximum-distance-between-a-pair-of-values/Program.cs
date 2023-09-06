/*
File Name: 
    21-maximum-distance-between-a-pair-of-values/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 27, 2022, 16:13

Description:
    You are given two non-increasing 0-indexed integer arrays nums1​​​​​​ and nums2​​​​​​.
    A pair of indices (i, j), where 0 <= i < nums1.length and 
    0 <= j < nums2.length, is valid if both i <= j and nums1[i] <= nums2[j].
    The distance of the pair is j - i​​​​.

    Return the maximum distance of any valid pair (i, j). If there are no valid
    pairs, return 0.

    An array arr is non-increasing if arr[i-1] >= arr[i] for every
    1 <= i < arr.length.

Constraints:
    * 1 <= nums1.length, nums2.length <= 10^5
    * 1 <= nums1[i], nums2[j] <= 10^5
    * Both nums1 and nums2 are non-increasing.
*/
namespace MaximumsDistanceBetweenAPairOfValues {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[], int)[] {
                // (new int[] {}, new int[] {}, 0),
                (new int[] {55,30,5,4,2}, new int[] {100,20,10,10,5}, 2),
                (new int[] {2,2,2}, new int[] {10,10,1}, 1),
                (new int[] {30,29,19,5}, new int[] {25,25,25,25,25}, 2),
                
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.MaxDistance(test.Item1, test.Item2);
                var pass = test.Item3.Equals(output);
                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: nums1 = [{String.Join(',', test.Item1)}], nums2 = [{String.Join(',', test.Item2)}]");
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine();
                }
            }
        }
    }
}