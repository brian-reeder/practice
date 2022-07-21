/*
File Name: 
    15-move-zeroes/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     July 21, 2022, 18:46:31

Description:
    Given an integer array nums, move all 0's to the end of it while maintaining
    the relative order of the non-zero elements.

    Note that you must do this in-place without making a copy of the array.
*/
namespace MoveZeroes {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[])[] {
                 (new int[] {0,1,0,3,12}, new int[] {1,3,12,0,0})
                ,(new int[] {0}, new int[] {0})
            };

            var solve = new Counter.Solution();
            foreach((int[], int[]) t in testcases) {
                Console.WriteLine($"Input: nums1 = [{String.Join(",", t.Item1)}]");
                solve.MoveZeroes(t.Item1);
                Console.WriteLine($"Output: [{String.Join(",", t.Item1)}]");
                Console.WriteLine($"Pass: {t.Item1.SequenceEqual(t.Item2)}");
                Console.WriteLine();
            }
        }
    }
}