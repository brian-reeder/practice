/*
File Name: 
    42-multiply-strings/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 31, 2022, 21:24:33

Description:
    Given two non-negative integers num1 and num2 represented as strings,
    return the product of num1 and num2, also represented as a string.

    Note: You must not use any built-in BigInteger library or convert the
    inputs to integer directly.

Constraints:
    1 <= num1.length, num2.length <= 200
    num1 and num2 consist of digits only.
    Both num1 and num2 do not contain any leading zero, except the number 0
    itself.
*/
public class Solution {
    public string Multiply(string num1, string num2) {
        var n1L = num1.Length;
        var n2L = num2.Length;
        var product = new char[num1.Length + num2.Length];
        
        int n1, n2, prod;
        for(int i = n2L-1; i >= 0; i--) {
            n2 = (int)(num2[i] - '0');
            for(int j = n1L-1; j >= 0; j--) {
                n1 = (int)(num1[j] - '0');
                prod = n1*n2 + product[i+j+1];
                
                product[i+j+1]  = (char)((int)prod % 10);
                product[i+j]   += (char)((int)prod/10);
            }
        }
        
        for(int i = 0; i < product.Length; i++)
            product[i] += '0';
        int start;
        for(start = 0; start < product.Length-1; start++)
            if(product[start] != '0')
                break;
        
        return new String(product[start..]);
        
    }
}