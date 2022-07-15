/* // //
// FileName: 06-Zigzag_Conversion-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: Thursday, July 14, 2022, 14:56:29 PM
// Description: This file is the Main function that operates the test
//      cases and the Solution program for the problem.
*/ // //
namespace ZigzagConversion {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Zigzag Conversion\n");
            (string, int, string)[] testcases = {
                 ("PAYPALISHIRING",  1, "PAYPALISHIRING")
                ,("PAYPALISHIRING",  2, "PYAIHRNAPLSIIG")
                ,("PAYPALISHIRING",  3, "PAHNAPLSIIGYIR")
                ,("PAYPALISHIRING",  4, "PINALSIGYAHRPI")
                ,("PAYPALISHIRING",  5, "PHASIYIRPLIGAN")
                ,("PAYPALISHIRING",  6, "PRAIIYHNPSGAIL")
                ,("PAYPALISHIRING",  7, "PNAIGYRPIAHLSI")
                ,("PAYPALISHIRING",  8, "PAGYNPIARLIIHS")
                ,("PAYPALISHIRING",  9, "PAYPGANLIIRSIH")
                ,("PAYPALISHIRING", 10, "PAYPALGINSIHRI")
                ,("PAYPALISHIRING", 11, "PAYPALISGHNIIR")
                ,("PAYPALISHIRING", 12, "PAYPALISHIGRNI")
                ,("PAYPALISHIRING", 13, "PAYPALISHIRIGN")
                ,("PAYPALISHIRING", 14, "PAYPALISHIRING")
                ,("PAYPALISHIRING", 15, "PAYPALISHIRING")
            };

            Looper.Solution solve = new Looper.Solution();

            string r;
            foreach((string, int, string) test in testcases) {
                r = solve.Convert(test.Item1, test.Item2);
                // Print test cases that fail.
                if(r != test.Item3) {
                    Console.WriteLine($"Input: s=\"{test.Item1}\" numRows={test.Item2}");
                    Console.WriteLine($"Output: \"{r}\"");
                    Console.WriteLine($"Pass: {r == test.Item3}\n");
                }
            }
            return;
        }
    }
}