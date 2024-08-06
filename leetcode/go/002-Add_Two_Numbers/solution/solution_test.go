package solution

import (
	"fmt"
	"strings"
	"testing"

	. "github.com/brian-reeder/practice/leetcode/go/002-Add_Two_Numbers/ListNode"
)

func buildList(nums []int) *ListNode {
	var head *ListNode = nil
	for i := len(nums) - 1; i >= 0; i = i - 1 {
		n := &ListNode{Val: nums[i], Next: head}
		head = n
	}
	return head
}

func equalLists(l1 *ListNode, l2 *ListNode) bool {
	for l1 != nil && l2 != nil && l1.Val == l2.Val {
		l1 = l1.Next
		l2 = l2.Next
	}

	return l1 == l2
}

func prettyPrint(list *ListNode) string {
	nums := []string{}
	for w := list; w != nil; w = w.Next {
		nums = append(nums, fmt.Sprintf(`%v`, w.Val))
	}

	return strings.Join(nums, "->")
}

func TestAddTwoNumbers1(t *testing.T) {
	listL := buildList([]int{2, 4, 3})
	listR := buildList([]int{5, 6, 4})

	ans := buildList([]int{7, 0, 8})
	x := addTwoNumbers(listL, listR)
	if !equalLists(ans, x) {
		t.Fatalf(`Uh-oh [%v]+[%v]=[%v], expected [%v]`, prettyPrint(listL), prettyPrint(listR), prettyPrint(x), prettyPrint(ans))
	}
}

func TestAddTwoNumbers2(t *testing.T) {
	listL := buildList([]int{0})
	listR := buildList([]int{0})

	ans := buildList([]int{0})
	x := addTwoNumbers(listL, listR)
	if !equalLists(ans, x) {
		t.Fatalf(`Uh-oh [%v]+[%v]=[%v], expected [%v]`, prettyPrint(listL), prettyPrint(listR), prettyPrint(x), prettyPrint(ans))
	}
}

func TestAddTwoNumbers3(t *testing.T) {
	listL := buildList([]int{9, 9, 9, 9, 9, 9, 9})
	listR := buildList([]int{9, 9, 9, 9})

	ans := buildList([]int{8, 9, 9, 9, 0, 0, 0, 1})
	x := addTwoNumbers(listL, listR)
	if !equalLists(ans, x) {
		t.Fatalf(`Uh-oh [%v]+[%v]=[%v], expected [%v]`, prettyPrint(listL), prettyPrint(listR), prettyPrint(x), prettyPrint(ans))
	}
}

func TestAddTwoNumbers4(t *testing.T) {
	listL := buildList([]int{9, 9, 9, 9})
	listR := buildList([]int{9, 9, 9, 9, 9, 9, 9})

	ans := buildList([]int{8, 9, 9, 9, 0, 0, 0, 1})
	x := addTwoNumbers(listL, listR)
	if !equalLists(ans, x) {
		t.Fatalf(`Uh-oh [%v]+[%v]=[%v], expected [%v]`, prettyPrint(listL), prettyPrint(listR), prettyPrint(x), prettyPrint(ans))
	}
}
