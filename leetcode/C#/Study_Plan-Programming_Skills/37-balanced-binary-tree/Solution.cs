/*
File Name: 
    37-balanced-binary-tree/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 29, 2022, 14:21:19

Description:
    Given a binary tree, determine if it is height-balanced.

    For this problem, a height-balanced binary tree is defined as:
    a binary tree in which the left and right subtrees of every node differ in
    height by no more than 1.

Constraints:
    The number of nodes in the tree is in the range [0, 5000].
    -10^4 <= Node.val <= 10^4
*/
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root != null) {
            if(!IsBalanced(root.left) || !IsBalanced(root.right))
                return false;

            var leftDepth  = TreeDepth(root.left);
            var rightDepth = TreeDepth(root.right);
            if(Math.Abs(leftDepth - rightDepth) > 1)
                return false;
        }

        return true;
    }

    public int TreeDepth(TreeNode root) {
        if(root == null)
            return 0;

        var leftDepth = TreeDepth(root.left);
        var rightDepth = TreeDepth(root.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}

public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}