/*
File Name: 
    52-n-ary-tree-level-order-traversal/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 5, 2022, 17:10

Description:
    Given an n-ary tree, return the level order traversal of its nodes' values.

    Nary-Tree input serialization is represented in their level order traversal,
    each group of children is separated by the null value

Constraints:
    The height of the n-ary tree is less than or equal to 1000
    The total number of nodes is between [0, 104]
*/
public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> OrderList = new List<IList<int>>();
        if(root == null)
            return OrderList;
        IList<int> buff = new List<int>();
        buff.Add(root.val);
        OrderList.Add(buff);
        
        foreach(var child in root.children) {
            var childBuff = LevelOrder(child);
            for(int i = 0; i < childBuff.Count; i++) {
                if(OrderList.Count < i+2)
                    OrderList.Add(new List<int>());
                
                // Merge the order level lists
                for(int j = 0; j < childBuff[i].Count; j++)
                    OrderList[i+1].Add(childBuff[i][j]);
            }
        }
        
        return OrderList;
    }
}