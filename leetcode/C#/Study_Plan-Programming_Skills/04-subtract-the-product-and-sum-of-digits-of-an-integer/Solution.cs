/*
File Name: 
    04-subtract-the-product-and-sum-of-digits-of-an-integer/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Sunday, July 17, 2022, 15:15:58

Description:
    Write a function that takes an unsigned integer and returns the number of 
        '1' bits it has (also known as the Hamming weight). This solution
        adds the bitwise & result of the input value and the 2^0 place. Then
        the input value is shifted down 1 place.
*/
public class Solution {
    public int SubtractProductAndSum(int n) {
        // Start sum at 0 for base value
        var sum = 0;
        // Start product at 1 so you do not multiply by 0
        var product = 1;
        // Shift n down by the 10's place
        // Continue until there are no more digits in n
        for(; n > 0; n = n /10) {
            // Adust sum/product by the 1's place
            sum += n % 10;
            product *= n % 10;
        }

        return product - sum;
    }
}