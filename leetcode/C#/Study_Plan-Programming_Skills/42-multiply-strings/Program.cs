/*
File Name: 
    42-multiply-strings/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 31, 2022, 21:22:57

Description:
    Given two non-negative integers num1 and num2 represented as strings,
    return the product of num1 and num2, also represented as a string.

    Note: You must not use any built-in BigInteger library or convert the
    inputs to integer directly.

Constraints:
    1 <= num1.length, num2.length <= 200
    num1 and num2 consist of digits only.
    Both num1 and num2 do not contain any leading zero, except the number 0
    itself.
*/
namespace MultiplyStrings {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, string, string)[] {
                //,("", "", "")
                 ("0", "0", "0")
                ,("0", "10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", "0")
                ,("10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", "0", "0")
                ,("123", "456", "56088")
                ,("456", "123", "56088")
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                var output = solve.Multiply(test.Item1, test.Item2);
                Console.WriteLine($"Input: num1 = \"{test.Item1}\", num2 = \"{test.Item2}\"");
                Console.WriteLine($"Output: \"{output}\"");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(output)}");
                Console.WriteLine();
            }
        }
    }
}