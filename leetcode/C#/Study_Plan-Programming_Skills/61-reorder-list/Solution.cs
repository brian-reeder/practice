/*
File Name: 
    61-reorder-list/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 10, 2022, 17:24

Description:
    
Constraints:
    
*/
public class Solution {
    public void ReorderList(ListNode head) {
        if(head == null || head.next == null)
            return;
        
        var nodeStack = new Stack<ListNode>();
        
        ListNode w, wFast, wTail;
        w = head;
        wFast = head;
        for(; wFast != null && wFast.next != null; wFast = wFast.next.next)
            w = w.next;
        
        for(; w != null; w = w.next)
            nodeStack.Push(w);
        
        w = head;
        while(nodeStack.Count != 0) {
            wTail = w.next;
            w.next = nodeStack.Pop();
            w.next.next = wTail;
            w = wTail;
        }
        w.next.next = null;
        return;
    }
}