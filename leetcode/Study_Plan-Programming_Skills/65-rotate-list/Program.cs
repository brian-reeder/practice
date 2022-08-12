/*
File Name: 
    65-rotate-list/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 12, 2022, 17:32

Description:
    Given the head of a linked list, rotate the list to the right by k places.

Constraints:
    The number of nodes in the list is in the range [0, 500].
    -100 <= Node.val <= 100
    0 <= k <= 2 * 109
*/
namespace RotateList {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int[], int, int[])[] {
                (new int[] {1,2,3,4,5}, 2, new int[] {4,5,1,2,3}),
                (new int[] {0,1,2}, 4, new int[] {2,0,1}),
                (new int[] {0,1,2}, 3, new int[] {0,1,2}),
                (new int[] {0,1,2}, 2, new int[] {1,2,0}),
                (new int[] {0,1,2}, 1, new int[] {2,0,1}),
                (new int[] {0,1,2}, 0, new int[] {0,1,2}),
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                ListNode? head;
                head = null;
                for(int i = test.Item1.Length-1; i >= 0; i--)
                    head = new ListNode(test.Item1[i], head);
                var output = solve.RotateRight(head, test.Item2);

                var iList = new List<int>();
                for(var w = output; w != null; w = w.next)
                    iList.Add(w.val);
                Console.WriteLine($"Input: head = [{String.Join(',', test.Item1)}], k = {test.Item2}");
                Console.WriteLine($"Output: {String.Join(',', iList)}");
                Console.WriteLine($"Pass: {test.Item3.SequenceEqual(iList.ToArray())}");
                Console.WriteLine();
            }
        }
    }
}