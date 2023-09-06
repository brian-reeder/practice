/*
File Name: 
    64-add-two-numbers-ii/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 12, 2022, 16:17

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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var s1 = new Stack<int>();
        var s2 = new Stack<int>();
        while(l1 != null || l2 != null) {
            if(l1 != null) {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            if(l2 != null) {
                s2.Push(l2.val);
                l2 = l2.next;
            }
        }
        ListNode head = null;
        int sum, carry;
        for(carry = 0; carry != 0 || s1.Count != 0 || s2.Count != 0; carry = sum / 10) {
            sum = carry;

            if(s1.Count != 0)
                sum += s1.Pop();

            if(s2.Count != 0)
                sum += s2.Pop();

            head = new ListNode(sum%10, head);
        }

        return head;
    }
}