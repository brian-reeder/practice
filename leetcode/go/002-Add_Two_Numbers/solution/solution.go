package solution

import . "github.com/brian-reeder/practice/leetcode/go/002-Add_Two_Numbers/ListNode"

func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	nums := []int{}
	sum := 0
	for l1 != nil || l2 != nil || sum != 0 {
		if l1 != nil {
			sum += l1.Val
			l1 = l1.Next
		}
		if l2 != nil {
			sum += l2.Val
			l2 = l2.Next
		}
		nums = append(nums, sum%10)
		sum = sum / 10
	}

	var head *ListNode
	head = nil
	for i := len(nums) - 1; i >= 0; i = i - 1 {
		head = &ListNode{Val: nums[i], Next: head}
	}
	return head
}
