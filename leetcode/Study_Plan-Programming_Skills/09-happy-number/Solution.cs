/*
File Name: 
    09-happy-number/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 17:58:04

Description:
    Write an algorithm to determine if a number n is happy.
    A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the
    squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it
    loops endlessly in a cycle which does not include 1.

    Those numbers for which this process ends in 1 are happy.
    Return true if n is a happy number, and false if not.
*/
public class Solution {
    public bool IsHappy(int n) {
        var rounds = new HashSet<int>();
        rounds.Add(n);
        
        int round;
        while(n != 1) {
            for(round = 0; n != 0; n = n / 10)
                round += (n % 10) * (n % 10);

            // Check for cycle.
            if(!rounds.Add(round))
                return false;
            
            n = round;
        }

        return true;
    }
}