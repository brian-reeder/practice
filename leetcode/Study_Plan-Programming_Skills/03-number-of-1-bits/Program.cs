/*
File Name: 
    03-number-of-1-bits/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Sunday, July 17, 2022, 14:39:26

Description:
    Write a function that takes an unsigned integer and returns the number of 
        '1' bits it has (also known as the Hamming weight).

Example 1:
    Input: n = 00000000000000000000000000001011
    Output: 3
    Explanation: The input binary string 00000000000000000000000000001011 has
        a total of three '1' bits.
Example 2:
    Input: n = 00000000000000000000000010000000
    Output: 1
    Explanation: The input binary string 00000000000000000000000010000000 has 
        a total of one '1' bit.
Example 3:
    Input: n = 11111111111111111111111111111101
    Output: 1
    Explanation: The input binary string 11111111111111111111111111111101 has 
        a total of thirty one '1' bits.
Constraints:
    The input must be a binary string of length 32.
*/
namespace NumberOf1Bits {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Number of 1 bits");
            var testcases = new (uint, int)[] {
                 (0b00000000000000000000000000001011,  3)
                ,(0b00000000000000000000000010000000,  1)
                ,(0b11111111111111111111111111111101, 31)
            };

            Solution solve = new Solution();
            foreach((uint, int)t in testcases) {
                int x = solve.HammingWeight(t.Item1);
                
                Console.WriteLine($"Input: n={t.Item1}");
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {x == t.Item2}");
                Console.WriteLine();
            }
            return;
        }
    }
}