/*
File Name: 
    20-sum-of-square-numbers/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 26, 2022, 17:58

Description:
    Given a non-negative integer c, decide whether there're two integers a and
    b such that a2 + b2 = c

Constraints:
    * 0 <= c <= 231 - 1
*/
public class Solution {
    public bool JudgeSquareSum(int c) {
        for(long a = 0; a <= Math.Sqrt(c); a++) {
            long b = c - (a*a);
            if(BinarySearch(a, b, b))
                return true;
        }
        return false;
    }
    
    public bool BinarySearch(long min, long max, long target) {
        if(min > max)
            return false;
        long mid = min + (max-min)/2;
        if(mid*mid == target)
            return true;
        else if(mid*mid > target)
            return BinarySearch(min, mid-1, target);
        else
            return BinarySearch(mid+1, max, target);
    }
}