/*
File Name: 
    44-add-to-array-form-of-integer/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 1, 2022, 17:22:11

Description:
    The array-form of an integer num is an array representing its digits in left to right order.

    For example, for num = 1321, the array form is [1,3,2,1].
    Given num, the array-form of an integer, and an integer k, return the array-form of the integer num + k.

Constraints:
    1 <= num.length <= 104
    0 <= num[i] <= 9
    num does not contain any leading zeros except for the zero itself.
    1 <= k <= 104
*/
public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        IList<int> nBuff = new List<int>(num.Length);
        int i = num.Length-1;
        int carry = 0;
        while(i >= 0|| k != 0) {
            var sum = carry;
            if(k != 0) {
                sum += k % 10;
                k /= 10;
            }

            if(i >= 0) {
                sum += num[i];
                i -= 1;
            }

            nBuff.Insert(0, sum%10);
            carry = sum/10;
        }
        if(carry != 0)
            nBuff.Insert(0, carry);

        return nBuff;
    }
}