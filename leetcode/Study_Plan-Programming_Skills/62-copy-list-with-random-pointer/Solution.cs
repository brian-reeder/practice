/*
File Name: 
    62-copy-list-with-random-pointer/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
     August 10, 2022, 17:51

Description:
    A linked list of length n is given such that each node contains an
    additional random pointer, which could point to any node in the list, or
    null.

    Construct a deep copy of the list. The deep copy should consist of exactly
    n brand new nodes, where each new node has its value set to the value of
    its corresponding original node. Both the next and random pointer of the
    new nodes should point to new nodes in the copied list such that the
    pointers in the original list and copied list represent the same list
    state. None of the pointers in the new list should point to nodes in the
    original list.

    For example, if there are two nodes X and Y in the original list,
    where X.random --> Y, then for the corresponding two nodes x and y in the
    copied list, x.random --> y.

    Return the head of the copied linked list.

    The linked list is represented in the input/output as a list of n nodes.
    Each node is represented as a pair of [val, random_index] where:
        val: an integer representing Node.val
        random_index: the index of the node (range from 0 to n-1) that the
            random pointer points to, or null if it does not point to any node.
    
    Your code will only be given the head of the original linked list
Constraints:
    0 <= n <= 1000
    -10^4 <= Node.val <= 10^4
    Node.random is null or is pointing to some node in the linked list.
*/
namespace Recursion {
    public class Solution {
        Dictionary<Node, Node> nodesTable;
        public Node CopyRandomList(Node head) {
            if(head == null)
                return null;
            
            nodesTable = new Dictionary<Node, Node>();
            RecurseList(head);
            return nodesTable[head];
        }
        public void RecurseList(Node node) {
            if(node == null)
                return;
            
            nodesTable[node] = new Node(node.val);
            RecurseList(node.next);
            
            if(node.next != null)
                nodesTable[node].next = nodesTable[node.next];
            
            if(node.random != null)
                nodesTable[node].random = nodesTable[node.random];
            
            return;
        }
    }
}

namespace NodeTraversial {
    public class Solution {
        public Node CopyRandomList(Node head) {
            if(head == null)
                return null;
            
            var nodesTable = new Dictionary<Node, Node>();

            for(var w = head; w != null; w = w.next)
                nodesTable[w] = new Node(w.val);
            
            for(var w = head; w != null; w = w.next) {
                if(w.next != null)
                    nodesTable[w].next = nodesTable[w.next];
                if(w.random != null)
                    nodesTable[w].random = nodesTable[w.random];
            }
            
            return nodesTable[head];
        }
    }
}