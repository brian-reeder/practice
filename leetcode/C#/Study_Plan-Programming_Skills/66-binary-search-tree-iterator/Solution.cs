/*
File Name: 
    66-binary-search-tree-iterator/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 12, 2022, 17:37

Description:
    Implement the BSTIterator class that represents an iterator over the
    in-order traversal of a binary search tree (BST):

    BSTIterator(TreeNode root) Initializes an object of the BSTIterator class.
    The root of the BST is given as part of the constructor. The pointer should
    be initialized to a non-existent number smaller than any element in the BST.
    
    boolean hasNext() Returns true if there exists a number in the traversal to
    the right of the pointer, otherwise returns false.
    
    int next() Moves the pointer to the right, then returns the number at the
    pointer.

    Notice that by initializing the pointer to a non-existent smallest number,
    the first call to next() will return the smallest element in the BST.

    You may assume that next() calls will always be valid. That is, there will
    be at least a next number in the in-order traversal when next() is called.

Constraints:
    The number of nodes in the tree is in the range [1, 105].
    0 <= Node.val <= 106
    At most 10^5 calls will be made to hasNext, and next.
*/
public class BSTIterator {
    List<int> _elems;
    int _ptr;
    public BSTIterator(TreeNode root) {
        _elems = new List<int>();
        _ptr = 0;
        
        var nodes = new Stack<TreeNode>();
        while(root != null || nodes.Count != 0) {
            if(root != null) {
                nodes.Push(root);
                root = root.left;
            }
            else {
                root = nodes.Pop();
                _elems.Add(root.val);
                root = root.right;
            }
        }
    }
    
    public int Next() {
        return _elems[_ptr++];
    }
    
    public bool HasNext() {
        return _ptr < _elems.Count;
    }
}