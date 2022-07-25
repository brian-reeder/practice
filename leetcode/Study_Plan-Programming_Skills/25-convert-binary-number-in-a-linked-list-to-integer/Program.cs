/*
File Name: 
    25-convert-binary-number-in-a-linked-list-to-integer/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 15:15:10

Description:
    Given head which is a reference node to a singly-linked list. The value of
    each node in the linked list is either 0 or 1. The linked list holds the
    binary representation of a number.

    Return the decimal value of the number in the linked list.

    The most significant bit is at the head of the linked list.
*/
namespace ConvertBinaryNumberInALinkedListToInteger {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (int[], int)[] {
                 
                 (new int[]{}, 0)
                ,(new int[]{1}, 1)
                ,(new int[]{1,0}, 2)
                ,(new int[]{1,1}, 3)
                ,(new int[]{1,0,0}, 4)
                ,(new int[]{1,0,1}, 5)
                ,(new int[]{1,1,0}, 6)
                ,(new int[]{1,1,1}, 7)
                ,(new int[]{1,1,1,1,1,1,1,1}, 255)
                ,(new int[]{1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1}, -1)
                ,(new int[]{1,0,0,0,0,0,0,0,
                            0,0,0,0,0,0,0,0,
                            0,0,0,0,0,0,0,0,
                            0,0,0,0,0,0,0,0}, Int32.MinValue)
                ,(new int[]{0,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1,
                            1,1,1,1,1,1,1,1}, Int32.MaxValue)
            };

            var solve = new Solution();
            foreach((int[], int) t in testcases) {
                Console.WriteLine($"Input: head = [{String.Join(",", t.Item1)}]");
                ListNode? head = null;
                if(t.Item1.Length > 0) {
                    head = new ListNode(t.Item1[0]);
                    var walk = head;
                    foreach(int i in t.Item1.Skip(1)) {
                        walk.next = new ListNode(i);
                        walk = walk.next;
                    }
                }
                var x = solve.GetDecimalValue(head);
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}\n");
            }
        }
    }
}