/*
File Name: 
    32-contains-duplicate/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 17:25:17

Description:
    Given an integer array nums, return true if any value appears at least
    twice in the array, and return false if every element is distinct.
*/
namespace ContainsDuplicate {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (int[], bool)[] {
                 
                 (new int[] {1,2,3,1}, true)
                ,(new int[] {1,2,3,4}, false)
                ,(new int[] {1,1,1,3,3,4,3,2,4,2}, true)
            };

            var solve = new Solution();
            foreach((int[], bool) t in testcases) {
                Console.WriteLine($"Input: [{String.Join(',', t.Item1)}]");
                var x = solve.ContainsDuplicate(t.Item1);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {t.Item2 == x}\n");
            }
        }
    }
}