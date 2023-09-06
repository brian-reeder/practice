/*
File Name: 
    64-add-two-numbers-ii/ListNode.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 12, 2022, 16:14

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
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}