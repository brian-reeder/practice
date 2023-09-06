/*
File Name: 
    39-evaluate-reverse-polish-notation/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 30, 2022, 22:56:13

Description:
    Evaluate the value of an arithmetic expression in Reverse Polish Notation.

    Valid operators are +, -, *, and /. Each operand may be an integer or 
    another expression.

    Note that division between two integers should truncate toward zero.

    It is guaranteed that the given RPN expression is always valid. That means
    the expression would always evaluate to a result, and there will not be any
    division by zero operation.

Constraints:
    1 <= tokens.length <= 10^4
    tokens[i] is either an operator: "+", "-", "*", or "/", or an integer in
    the range [-200, 200].
*/
namespace EvaluateReversePolishNotation {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string[], int)[] {
                 // 1
                 (new string[] {"1"}, 1)
                 // (2 + 1) * 3
                ,(new string[] {"2","1","+","3","*"}, 9)
                 // (4 + (13 / 5))
                ,(new string[] {"4","13","5","/","+"}, 6)
                // (8 - 4) / 4
                ,(new string[] {"8","4","-","4","/"}, 1)
                // 1 / 0
//                ,(new string[] {"1","0","/"}, 0)
            };

            Console.WriteLine($"{typeof(Program).Namespace}");

            var solve = new Solution();
            foreach(var test in testcases) {
                var prettyTokens = $"[\"{String.Join("\", \"", test.Item1)}\"]";
                var output = solve.EvalRPN(test.Item1);
                Console.WriteLine($"Input: tokens = {prettyTokens}");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item2.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}