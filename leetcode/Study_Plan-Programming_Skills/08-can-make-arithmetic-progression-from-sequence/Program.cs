/*
File Name: 
    08-can-make-arithmetic-progression-from-sequence/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 17:43:49

Description:
    A sequence of numbers is called an arithmetic progression if the difference
    between any two consecutive elements is the same.
    
    Given an array of numbers arr, return true if the array can be rearranged
    to form an arithmetic progression. Otherwise, return false.

Example 1:
    Input: arr = [3,5,1]
    Output: true
    Explanation: We can reorder the elements as [1,3,5] or [5,3,1] with 
    differences 2 and -2 respectively, between each consecutive elements.
Example 2:
    Input: arr = [1,2,4]
    Output: false
    Explanation: There is no way to reorder the elements to obtain an arithmetic
    progression.
Constraints:
    2 <= arr.length <= 1000
    -106 <= arr[i] <= 106
*/
namespace CanMakeArithmeticProgessionFromSequence {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], bool)[] {
                 (new int[]{3, 5, 1}, true)
                ,(new int[]{1, 2, 4}, false)
            };

            var solve = new Solution();
            foreach((int[], bool) t in testcases) {
                Console.WriteLine($"Input: n = [{String.Join(",", t.Item1)}]");
                var x = solve.CanMakeArithmeticProgression(t.Item1);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {x == t.Item2}");
                Console.WriteLine();
            }
        }
    }
}