/*
File Name: 
    08-find-smallest-letter-greater-than-target/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 17:27

Description:
    Given a characters array letters that is sorted in non-decreasing order and
    a character target, return the smallest character in the array that is
    larger than target.

    Note that the letters wrap around.

    For example, if target == 'z' and letters == ['a', 'b'], the answer is 'a'.

Constraints:
    * 2 <= letters.length <= 10^4
    * letters[i] is a lowercase English letter.
    * letters is sorted in non-decreasing order.
    * letters contains at least two different characters.
    * target is a lowercase English letter.
*/
public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        char ans = letters[0];
        int min, mid, max;
        min = 0;
        max = letters.Length-1;

        for(mid = max/2; min <= max; mid = min+(max-min)/2)
            if(letters[mid] <= target)
                min = mid+1;
            else {
                max = mid-1;
                ans = letters[mid];
            }

        return ans;
    }
}