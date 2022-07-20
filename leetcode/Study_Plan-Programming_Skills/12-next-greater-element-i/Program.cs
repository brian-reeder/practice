/*
File Name: 
    11-n-ary-tree-preorder-traversal/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Wednesday, July 20, 2022, 17:16:47

Description:
    The next greater element of some element x in an array is the first greater
    element that is to the right of x in the same array.

    You are given two distinct 0-indexed integer arrays nums1 and nums2, where
    nums1 is a subset of nums2.

    For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j]
    and determine the next greater element of nums2[j] in nums2. If there is no
    next greater element, then the answer for this query is -1.

    Return an array ans of length nums1.length such that ans[i] is the next greater
    element as described above.
*/
namespace NAryTreePreorderTraversial {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[], int[])[] {
                 (new int[] {4,1,2}, new int[] {1,3,4,2}, new int[] {-1,3,-1})
                ,(new int[] {2, 4}, new int[] {1, 2, 3, 4}, new int[] {3, -1})
            };

            var solve = new Solution();
            foreach((int[], int[], int[]) t in testcases) {
                Console.WriteLine($"Input: nums1 = [{String.Join(",", t.Item1)}], nums2 = [{String.Join(",", t.Item2)}]");
                var x = solve.NextGreaterElement(t.Item1, t.Item2);
                Console.WriteLine($"Output: [{String.Join(",", x)}]");
                Console.WriteLine($"Pass: {t.Item3.SequenceEqual(x)}");
                Console.WriteLine();
            }
        }
    }
}