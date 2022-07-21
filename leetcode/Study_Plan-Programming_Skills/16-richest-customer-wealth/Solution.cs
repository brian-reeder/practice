/*
File Name: 
    16-richest-customer-wealth/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 21, 2022, 19:35:28

Description:
    You are given an m x n integer grid accounts where accounts[i][j] is the
    amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth
    that the richest customer has.

    A customer's wealth is the amount of money they have in all their bank
    accounts. The richest customer is the customer that has the maximum wealth.
*/
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var max = 0;
        foreach(int[] account in accounts) {
            var t = account.Sum();
            if(t > max)
                max = t;
        }
        return max;
    }
}