/*
File Name: 
    02-guess-number-higher-or-lower/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 17, 2022, 16:16

Description:
    We are playing the Guess Game. The game is as follows:
    I pick a number from 1 to n. You have to guess which number I picked.
    Every time you guess wrong, I will tell you whether the number I picked is
        higher or lower than your guess.

    You call a pre-defined API int guess(int num), which returns three possible
        results:
    * -1: Your guess is higher than the number I picked (i.e. num > pick).
    * 1: Your guess is lower than the number I picked (i.e. num < pick).
    * 0: your guess is equal to the number I picked (i.e. num == pick).

    Return the number that I picked.

Constraints:
    * 1 <= n <= 2^31 - 1
    * 1 <= pick <= n
*/
namespace GuessNumberHigherOrLower {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int, int)[] {
                (10, 6),
                (1,1),
                (2, 1)
            };

            foreach(var test in testcases) {
                var solve = new Solution(test.Item2);
                var output = solve.GuessNumber(test.Item1);
                Console.WriteLine($"Input: n = {test.Item1}, pick = {test.Item2}");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item2.Equals(output)}");
                Console.WriteLine();
            }
        }
    }
}