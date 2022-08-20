/*
File Name: 
    07-sqrtx/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 17:09

Description:
    Given a non-negative integer x, compute and return the square root of x.

    Since the return type is an integer, the decimal digits are truncated, and
    only the integer part of the result is returned.

    Note: You are not allowed to use any built-in exponent function or
    operator, such as pow(x, 0.5) or x ** 0.5.



Constraints:
    * 0 <= x <= 2^31 - 1
*/
public class Solution {
    public int MySqrt(int x) {
        int ans, min, mid, max;
        long mid2;
        min = 0;
        max = x;
        ans = -1;
        for(mid = x/2; min <= max; mid = min+(max-min)/2) {
            mid2 = (long)mid*mid;
            if(mid2 == x)
                return mid;
            else if(mid2 > x)
                max = mid -1;
            else {
                min = mid + 1;
                ans = mid;
            }
        }

        return ans;
    }
}