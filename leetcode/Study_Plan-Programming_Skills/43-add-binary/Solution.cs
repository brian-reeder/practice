/*
File Name: 
    43-add-binary/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 1, 2022, 11:41:09

Description:
    Given two binary strings a and b, return their sum as a binary string.

Constraints:
    1 <= a.length, b.length <= 104
    a and b consist only of '0' or '1' characters.
    Each string does not contain leading zeros except for the zero itself.
*/
public class Solution {
    public string AddBinary(string a, string b) {
        int rounds = Math.Max(a.Length, b.Length);
        var cBuff = new char[rounds+1];
        var start = rounds;
        for(int i = 1; i <= rounds; i++) {
            var cIndex = cBuff.Length-i;
            if(i <= a.Length)
                cBuff[cIndex] += (char)(a[a.Length-i] - '0');
            if(i <= b.Length)
                cBuff[cIndex] += (char)(b[b.Length-i] - '0');

            cBuff[cIndex-1] += (char)(cBuff[cIndex] / 2);
            cBuff[cIndex] = (char)('0' + cBuff[cIndex] % 2);
            if(cBuff[cIndex-1] != 0)
                start = cIndex-1;
            else if (cIndex < start && cBuff[cIndex] != 0)
                start = cIndex;
        }
        cBuff[0] += '0';        
        return new string(cBuff[start..]);
    }
}