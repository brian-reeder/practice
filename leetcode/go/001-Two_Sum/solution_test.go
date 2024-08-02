package solution

import (
	"reflect"
	"slices"
	"testing"
)

func TestTwoSum1(t *testing.T) {
	nums := []int{2, 7, 11, 15}
	target := 9

	ans := []int{0, 1}

	out := twoSum(nums, target)
	out_sorted := out
	slices.Sort(out_sorted)
	if !reflect.DeepEqual(ans, out_sorted) {
		t.Fatalf(`twoSum(%v, %v) = %v, want match for %v`, nums, target, out, ans)
	}
}

func TestTwoSum2(t *testing.T) {
	nums := []int{3, 2, 4}
	target := 6

	ans := []int{1, 2}

	out := twoSum(nums, target)
	out_sorted := out
	slices.Sort(out_sorted)
	if !reflect.DeepEqual(ans, out_sorted) {
		t.Fatalf(`twoSum(%v, %v) = %v, want match for %v`, nums, target, out, ans)
	}
}

func TestTwoSum3(t *testing.T) {
	nums := []int{3, 3}
	target := 6

	ans := []int{0, 1}

	out := twoSum(nums, target)
	out_sorted := out
	slices.Sort(out_sorted)
	if !reflect.DeepEqual(ans, out_sorted) {
		t.Fatalf(`twoSum(%v, %v) = %v, want match for %v`, nums, target, out, ans)
	}
}
