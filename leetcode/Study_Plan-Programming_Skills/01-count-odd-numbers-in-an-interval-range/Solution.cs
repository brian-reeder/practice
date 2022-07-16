/*
File Name: 
    01-count-odd-numbers-in-an-interval-range/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Saturday, July 16, 2022, 17:51:56 PM

Description:
    Given two non-negative integers low and high. Return the count of
    odd numbers between low and high (inclusive). This file
    calculates the number of odds by subtracting low from high and
    adding 1 if either input val is odd.
*/
public class Solution {
    public int CountOdds(int low, int high) {
        
        // Determine if either input is odd.
        bool highOdd = (high % 2 == 1);
        bool  lowOdd = ( low % 2 == 1);
        
        // About half of the range of numbers is going to be odd.
        // If either of the inputs are odd, then you will always
        //      add 1 to account for the additional odd value.
        return (high - low) / 2 + (highOdd || lowOdd ? 1:0);
    }
}