/*
File Name: 
    27-maximum-depth-of-binary-tree/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 15:56:32

Description:
    Given the root of a binary tree, return its maximum depth.

    A binary tree's maximum depth is the number of nodes along the longest 
    pathfrom the root node down to the farthest leaf node.
*/
namespace MaximumDepthOfBinaryTree {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, int)[] {
                 
                 ("3,9,20,null,null,15,7", 3)
                ,("1,null,2", 2)
            };

            var solve = new Solution();
            foreach((string, int) t in testcases) {
                Console.WriteLine($"Input: root = [{t.Item1}]");
                var sList = t.Item1.Split(',');
                TreeNode? root = insertNode(sList.ToArray(), 0);
                
                var x = solve.MaxDepth(root);
                Console.WriteLine($"Pass: {t.Item2.Equals(x)}\n");
            }
        }
        public static TreeNode? insertNode(string[] arr, int i) {
            TreeNode? root = null;
            if(i < arr.Length && arr[i] != "null") {
                root = new TreeNode(int.Parse(arr[i]), insertNode(arr, (2 * i)+1), insertNode(arr, (2 * i)+2));
            }

            return root;
        }
    }


}