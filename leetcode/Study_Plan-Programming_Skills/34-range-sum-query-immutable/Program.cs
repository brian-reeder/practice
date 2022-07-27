/*
File Name: 
    34-range-sum-query-immutable/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 27, 2022, 16:26:11

Description:
    Given an integer array nums, handle multiple queries of the following type:
    Calculate the sum of the elements of nums between indices left and right
    inclusive where left <= right.

    Implement the NumArray class:
    NumArray(int[] nums) Initializes the object with the integer array nums.

    int sumRange(int left, int right) Returns the sum of the elements of nums
    between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
*/
namespace RangeSumQueryImmutable {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string[], int[][], string[])[] {
                 
                 (new string[] {"NumArray", "sumRange", "sumRange", "sumRange"},
                    new int[][] {
                         new int[] {-2, 0, 3, -5, 2, -1}
                        ,new int[] {0, 2}
                        ,new int[] {2, 5}
                        ,new int[] {0, 5}
                    },
                    new string[] {"null", "1", "-1", "-3"})
            };

            foreach((string[], int[][], string[]) t in testcases) {
                Console.WriteLine($"Input:\n [{String.Join(',', t.Item1)}]");
                var x = new string[t.Item1.Length];
                var array = new NumArray(new int[]{});
                for(int i = 0; i < t.Item1.Length; i++) {
                    switch(t.Item1[i]) {
                        case "NumArray":
                            array = new NumArray(t.Item2[i]);
                            x[i] = "null";
                            break;

                        case "sumRange":
                            x[i] = $"{array.SumRange(t.Item2[i][0], t.Item2[i][1])}";
                            break;
                    }
                }
                Console.WriteLine($"Output: {String.Join(',',x)}");
                Console.WriteLine($"Pass: {t.Item3.SequenceEqual(x)}\n");
            }
        }
    }
}