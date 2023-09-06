/*
File Name: 
    02-average-salary-excluding-the-minimum-and-maximum-salary/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Saturday, July 16, 2022, 18:39:03

Description:
    You are given an array of unique integers salary where salary[i]
        is the salary of the ith employee. Return the average salary
        of employees excluding the minimum and maximum salary.

Example 1:
    Input: salary = [4000, 3000, 1000, 2000]
    Output: 2500.000000
    Explanation: Minimuim salary and maximum salary are 1000 and 4000
    respectively. Average salary excluding min and max is 
    (2000+3000)/2 = 2500.
Example 2:
    Input: salary = [1000, 2000, 3000]
    Output: 2000.000
    Explanation: Minimuim salary and maximum salary are 1000 and 3000
    respectively. Average salary excluding min and max is 
    (2000)/1 = 2000.
Constraints:
    3 <= salary.Length <= 100
    1000 <= salary[i] <= 10^6
    All the integers of salary are unique
*/
namespace AverageSalaryExcludingTheMinimumAndMaximumSalary {
    public class Program {
        public static void Main(string[] args) {
            int[][] testcases = {
                 new int[] {4000, 3000, 1000, 2000}
                ,new int[] {1000, 2000, 3000}
            };
            Solution solve = new Solution();
            double x;
            foreach(int[] t in testcases) {
                x = solve.Average(t);
                Console.WriteLine(x);
            }
            return;
        }
    }
}