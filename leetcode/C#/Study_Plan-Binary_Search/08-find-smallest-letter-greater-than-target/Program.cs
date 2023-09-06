/*
File Name: 
    08-find-smallest-letter-greater-than-target/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 17:25

Description:
    Given a characters array letters that is sorted in non-decreasing order and
    a character target, return the smallest character in the array that is
    larger than target.

    Note that the letters wrap around.

    For example, if target == 'z' and letters == ['a', 'b'], the answer is 'a'.

Constraints:
    * 2 <= letters.length <= 10^4
    * letters[i] is a lowercase English letter.
    * letters is sorted in non-decreasing order.
    * letters contains at least two different characters.
    * target is a lowercase English letter.
*/
namespace FindSmallestLetterGreaterThanTarget {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (char[], char, char)[] {
                (new char[] {'c','f','j'}, 'a', 'c'),
                (new char[] {'c','f','j'}, 'c', 'f'),
                (new char[] {'c','f','j'}, 'j', 'c'),
                (new char[] {'c','f','j'}, 'd', 'f'),
            };

            var solve = new Solution();
            (char[], char, char) test;
            char output;
            bool pass;
            for(int i = 1; i <= testcases.Length; i++) {
                test = testcases[i-1];
                output = solve.NextGreatestLetter(test.Item1, test.Item2);
                pass = test.Item3.Equals(output);
                if(pass)
                    Console.WriteLine($"Passed test #{i}");
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: letters=[\"{String.Join("\",\"", test.Item1)}\"], target = \"{test.Item2}\"");
                    Console.WriteLine($"\tOutput: \"{output}\"");
                    Console.WriteLine();
                }
            }
        }
    }
}