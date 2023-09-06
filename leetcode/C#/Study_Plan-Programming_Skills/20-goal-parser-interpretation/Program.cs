/*
File Name: 
    20-goal-parser-interpretation/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 23, 2022, 13:59:49

Description:
    You own a Goal Parser that can interpret a string command. The command 
    consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal
    Parser will interpret "G" as the string "G", "()" as the string "o", and 
    "(al)" as the string "al". The interpreted strings are then concatenated in
     the original order.

    Given the string command, return the Goal Parser's interpretation of command.
*/
namespace GoalParserInterpretation {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, string)[] {
                 ("G()(al)", "Goal")
                ,("G()()()()(al)", "Gooooal")
                ,("(al)G(al)()()G", "alGalooG")
                ,("", "")
            };

            var solve = new Solution();
            foreach((string, string) t in testcases) {
                Console.WriteLine($"Input: command = \"{t.Item1}\"");
                var x = solve.Interpret(t.Item1);
                Console.WriteLine($"Output: \"{x}\"");

                // Check output against the test
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}