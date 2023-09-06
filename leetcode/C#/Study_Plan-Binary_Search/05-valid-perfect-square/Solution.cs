/*
File Name: 
    05-valid-perfect-square/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 19, 2022, 16:49

Description:
    Given a positive integer num, write a function which returns True if num is
    a perfect square else False.

    Follow up: Do not use any built-in library function such as sqrt.

Constraints:
    * 1 <= num <= 2^31 - 1
*/
public class Solution {
    public bool IsPerfectSquare(int num) {
        int min, mid, max;
        min = 1;
        max = num;

        long m2;
        for(mid = max/2; min <= max; mid = min + (max-min)/2) {
            m2 = (long)mid*(long)mid;
            if(m2 == num)
                return true;
            else if(m2 > num)
                max = mid - 1;
            else
                min = mid + 1;
        }

        return false;
    }
}