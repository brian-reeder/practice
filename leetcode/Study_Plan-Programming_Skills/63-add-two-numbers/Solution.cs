/*
File Name: 
    63-add-two-numbers/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 11, 2022, 20:23

Description:
    You are given two non-empty linked lists representing two non-negative
    integers. The digits are stored in reverse order, and each of their nodes
    contains a single digit. Add the two numbers and return the sum as a
    linked list.

    You may assume the two numbers do not contain any leading zero, except the
    number 0 itself.

Constraints:
    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have leading zeros.
*/
namespace Recursion {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0) {
            if(l1 == null && l2 == null && carry == 0)
                return null;

            var sum = carry;

            if(l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            }

            if(l2 != null) {
                sum += l2.val;
                l2 = l2.next;
            }

            return new ListNode(sum%10, AddTwoNumbers(l1,l2,sum/10));
        }
    }
}

namespace Stack {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            var sumStack = new Stack<int>();
            int count, sum;
            for(count = 0; count != 0 || l1 != null || l2 != null; count = sum / 10) {
                sum = count;
                if(l1 != null) {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 != null) {
                    sum += l2.val;
                    l2 = l2.next;
                }

                sumStack.Push(sum%10);
            }

            ListNode head = null;
            for(; sumStack.Count != 0; head = new ListNode(sumStack.Pop(), head));

            return head;
        }
    }
}

namespace Iterate {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            var headHandle = new ListNode();
            var walk = headHandle;
            int carry, sum;
            for(carry = 0; carry != 0 || l1 != null || l2 !=  null; carry = sum / 10) {
                sum = carry;
                if(l1 != null) {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 != null) {
                    sum += l2.val;
                    l2 = l2.next;
                }

                walk.next = new ListNode(sum%10);
                walk = walk.next;
            }

            return headHandle.next;
        }
    }
}