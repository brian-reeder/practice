/*
File Name: 
    22-to-lower-case/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 24, 2022, 14:50:35

Description:
    Given a string s, return the string after replacing every uppercase letter
    with the same lowercase letter.
*/
namespace ToLowerCase {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, string)[] {
                 ("Hello", "hello")
                ,("here", "here")
                ,("LOVELY", "lovely")
            };

            var solve = new Looper.Solution();
            foreach((string, string) t in testcases) {
                Console.WriteLine($"Input: s = \"{t.Item1}");
                var x = solve.ToLowerCase(t.Item1);
                Console.WriteLine($"Output: \"{x}\"");

                // Check output against the test
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}