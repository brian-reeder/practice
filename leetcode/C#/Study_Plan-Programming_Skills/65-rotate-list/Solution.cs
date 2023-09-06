/*
File Name: 
    65-rotate-list/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 12, 2022, 17:37

Description:
    Given the head of a linked list, rotate the list to the right by k places.

Constraints:
    The number of nodes in the list is in the range [0, 500].
    -100 <= Node.val <= 100
    0 <= k <= 2 * 109
*/
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {

        var nodeStack = new Stack<ListNode>();
        ListNode walk, tail;
        for(walk = head; walk != null; walk = walk.next)
            nodeStack.Push(walk);

        k = k % nodeStack.Count;
        if(k == 0)
            return head;

        nodeStack.Peek().next = head;

        for(k = k%nodeStack.Count; k > 0; k--)
            head = nodeStack.Pop();

        nodeStack.Peek().next = null;

        return head;
    }
}