/*
File Name: 
    27-maximum-depth-of-binary-tree/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 16:00:17

Description:
    Given the root of a binary tree, return its maximum depth.

    A binary tree's maximum depth is the number of nodes along the longest 
    pathfrom the root node down to the farthest leaf node.
*/
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        var left  = MaxDepth(root.left) + 1;
        var right = MaxDepth(root.right) + 1;
        
        return left > right ? left : right;
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