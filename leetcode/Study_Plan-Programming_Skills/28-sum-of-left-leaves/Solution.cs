/*
File Name: 
    28-sum-of-left-leaves/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 16:25:26

Description:
    Given the root of a binary tree, return the sum of all left leaves.

    A leaf is a node with no children. A left leaf is a leaf that is the left
    child of another node.
*/
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        
        if(root == null)
            return 0;
        
        var sum = 0;
        if(isLeaf(root.left))
            sum += root.left.val;
        
        sum += SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
        
        return sum;
    }
    
    public bool isLeaf(TreeNode root) {
        if(root == null)
            return false;
        
        return root.left == null && root.right == null;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}