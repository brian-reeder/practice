/*
File Name: 
    70-flatten-nested-list-iterator/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 14, 2022, 17:09

Description:
    You are given a nested list of integers nestedList. Each element is either
    an integer or a list whose elements may also be integers or other lists.
    Implement an iterator to flatten it.

    Implement the NestedIterator class:
    * NestedIterator(List<NestedInteger> nestedList) Initializes the iterator
        with the nested list nestedList.
    * int next() Returns the next integer in the nested list.
    * boolean hasNext() Returns true if there are still some integers in the
        nested list and false otherwise.

Constraints:
    * 1 <= nestedList.length <= 500
    * The values of the integers in the nested list is in the range [-10^6, 10^6].
*/
public class NestedIterator {
    Stack<NestedInteger> _stack;
    public NestedIterator(IList<NestedInteger> nestedList) {
        // Convert nestedList to Stack.
        _stack = new Stack<NestedInteger>();
        foreach(var elem in nestedList.Reverse())
            _stack.Push(elem);
    }

    public bool HasNext() {
        while(_stack.Count != 0 && !_stack.Peek().IsInteger()) {
            // Convert top List to Stack.
            var list = _stack.Pop().GetList();
            foreach(var elem in list.Reverse())
                _stack.Push(elem);
        }
        
        // NestedIntegers and empty lists have been consumed.
        if(_stack.Count == 0)
            return false;
        
        return true;
    }

    public int Next() {
        return _stack.Pop().GetInteger();
    }
}