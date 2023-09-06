/*
File Name: 
    01-count-odd-numbers-in-an-interval-range/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Saturday, July 16, 2022, 17:43:03

Description:
    Given two non-negative integers low and high. Return the count of
    odd numbers between low and high (inclusive)

Example 1:
    Input: low=3, high = 7
    Output: 3
    Explanation: The odd numbers between 3 and 7 are [3,5,7].
Example 2:
    Input: low=8, high = 10
    Output: 1
    Explanation: The odd numbers between 8 and 10 are [9].
Constraints:
    0 <= low <= high <= 10^9
*/
namespace CountOddNumbersInAnIntervalRange {
    public class Program {
        public static void Main(string[] args) {
            // int low, int high, int solution
            var testcases = new (int, int, int)[] {
                 ( 1,10, 5)
                ,( 1,11, 6)
                ,( 1,12, 6)
                ,( 1,13, 7)
                ,( 1,14, 7)
                ,( 1,15, 8)
                ,( 2,10, 4)
                ,( 2,11, 5)
                ,( 2,12, 5)
                ,( 2,13, 6)
                ,( 2,14, 6)
                ,( 2,15, 7)
                ,( 3,10, 4)
                ,( 3,11, 5)
                ,( 3,12, 5)
                ,( 3,13, 6)
                ,( 3,14, 6)
                ,( 3,15, 7)
            };

            Solution solve = new Solution();
            int x;
            foreach((int,int,int) t in testcases) {
                x = solve.CountOdds(t.Item1, t.Item2);
                
                Console.WriteLine($"Input: low={t.Item1} high={t.Item2}");
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {x == t.Item3}");
                Console.WriteLine();
                
            }
            Console.WriteLine("Done");

            return;
        }
    }
}