﻿/*
File Name: 
    11-n-ary-tree-preorder-traversal/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Wednesday, July 20, 2022, 16:31:47

Description:
    Given the root of an n-ary tree, return the preorder traversal of its nodes'
    values.

    Nary-Tree input serialization is represented in their level order traversal.
    Each group of children is separated by the null value (See examples)
*/
namespace NAryTreePreorderTraversial {
    public class Program {
        public static void Main(string[] args) {
            var testcases = new (int?[], int[])[] {
                 (new int?[] {1,null,3,2,4,null,5,6}, new int[] {1,3,5,6,2,4})
                ,(new int?[] {1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14}, new int[] {1,2,3,6,7,11,14,4,8,12,5,9,13,10})
            };

            var solve = new Solution();
            foreach((int?[], int[]) t in testcases) {
                Console.WriteLine($"Input: root = {t.Item1}");
                // Convert to Node
                if(t.Item1[0] != null) {
                    var root = new Node(t.Item1[0]);
                    // TODO: Convert the rest of the tree
                    var x = solve.Preorder(root);
                    Console.WriteLine($"Output: {x}");
                    Console.WriteLine($"Pass: {x == t.Item2}");
                    Console.WriteLine();
                }
            }
        }
    }
}