/*
File Name: 
    26-middle-of-the-linked-list/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 15:37:58

Description:
    Given the head of a singly linked list, return the middle node of the
    linked list.

    If there are two middle nodes, return the second middle node.
*/
namespace MiddleOfTheLinkedList {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (int[], string)[] {
                 
                 (new int[]{1,2,3,4,5}, "[3,4,5]")
                ,(new int[]{1,2,3,4,5,6}, "[4,5,6]")
            };

            var solve = new FasterSlower.Solution();
            foreach((int[], string) t in testcases) {
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
                var x = solve.MiddleNode(head);
                var outputString = "[";
                for(;x != null; x = x.next) {
                    if(x.next == null) {
                        outputString += $"{x.val}";
                    }
                    else {
                        outputString += $"{x.val},";
                    }
                }
                outputString += "]";
                Console.WriteLine($"Pass: {t.Item2.SequenceEqual(outputString)}\n");
            }
        }
    }
}