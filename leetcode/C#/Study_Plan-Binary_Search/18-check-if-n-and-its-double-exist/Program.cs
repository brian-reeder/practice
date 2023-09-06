/*
File Name: 
    18-check-if-n-and-its-double-exist/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    25 August 2022, 17:58

Description:
    Given an array arr of integers, check if there exists two integers N and M
    such that N is the double of M ( i.e. N = 2 * M).

    More formally check if there exists two indices i and j such that :
    * i != j
    * 0 <= i, j < arr.length
    * arr[i] == 2 * arr[j]

Constraints:
    * 2 <= arr.length <= 500
    * -10^3 <= arr[i] <= 10^3
*/
namespace CheckIfNAndItsDoubleExist {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], bool)[] {
                // (new int[] {}, true),
                (new int[] {10,2,5,3}, true),
                (new int[] {7,1,14,11}, true),
                (new int[] {3,1,7,11}, false),
                (new int[] {0,1,3}, false),
                (new int[] {-1,0,3}, false),
                (new int[] {-3,-1,0}, false),
                (new int[] {0,0,3}, true),
            };

            var solve = new Solution();
            for(int i = 1; i <= testcases.Length; i++) {
                var test = testcases[i-1];
                var output = solve.CheckIfExist(test.Item1);
                var pass = test.Item2.Equals(output);
                if(pass) {
                    Console.WriteLine($"Passed test #{i}");
                }
                else {
                    Console.WriteLine($"Failed test #{i}");
                    Console.WriteLine($"\tInput: arr = [{String.Join(',', test.Item1)}]");
                    Console.WriteLine($"\tOutput: {output}");
                    Console.WriteLine();
                }
            }
        }
    }
}