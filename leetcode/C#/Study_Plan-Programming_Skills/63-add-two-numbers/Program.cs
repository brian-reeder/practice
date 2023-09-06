/*
File Name: 
    63-add-two-numbers/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 11, 2022, 20:15

Description:
    You are given two non-empty linked lists representing two non-negative
    integers. The digits are stored in reverse order, and each of their nodes
    contains a single digit. Add the two numbers and return the sum as a
    linked list.

    You may assume the two numbers do not contain any leading zero, except the
    number 0 itself.

Constraints:
    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have leading zeros.
*/
namespace AddTwoNumbers {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[], int[])[] {
                (new int[] {2,4,3},
                 new int[] {5,6,4},
                 new int[] {7,0,8}),
                (new int[] {0},
                 new int[] {0},
                 new int[] {0}),
                (new int[] {9, 9, 9, 9, 9, 9, 9},
                 new int[] {9, 9, 9, 9},
                 new int[] {8, 9, 9, 9, 0, 0, 0, 1})
            };

            var solve = new Iterate.Solution();
            foreach(var test in testcases) {
                ListNode? l1 = null;
                for(int i = test.Item1.Length-1; i >= 0; i--)
                    l1 = new ListNode(test.Item1[i], l1);
                ListNode? l2 = null;
                for(int i = test.Item2.Length-1; i >= 0; i--)
                    l2 = new ListNode(test.Item2[i], l2);
                
                var output = solve.AddTwoNumbers(l1, l2);
                var listOutput = new List<int>();
                for(var walk = output; walk != null; walk = walk.next)
                    listOutput.Add(walk.val);
                
                Console.WriteLine($"Input: l1 = [{String.Join(',', test.Item1)}], l2 = [{String.Join(',', test.Item2)}]");
                Console.WriteLine($"Output: [{String.Join(',', listOutput)}]");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(listOutput.ToArray())}");
                Console.WriteLine();
            }
        }
    }
}