/*
File Name: 
    45-daily-temperatures/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 2, 2022, 16:13:40

Description:
    Given an array of integers temperatures represents the daily temperatures,
    return an array answer such that answer[i] is the number of days you have
    to wait after the ith day to get a warmer temperature. If there is no
    future day for which this is possible, keep answer[i] == 0 instead.

Constraints:
    1 <= temperatures.length <= 105
    30 <= temperatures[i] <= 100
*/
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var nums = new int[temperatures.Length];
        
        var numsStack = new Stack<int>(temperatures.Length);
        
        for(int i = 0; i < temperatures.Length; i++) {
            while(numsStack.Count !=0 && temperatures[i] > temperatures[numsStack.Peek()]) {
                nums[numsStack.Peek()] = i-numsStack.Peek();
                numsStack.Pop();
            }
            numsStack.Push(i);
        }
        
        return nums;
    }
}