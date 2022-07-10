public class Solution {
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2) {
        int r = 0;
        int sum = 0;
        Stack<int> l3stack = new Stack<int>();

        // If there are still items in l1 or l2 or if there's a remainder.
        while(l1 != null || l2 != null || r != 0) {
            
            sum = (l1 != null ? l1.val:0) + (l2 != null ? l2.val : 0) + r;

            // Calculate remainder
            r = sum/10;

            // Strip any remainder and add it to the Stack
            l3stack.Push(sum % 10);

            // Iterate through l1 and l2 if they're not null
            l1 = l1?.next;
            l2 = l2?.next;
        }

        // Convert stack to ListNode
        ListNode? l3 = null;
        foreach(int i in l3stack!){
            l3 = new ListNode(i, l3);
        }

        return l3!;
    }
}