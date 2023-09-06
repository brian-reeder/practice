/*
File Name: 
    11-n-ary-tree-preorder-traversal/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Wednesday, July 20, 2022, 16:32:20 

Description:
    You are given two strings s1 and s2 of equal length. A string swap is an operation where you
    choose two indices in a string (not necessarily different) and swap the characters at these 
    indices.

    Return true if it is possible to make both strings equal by performing at most one string swap
    on exactly one of the strings. Otherwise, return false.
*/
public class Solution {
    public IList<int> Preorder(Node root) {
        var buf = new List<int>();
        if(root != null) {
            buf.Add(root.val);
            foreach(Node n in root.children) {
                buf.AddRange(Preorder(n));
            }
        }
        
        return buf;
    }
}

public class Node {
    public int? val;
    public IList<Node?> children;

    public Node() {}

    public Node(int? _val) {
        val = _val;
    }

    public Node(int _val,IList<Node?> _children) {
        val = _val;
        children = _children;
    }
}