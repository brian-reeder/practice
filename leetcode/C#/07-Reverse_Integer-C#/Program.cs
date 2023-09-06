/* // //
// FileName: 07-Reverse_Integer-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: Friday, July 15, 2022, 16:47:43 AM
// Description: This file is the Main function that operates the test
//      cases and the Solution program for the problem.
*/ // //
namespace ReverseInteger {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Reverse Integer");

            // Load all testcases.
            var testcases = new (int,int)[] {
                 ( 123, 321)
                ,(-123,-321)
                ,( 120,  21)
                ,(Int32.MaxValue, 0)
                ,(Int32.MinValue, 0)
            };

            var solve = new looper.Solution();
            int t;
            bool pass;
            foreach((int,int) test in testcases) {

                // Test the input.
                t = solve.Reverse(test.Item1);

                // Compare the output with the solution.
                pass = (t == test.Item2);

                // Display the test case if it failed.
                if(!pass) {
                    Console.WriteLine($"Input={test.Item1}");
                    Console.WriteLine($"Output={t}");
                    Console.WriteLine($"Pass={pass}");
                    Console.WriteLine();
                }
            }

            return;
        }
    }
}