/* // //
// FileName: 02-Add_Two_Numbers-C#/Solution.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 10 JULY 2022 18:45:40 UTC
// Description: This file is the Solution class for the leetcode problem.
//      It uses a stack 
*/ // //
public class Solution {
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2) {
        int remainder = 0;
        int sum = 0;
        ListNode? walk, head;

        // Sum all available values.
        // Iterate lists to next entry
        if(l1 != null) {
            sum += l1.val;
            l1   = l1.next;
        }
        if(l2 != null){                
            sum += l2.val;
            l2   = l2.next;
        }
        // Calculate remainder
        remainder = sum/10;

        // Remove remainder from sum
        // Initiliaze return ListNode
        head = new ListNode(sum % 10);
        walk = head;

        // If there are still items in l1 or l2 or if there's a remainder.
        while(l1 != null || l2 != null || remainder != 0) {
            
            // Sum all available values.
            // Iterate lists to next entry
            sum = remainder;
            if(l1 != null) {
                sum += l1.val;
                l1   = l1.next;
            }
            if(l2 != null){                
                sum += l2.val;
                l2   = l2.next;
            }
            // Calculate remainder
            remainder = sum/10;

            // Strip any remainder and add it to the Stack
            walk.next = new ListNode(sum % 10);
            walk = walk.next;
        }
        
        return head;
    }
}