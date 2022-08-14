/*
File Name: 
    69-min-stack/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 14, 2022, 17:05

Description:
    Design a stack that supports push, pop, top, and retrieving the minimum
    element in constant time.

    Implement the MinStack class:
    * MinStack() initializes the stack object.
    * void push(int val) pushes the element val onto the stack.
    * void pop() removes the element on the top of the stack.
    * int top() gets the top element of the stack.
    * int getMin() retrieves the minimum element in the stack.
    * You must implement a solution with O(1) time complexity for each function.

Constraints:
    * -2^31 <= val <= 2^31 - 1
    * Methods pop, top and getMin operations will always be called on non-empty stacks.
    * At most 3 * 10^4 calls will be made to push, pop, top, and getMin.
*/
public class MinStack {
    Stack<int> _stack;
    Stack<int> _mins;    

    public MinStack() {
        _stack = new Stack<int>();
        _mins  = new Stack<int>();
    }
    
    public void Push(int val) {
        _stack.Push(val);
        if(_mins.Count == 0 || val <= _mins.Peek())
            _mins.Push(val);
    }
    
    public void Pop() {
        if(_mins.Peek() == _stack.Peek())
            _mins.Pop();
        _stack.Pop();
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _mins.Peek();
    }
}