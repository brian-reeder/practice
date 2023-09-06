/* // //
// FileName: 02-Add_Two_Numbers-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 10 JULY 2022 18:43:27 UTC
// Description: This file is the Main function that operates the test
//      cases and the Solution program for the problem.
*/ // //
namespace AddTwoNumbers {
    class Program {
        static void Main(string[] args) {
            ListNode h1;
            h1 = new ListNode(3);
            h1 = new ListNode(4, h1);
            h1 = new ListNode(2, h1);

            ListNode h2;
            h2 = new ListNode(4);
            h2 = new ListNode(6, h2);
            h2 = new ListNode(5, h2);

            Solution solve = new Solution();
            ListNode? x;
            for(x = solve.AddTwoNumbers(h1, h2);x != null; x = x.next) {
                Console.Write($"{x.val}");
            }
        }
    }
}