/*
File Name: 
    28-sum-of-left-leaves/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 25, 2022, 16:23:54

Description:
    Given the root of a binary tree, return the sum of all left leaves.

    A leaf is a node with no children. A left leaf is a leaf that is the left
    child of another node.
*/
namespace SumOfLeftLeaves {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string, int)[] {
                 
                 ("3,9,20,null,null,15,7", 24)
                ,("1", 0)
            };

            var solve = new Solution();
            foreach((string, int) t in testcases) {
                Console.WriteLine($"Input: root = [{t.Item1}]");
                var sList = t.Item1.Split(',');
                TreeNode? root = insertNode(sList.ToArray(), 0);
                
                var x = solve.SumOfLeftLeaves(root);
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