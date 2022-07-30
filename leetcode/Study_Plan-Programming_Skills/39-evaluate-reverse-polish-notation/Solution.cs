/*
File Name: 
    39-evaluate-reverse-polish-notation/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 30, 2022, 22:57:06

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
public class Solution {
    public int EvalRPN(string[] tokens) {
        var intStack = new Stack<int>();
        var intBuff = new int[2 + ((tokens.Length-3)/2)];
        int count = 0;
        foreach(var token in tokens) {
            switch(token) {
                case "+":
                    count--;
                    intBuff[count-1] += intBuff[count];
                break;

                case "-":
                    count--;
                    intBuff[count-1] -= intBuff[count];
                break;

                case "*":
                    count--;
                    intBuff[count-1] *= intBuff[count];
                break;

                case "/":
                    count--;
                    intBuff[count-1] /= intBuff[count];
                break;

                default:
                    intBuff[count] = int.Parse(token);
                    count++;
                break;
            }
        }

        return count > 0 ? intBuff[0] : 0;
    }
}