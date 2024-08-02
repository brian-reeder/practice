package solution

func twoSum(nums []int, target int) []int {
	m := map[int][]int{}
	for i := 0; i < len(nums); i++ {
		// Enqueue elements based on value
		k := nums[i]
		m[k] = append(m[k], i)
	}

	for i := 0; i < len(nums); i++ {
		n := nums[i]
		if len(m[n]) > 1 {
			m[n] = m[n][1:]
		} else {
			delete(m, n)
		}
		// Pop element from queue
		t := target - n

		if len(m[t]) != 0 {
			return []int{i, m[t][0]}
		}
	}

	return []int{-1, -1}
}
