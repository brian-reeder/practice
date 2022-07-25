/*
File Name: 
    25-convert-binary-number-in-a-linked-list-to-integer/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 15:20:51

Description:
    Given head which is a reference node to a singly-linked list. The value of
    each node in the linked list is either 0 or 1. The linked list holds the
    binary representation of a number.

    Return the decimal value of the number in the linked list.

    The most significant bit is at the head of the linked list.
*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        var num = 0;
        for(; head != null; head = head.next) {
            num = num << 1;
            num += head.val;
        }
        
        return num;
    }
}
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }