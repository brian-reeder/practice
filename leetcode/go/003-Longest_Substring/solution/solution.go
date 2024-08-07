package solution

func lengthOfLongestSubstring(s string) int {
	chars := make(map[rune]int, len(s))
	max, length := 0, 0

	for i := range len(s) {
		for _, c := range s[i:] {
			_, collision := chars[c]
			if !collision {
				chars[c] = 1
				length++
				if length > max {
					max = length
				}
			} else {
				clear(chars)
				length = 0
				break
			}
		}
		if max >= len(s)-i {
			break
		}
	}

	return max
}
