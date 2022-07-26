/*
File Name: 
    30-implement-queue-using-stacks/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 16:57:23

Description:
    Implement a first in first out (FIFO) queue using only two stacks. The
    implemented queue should support all the functions of a normal queue
    (push, peek, pop, and empty).

    Implement the MyQueue class:
        void push(int x) Pushes element x to the back of the queue.
        int pop() Removes the element from the front of the queue and returns it.
        int peek() Returns the element at the front of the queue.
        boolean empty() Returns true if the queue is empty, false otherwise.
*/
public class MyQueue {
    Stack<int> left;
    Stack<int> right;
    public MyQueue() {
        left = new Stack<int>();
        right = new Stack<int>();
        
    }
    
    public void Push(int x) {
        while(left.Count != 0)
            right.Push(left.Pop());
        right.Push(x);
        while(right.Count != 0)
            left.Push(right.Pop());
    }
    
    public int Pop() {
        return left.Pop();
    }
    
    public int Peek() {
        return left.Peek();
    }
    
    public bool Empty() {
        return left.Count == 0;
    }
}