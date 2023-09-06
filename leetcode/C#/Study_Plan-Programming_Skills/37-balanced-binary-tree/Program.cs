/*
File Name: 
    37-balanced-binary-tree/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 29, 2022, 14:20:57

Description:
    Given a binary tree, determine if it is height-balanced.

    For this problem, a height-balanced binary tree is defined as:
    a binary tree in which the left and right subtrees of every node differ in
    height by no more than 1.

Constraints:
    The number of nodes in the tree is in the range [0, 5000].
    -10^4 <= Node.val <= 10^4
*/
namespace BalancedBinaryTree {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (string, bool)[] {
                ("[1,2,2,3,3,null,null,4,4]", false)
                ,("[]", true)
                ,("[3,9,20,null,null,15,7]", true)
            };

            var solve = new Solution();
            foreach(var t in testcases) {
                TreeNode? root = null;
                if(t.Item1.Length > 2) {
                    var arr = t.Item1[1..(t.Item1.Length-1)].Split(',');
                    root = InsertLevelOrder(arr, 0, arr.Count());
                }

                var x = solve.IsBalanced(root);

                Console.WriteLine($"Input: root = {t.Item1}");
                Console.WriteLine($"Output: {x}");
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}");
                Console.WriteLine();
            }
        }

        static TreeNode? InsertLevelOrder(string[] arr, int i, int n) {
            TreeNode? root = null;

            if(i < n) {
                var val = arr[i];
                if(val != "null") {
                    root = new TreeNode(int.Parse(val));
                    root.left  = InsertLevelOrder(arr, 2*i+1, n);
                    root.right = InsertLevelOrder(arr, 2*i+2, n);
                }

            }
            return root;
        }
    }
}