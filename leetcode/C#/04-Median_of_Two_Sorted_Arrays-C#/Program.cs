/* // //
// FileName: 04-Median_of_Two_Sorted_Arrays-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 12 JULY 2022 14:43:28 UTC
// Description: This file is the Main function that operates the test
//      cases and the Solution program for the problem.
*/ // //
namespace MedianOfTwoSortedArrays {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Median of Two Sorted Arrays");

            // Load the test cases.
            // ,(new int[]{}, new int[]{})
            (int[], int[])[] testcases = {
                (new int[]{1,3}, new int[]{2})
                ,(new int[]{1,2}, new int[]{3,4})
                ,(new int[]{2}, new int[]{1,3})
                ,(new int[]{3,4}, new int[]{1,2})
                };

            MedianOfTwoSortedArrays.Looper.Solution solve = new MedianOfTwoSortedArrays.Looper.Solution();
            double x;
            foreach((int[], int[]) testcase in testcases) {
                // Pretty print the input
                Console.WriteLine($"A1=[{string.Join(",", testcase.Item1)}]");
                Console.WriteLine($"A2=[{string.Join(",", testcase.Item2)}]");

                // Execute the Looper Solution on the testcases
                x = solve.FindMedianSortedArrays(testcase.Item1, testcase.Item2);
                Console.WriteLine($"Output={x}\n");
            }
        }
    }
}