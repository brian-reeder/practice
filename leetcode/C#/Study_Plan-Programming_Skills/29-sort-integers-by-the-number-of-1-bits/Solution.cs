/*
File Name: 
    29-sort-integers-by-the-number-of-1-bits/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 16:49:31

Description:
    You are given an integer array arr. Sort the integers in the array in
    ascending order by the number of 1's in their binary representation and in
    case of two or more integers have the same number of 1's you have to sort
    them in ascending order.

    Return the array after sorting it.
*/
public class Solution {
    public int[] SortByBits(int[] arr) {
        var bitCounter = new Dictionary<int, int>();
        var sortedList = new List<int>(arr.Length);
        foreach(int i in arr) {
            // Count the bits
            int count = 0;
            for(var x = i; x > 0; x>>=1)
                if(x%2 == 1)
                    count++;
            
            // Record the bits to the table
            bitCounter[i] = count;
            // Insert the value into the sorted array.
            int j = 0;
            for(; j < sortedList.Count; j++) {
                var x = bitCounter[sortedList[j]];
                if((count < x) || (count == x && i < sortedList[j])) {
                    sortedList.Insert(j, i);
                    break;
                }
            }
            if(j == sortedList.Count)
                sortedList.Add(i);
        }
        
        return sortedList.ToArray();
    }
}