/*
File Name: 
    26-middle-of-the-linked-list/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 15:41:24

Description:
    Given the head of a singly linked list, return the middle node of the
    linked list.

    If there are two middle nodes, return the second middle node.
*/
namespace FlipFlop {
    public class Solution {
        public ListNode MiddleNode(ListNode head) {
            var i = 0;
            ListNode middle = head;
            for(; head != null; head = head.next) {
                if(i%2 == 1)
                    middle = middle.next;
                
                i++;
            }
            return middle;
        }
    }
}

namespace FasterSlower {
    public class Solution {
        public ListNode MiddleNode(ListNode head) {
            
            ListNode faster = head;
            ListNode slower = head;
            for(; faster != null && faster.next != null; faster = faster.next.next) {
                slower = slower.next;
            }
            return slower;
        }
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