/*
File Name: 
    55-time-needed-to-inform-all-employees/EmployeeNode.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 8, 2022, 17:16

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
public class EmployeeNode {
    public int id;
    public int informTime;
    public List<EmployeeNode> directReports;
    
    public EmployeeNode(int id, int informTime) {
        this.id = id;
        this.informTime = informTime;
        this.directReports = new List<EmployeeNode>();
    }
}