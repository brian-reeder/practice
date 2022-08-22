/*
File Name: 
    11-arranging-coins/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 22, 2022, 15:53

Description:
    You have n coins and you want to build a staircase with these coins. The
    staircase consists of k rows where the ith row has exactly i coins. The
    last row of the staircase may be incomplete.

    Given the integer n, return the number of complete rows of the staircase
    you will build.

Constraints:
    * 1 <= n <= 2^31 - 1
*/
public class Solution {
    public int ArrangeCoins(int n) {
        int min, max;
        min = 0;
        max = n;
        
        long current, mid;
        for(mid=n/2; min <= max; mid=min+(max-min)/2) {
            current = mid * (mid+1)/2;
            if(current == n)
                return (int)mid;
            if(n <= current)
                max = (int)mid-1;
            else
                min = (int)mid+1;
        }
        
        return max;
    }
}