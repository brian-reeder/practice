/*
File Name: 
    43-add-binary/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 1, 2022, 11:40:44

Description:
    Given two binary strings a and b, return their sum as a binary string.

Constraints:
    1 <= a.length, b.length <= 104
    a and b consist only of '0' or '1' characters.
    Each string does not contain leading zeros except for the zero itself.
*/
namespace AddBinary {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, string, string)[] {
                 ("0", "1", "1")
                ,("1", "0", "1")
                ,("1", "1", "10")
                ,("10", "1", "11")
                ,("1", "10", "11")
                ,("10", "10", "100")
                ,("11", "11", "110")
                ,("1010", "1011", "10101")
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.AddBinary(test.Item1, test.Item2);
                Console.WriteLine($"Input: a = \"{test.Item1}\", b = \"{test.Item2}\"");
                Console.WriteLine($"Output: \"{output}\"");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}