/*
File Name: 
    03-number-of-1-bits/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Saturday, July 16, 2022, 18:50:00

Description:
    Write a function that takes an unsigned integer and returns the number of 
        '1' bits it has (also known as the Hamming weight). This solution
        adds the bitwise & result of the input value and the 2^0 place. Then
        the input value is shifted down 1 place.
*/
public class Solution {
    public int HammingWeight(uint n) {
        var count = 0;
        // Shift all bits 1 position to the right
        // Continue until there are no more bits
        for(;n > 0; n = n >> 1)
            // Count the 2^0 bit
            count += Convert.ToInt16(n & 1);
        
        return count;
    }
}