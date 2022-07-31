/*
File Name: 
    41-linked-list-in-binary-tree/ListNode.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 31, 2022, 20:10:12

Description:
    Given a binary tree root and a linked list with head as the first node. 

    Return True if all the elements in the linked list starting from the head
    correspond to some downward path connected in the binary tree otherwise
    return False.

    In this context downward path means a path that starts at some node and
    goes downwards.

Constraints:
    The number of nodes in the tree will be in the range [1, 2500].
    The number of nodes in the list will be in the range [1, 100].
    1 <= Node.val <= 100 for each node in the linked list and binary tree.
*/
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}