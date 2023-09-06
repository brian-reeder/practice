/*
File Name: 
    16-richest-customer-wealth/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 21, 2022, 19:34:10

Description:
    You are given an m x n integer grid accounts where accounts[i][j] is the
    amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth
    that the richest customer has.

    A customer's wealth is the amount of money they have in all their bank
    accounts. The richest customer is the customer that has the maximum wealth.
*/
namespace RichestCustomerWealth {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[][], int)[] {
                 (new int[][] {
                     new int[] {1,2,3}
                    ,new int[] {3,2,1}
                    }, 6)
                ,(new int[][] {
                     new int[] {1,5}
                    ,new int[] {7,3}
                    ,new int[] {3,5}
                    }, 10)
                ,(new int[][] {
                     new int[] {2,8,7}
                    ,new int[] {7,1,3}
                    ,new int[] {1,9,5}
                    }, 17)
            };

            var solve = new Solution();
            foreach((int[][], int) t in testcases) {
                var prettyInput = new List<string>();
                foreach(int[] a in t.Item1)
                    prettyInput.Add($"[{String.Join(",",a)}]");
                Console.WriteLine($"Input: nums1 = [{String.Join(",", prettyInput)}]");
                var x = solve.MaximumWealth(t.Item1);
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }
    }
}