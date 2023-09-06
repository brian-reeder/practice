/*
File Name: 
    54-next-greater-element-iii/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 7, 2022, 16:28

Description:
    Given a positive integer n, find the smallest integer which has exactly the
    same digits existing in the integer n and is greater in value than n. If no
    such positive integer exists, return -1.

    Note that the returned integer should fit in 32-bit integer, if there is a
    valid answer but it does not fit in 32-bit integer, return -1.

Constraints:
    1 <= n <= 2^31 - 1
*/
public class Solution {
    public int NextGreaterElement(int n) {
        var cNums = $"{n}".ToCharArray();
        
        int lesserI = -1;
        int i;
        // Find i where i is less than its neighbor.
        for(i = cNums.Length-2; i >= 0; i--)
            if(cNums[i] < cNums[i+1]) {
                lesserI = i;
                break;
            }
        
        if(lesserI == -1) return -1;
        
        // Find lowest order i that is greater than the lesserI.
        for(i = cNums.Length-1; i > lesserI; i--) {
            if(cNums[i] > cNums[lesserI]) {
                Swap(cNums, i, lesserI);
                break;
            }
        }
        
        if(i == lesserI) return -1;
        
        // Reverse all values after the lesserI index.
        var subLen = cNums.Length-lesserI;
        for(i = 0; i < subLen/2; i++) {
            Swap(cNums, lesserI+1+i, cNums.Length-i-1);
        }
        
        // Convert the answer to int.
        int elem;
        try {
            elem = int.Parse(cNums);
        }
        catch(OverflowException e) {
            elem = -1;
        }
        
        return elem;
    }
    
    public static void Swap(char[] cNums, int i, int j) {
        var t = cNums[i];
        cNums[i] = cNums[j];
        cNums[j] = t;
    }
}