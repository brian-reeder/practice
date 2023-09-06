/*
File Name: 
    41-linked-list-in-binary-tree/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 31, 2022, 20:09:14

Description:
    Given a binary tree root and a linked list with head as the first node. 

    Return True if all the elements in the linked list starting from the head
    correspond to some downward path connected in the binary tree otherwise
    return False.

    In this context downward path means a path that starts at some node and
    goes downwards.

Constraints:
    The number of nodes in the tree will be in the range [1, 2500].
    The number of nodes in the list will be in the range [1, 100].
    1 <= Node.val <= 100 for each node in the linked list and binary tree.
*/
namespace LinkedListInBinaryTree {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, string, bool)[] {
                // ,("", "", true)
                 ("4,2,8", "1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3", true)
                ,("1,4,2,6", "1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3", true)
                ,("1,4,2,6,8", "1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3", false)
            };

            var solve = new Solution();
            foreach(var test in testcases) {
                ListNode head = new ListNode();
                ListNode walk = head;
                foreach(var tok in test.Item1.Split(',')) {
                    walk.next = new ListNode(int.Parse(tok));
                    walk = walk.next;
                }
                head = head.next;

                var nodes = new Queue<TreeNode>();
                var tokens = test.Item2.Split(',');
                TreeNode? root = tokens[0] == "null" ? null : new TreeNode(int.Parse(tokens[0]));
                nodes.Enqueue(root);
                TreeNode node;
                for(int i = 1; i < tokens.Length-1; i = i+2) {
                    node = nodes.Dequeue();
                    if(tokens[i] != "null") {
                        node.left = new TreeNode(int.Parse(tokens[i]));
                        nodes.Enqueue(node.left);
                    }

                    if(tokens[i+1] != "null") {
                        node.right = new TreeNode(int.Parse(tokens[i+1]));
                        nodes.Enqueue(node.right);
                    }
                }
                var output = solve.IsSubPath(head, root);
                Console.WriteLine($"Input: head = [{test.Item1}], root = [{test.Item2}]");
                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Pass: {test.Item3.Equals(output)}");
                Console.WriteLine();
            }
        }
    }

    
}