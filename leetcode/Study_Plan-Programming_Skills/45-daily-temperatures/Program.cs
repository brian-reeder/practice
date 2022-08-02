/*
File Name: 
    45-daily-temperatures/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 2, 2022, 16:07:28

Description:
    Given an array of integers temperatures represents the daily temperatures,
    return an array answer such that answer[i] is the number of days you have
    to wait after the ith day to get a warmer temperature. If there is no
    future day for which this is possible, keep answer[i] == 0 instead.

Constraints:
    1 <= temperatures.length <= 105
    30 <= temperatures[i] <= 100
*/
namespace DailyTemperatures {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[])[] {
                 (new int[] {73,74,75,71,69,72,76,73}, new int[] {1,1,4,2,1,1,0,0})
                ,(new int[] {30,40,50,60}, new int[] {1,1,1,0})
                ,(new int[] {30,60,90}, new int[] {1,1,0})
                ,(new int[] {1,2,3,4,5,6,7,8,9}, new int[] {1,1,1,1,1,1,1,1,0})
                ,(new int[] {9,8,7,6,5,4,3,2,1}, new int[] {0,0,0,0,0,0,0,0,0})
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.DailyTemperatures(test.Item1);
                Console.WriteLine($"Input: temperatures = [{String.Join(',', test.Item1)}]");
                Console.WriteLine($"Output: [{String.Join(',', output)}]");
                Console.WriteLine($"Pass: {test.Item2.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}