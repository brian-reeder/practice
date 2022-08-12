/*
File Name: 
    64-add-two-numbers-ii/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 12, 2022, 16:06

Description:
    You are given two non-empty linked lists representing two non-negative
    integers. The most significant digit comes first and each of their nodes
    contains a single digit. Add the two numbers and return the sum as a
    linked list.

    You may assume the two numbers do not contain any leading zero, except the
    number 0 itself.

Constraints:
    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have
    leading zeros.
*/
namespace AddTwoNumberII {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int[], int[])[] {
                (new int[] {7,2,4,3},
                 new int[] {5,6,4},
                 new int[] {7,8,0,7}),
                 
                (new int[] {2,4,3},
                 new int[] {5,6,4},
                 new int[] {8,0,7}),

                (new int[] {0},
                 new int[] {0},
                 new int[] {0})
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                ListNode? l1, l2;
                l1 = null;
                for(int i = test.Item1.Length-1; i >= 0; i--)
                    l1 = new ListNode(test.Item1[i], l1);
                l2 = null;
                for(int i = test.Item2.Length-1; i >= 0; i--)
                    l2 = new ListNode(test.Item2[i], l2);

                var output = solve.AddTwoNumbers(l1, l2);
                var outputList = new List<int>();
                for(; output != null; output = output.next)
                    outputList.Add(output.val);

                Console.WriteLine($"Input: l1 = [{String.Join(',', test.Item1)}], l2 = [{String.Join(',', test.Item2)}]");
                Console.WriteLine($"Output: [{String.Join(',', outputList)}]");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(outputList.ToArray())}");
                Console.WriteLine();
            }
        }
    }
}