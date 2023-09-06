/*
File Name: 
    72-design-linked-list/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 16, 2022, 17:41

Description:
    Design your implementation of the linked list. You can choose to use a
    singly or doubly linked list.
    A node in a singly linked list should have two attributes: val and next.
    val is the value of the current node, and next is a pointer/reference to
    the next node.
    If you want to use the doubly linked list, you will need one more
    attribute prev to indicate the previous node in the linked list. Assume all
    nodes in the linked list are 0-indexed.

    Implement the MyLinkedList class:
    * MyLinkedList() Initializes the MyLinkedList object.
    * int get(int index) Get the value of the indexth node in the linked list.
        If the index is invalid, return -1.
    * void addAtHead(int val) Add a node of value val before the first element
        of the linked list. After the insertion, the new node will be the first
        node of the linked list.
    * void addAtTail(int val) Append a node of value val as the last element
        of the linked list.
    * void addAtIndex(int index, int val) Add a node of value val before the
        indexth node in the linked list. If index equals the length of the
        linked list, the node will be appended to the end of the linked list.
        If index is greater than the length, the node will not be inserted.
    * void deleteAtIndex(int index) Delete the indexth node in the linked list,
        if the index is valid.

Constraints:
    * 0 <= index, val <= 1000
    * Please do not use the built-in LinkedList library.
    * At most 2000 calls will be made to get, addAtHead, addAtTail, addAtIndex
        and deleteAtIndex.

*/
public class MyLinkedList {
    LinkedListNode head;
    LinkedListNode tail;
    int count;

    public MyLinkedList() {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }
    
    public int Get(int index) {
        if(index < 0 || index >= this.count)
            return -1;
        
        int val = -1;
        for(var w = this.head; w != null; w=w.next) {
            if(index == 0) {
                val = w.val;
                break;
            }
            index -= 1;
        }
        
        return val;
    }
    
    public void AddAtHead(int val) {
        this.head = new LinkedListNode(val, this.head);
        this.count += 1;
    }
    
    public void AddAtTail(int val) {
        if(count == 0)
            this.AddAtHead(val);
        else {
            var w = this.head;
            while(w.next != null)
                w = w.next;
            w.next = new LinkedListNode(val);
            count += 1;
        }
    }
    
    public void AddAtIndex(int index, int val) {
        if(index < 0 || index > count)
            return;
        
        if(index == 0)
            this.AddAtHead(val);
        else if(index == count)
            this.AddAtTail(val);
        else {
            var w = this.head;
            for(; index > 1; index -= 1)
                w = w.next;

            w.next = new LinkedListNode(val, w.next);
            this.count += 1;
        }        
    }
    
    public void DeleteAtIndex(int index) {
        if(count == 0 || index < 0 || index >= count)
            return;
        
        if(index == 0)
            this.head = this.head.next;
        else {
            for(var t = this.head; t != null; t=t.next)
                Console.Write($"{t.val} ");
            Console.WriteLine();
            Console.WriteLine($"index = {index}, count = {this.count}");
            
            var w = this.head;
            for(; index > 1; index -= 1)
                w = w.next;
            
            w.next = w.next.next;
        }
        this.count -= 1;
    }
}

public class LinkedListNode {
    public LinkedListNode next;
    public int val;
    
    public LinkedListNode(int val=0, LinkedListNode next=null) {
        this.next = next;
        this.val = val;
    }
}