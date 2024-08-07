// Package solution implements the algorithm to solve Problem 3 - Longest Substring
// Without Repeating Characters.
//
// The implemented solution strobes pre-allocates the number of possible runes in
// for the input string, and then strobes left to right finding the longest
// substring for each starting token, and finally returns the length of the longest
// substring.
package solution

import "unicode/utf8"

// lengthOfLongestSubstring returns the number of characters in the longest
// substring containing no repeat characters.
func lengthOfLongestSubstring(s string) int {
	chars := make(map[rune]bool, utf8.RuneCountInString(s))
	max, length := 0, 0

	for i := range len(s) {
		for _, c := range s[i:] {
			_, collision := chars[c]
			// A hash collision has occurred, move to next round
			if collision {
				clear(chars)
				length = 0
				break
			}

			chars[c] = true
			length = length + 1
			if length > max {
				max = length
			}
		}
		// Remaining characters cannot find a new max, early termination
		if max >= len(s)-i {
			break
		}
	}

	return max
}
