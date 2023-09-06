/*
File Name: 
    04-peak-index-in-a-mountain-array/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 18, 2022, 20:06

Description:
    An array arr a mountain if the following properties hold:
        * arr.length >= 3
        * There exists some i with 0 < i < arr.length - 1 such that:
            * arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
            * arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
    Given a mountain array arr, return the index i such that 
    arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

    You must solve it in O(log(arr.length)) time complexity.

Constraints:
    * 3 <= arr.length <= 105
    * 0 <= arr[i] <= 106
    * arr is guaranteed to be a mountain array
*/
namespace PeakIndexInAMountainArray {
    public class Program { 
        public static void Main(string[] args) {
            var testcases = new (int[], int)[] {
                (new int[] {0,1,0}, 1),
                (new int[] {0,2,1,0}, 1),
                (new int[] {0,10,5,2}, 1),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.PeakIndexInMountainArray(test.Item1);
                Console.WriteLine($"Input arr = [{String.Join(',', test.Item1)}]");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item2.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}