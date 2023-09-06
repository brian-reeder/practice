/*
File Name: 
    29-sort-integers-by-the-number-of-1-bits/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 16:46:16

Description:
    You are given an integer array arr. Sort the integers in the array in
    ascending order by the number of 1's in their binary representation and in
    case of two or more integers have the same number of 1's you have to sort
    them in ascending order.

    Return the array after sorting it.
*/
namespace SortIntegersByTheNumberOf1Bits {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (int[], int[])[] {
                 
                 (new int[] {0,1,2,3,4,5,6,7,8}, new int[] {0,1,2,4,8,3,5,6,7})
                ,(new int[] {1024,512,256,128,64,32,16,8,4,2,1}, new int[] {1,2,4,8,16,32,64,128,256,512,1024})
            };

            var solve = new Solution();
            foreach((int[], int[]) t in testcases) {
                Console.WriteLine($"Input: root = [{String.Join(',', t.Item1)}]");
                var x = solve.SortByBits(t.Item1);
                Console.WriteLine($"Pass: {t.Item2.SequenceEqual(x)}\n");
            }
        }
    }
}