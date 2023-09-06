/*
File Name: 
    06-find-the-distance-value-between-two-arrays/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 19, 2022, 17:02

Description:
    Given two integer arrays arr1 and arr2, and the integer d, return the
    distance value between the two arrays.

    The distance value is defined as the number of elements arr1[i] such that
    there is not any element arr2[j] where |arr1[i]-arr2[j]| <= d.

Constraints:
    * 1 <= arr1.length, arr2.length <= 500
    * -1000 <= arr1[i], arr2[j] <= 1000
    * 0 <= d <= 100
*/
namespace FindTheDistanceValueBetweenTwoArrays {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[], int, int)[] {
                (new int[] {4,5,8}, new int[] {10,9,1,8}, 2, 2),
                (new int[] {1,4,2,3}, new int[] {-4,-3,6,10,20,30}, 3, 2),
                (new int[] {2,1,100,3}, new int[] {-5,-2,10,-3,7}, 6, 1),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.FindTheDistanceValue(test.Item1, test.Item2, test.Item3);
                if(!test.Item4.Equals(output)) {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: arr1=[{String.Join(',', test.Item1)}], arr2=[{String.Join(',', test.Item2)}], d={test.Item3}");
                    Console.WriteLine($"\tOutput: {output}");
                }
                else
                    Console.WriteLine($"Passed test #{i}");
            }
        }
    }
}