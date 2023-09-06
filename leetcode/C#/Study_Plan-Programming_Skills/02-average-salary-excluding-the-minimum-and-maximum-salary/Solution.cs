/*
File Name: 
    02-average-salary-excluding-the-minimum-and-maximum-salary/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Saturday, July 16, 2022, 18:50:00

Description:
    You are given an array of unique integers salary where salary[i]
        is the salary of the ith employee. Return the average salary
        of employees excluding the minimum and maximum salary. First
        sort the array of salaries, then sum without the first or 
        last elements.
*/
public class Solution {
    public double Average(int[] salary) {
        // Check for divide by 0
        if(salary.Length < 3)
            return 0;

        // Lowerbound = min
        // Upperbound = max
        Array.Sort(salary);

        // Summation, exlcuding min and max
        var sum = 0;
        for(int i = 1; i < salary.Length-1; i++)
            sum+=salary[i];

        // Divide by remaining salaries
        return (double)sum/(salary.Length-2);
    }
}