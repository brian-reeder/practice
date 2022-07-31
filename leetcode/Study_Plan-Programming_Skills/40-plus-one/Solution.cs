/*
File Name: 
    40-plus-one/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 30, 2022, 23:41:49

Description:
    You are given a large integer represented as an integer array digits, where
    each digits[i] is the ith digit of the integer. The digits are ordered from
    most significant to least significant in left-to-right order. The large
    integer does not contain any leading 0's.

    Increment the large integer by one and return the resulting array of
    digits.

Constraints:
    1 <= digits.length <= 100
    0 <= digits[i] <= 9
    digits does not contain any leading 0's.
*/
public class Solution {
    public int[] PlusOne(int[] digits) {
        int[] newDigits = new int[digits.Length+1];
        newDigits[0] = 1;

        var n = digits[digits.Length - 1] + 1;
        var carry = n / 10;

        newDigits[digits.Length] = n % 10;

        for(int i = digits.Length -2; i >= 0; i--) {
            n = digits[i] + carry;
            carry = n / 10;
            newDigits[i+1] = n % 10;
        }

        return carry == 0 ? newDigits[1..(digits.Length+1)] : newDigits;   
    }
}