/*
File Name: 
    55-time-needed-to-inform-all-employees/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:15

Description:
    A company has n employees with a unique ID for each employee from 0 to
    n - 1. The head of the company is the one with headID.

    Each employee has one direct manager given in the manager array where
    manager[i] is the direct manager of the i-th employee, 
    manager[headID] = -1. Also, it is guaranteed that the subordination
    relationships have a tree structure.

    The head of the company wants to inform all the company employees of an
    urgent piece of news. He will inform his direct subordinates, and they will
    inform their subordinates, and so on until all employees know about the
    urgent news.

    The i-th employee needs informTime[i] minutes to inform all of his direct
    subordinates (i.e., After informTime[i] minutes, all his direct
    subordinates can start spreading the news).

    Return the number of minutes needed to inform all the employees about the
    urgent news.

Constraints:
    1 <= n <= 10^5
    0 <= headID < n
    manager.length == n
    0 <= manager[i] < n
    manager[headID] == -1
    informTime.length == n
    0 <= informTime[i] <= 1000
    informTime[i] == 0 if employee i has no subordinates.
    It is guaranteed that all the employees can be informed.
*/
public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        // Create all employee nodes.
        var nodes = new EmployeeNode[manager.Length];
        for(int i = 0; i < manager.Length; i++)
            nodes[i] = new EmployeeNode(i, informTime[i]);
        
        // Link managers to their employees.
        for(int i = 0; i < manager.Length; i++)
            if(manager[i] != -1)
                nodes[manager[i]].directReports.Add(nodes[i]);
        
        return GreatestNumOfMinutes(nodes[headID]);
        
    }
    
    public int GreatestNumOfMinutes(EmployeeNode head) {
        if(head == null)
            return 0;
        
        // Recursively find the employee branch with the longest informTime.
        var max = 0;
        foreach(var employee in head.directReports) {
            var t = GreatestNumOfMinutes(employee);
            if(t > max)
                max = t;
        }
        
        // Increase the informTime by the managers.
        return max + head.informTime;
    }
}