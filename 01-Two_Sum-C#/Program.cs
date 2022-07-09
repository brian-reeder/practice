/* // //
// FileName: 01-Two_Sum-C#/Program.cs
// FileType: Visual C# Source file
// Author: https://github.com/brian-reeder
// Created On: 09 JULY 2022 15:54:24 UTC
// Description:
*/ // //

namespace TwoSum {
    class Program {

        public struct testcase {
            public int[] nums;
            public int target;

            public testcase(int[] n, int t) {
                nums = n;
                target = t;
            }
        }
        static void Main(string[] args) {
            int i;
            String input;
            Queue<testcase> testcases = new Queue<testcase>();

            // Queue up test cases
            testcases.Enqueue(new testcase(new int[] {2,7,11,15}, 9));
            testcases.Enqueue(new testcase(new int[] {3,2,4}, 6));
            testcases.Enqueue(new testcase(new int[] {3,3}, 6));

            Solution Solve = new Solution();

            // Run the TwoSum method against all testcases.
            // Print input and output.
            while(testcases.Count > 0) {
                testcase t = testcases.Dequeue();

                // Prepare INPUT string
                input = "[";
                for(i = 0; i < t.nums.Length-1; i++)
                    input += $"{t.nums[i]},";
                input += $"{t.nums[i]}]";

                Console.WriteLine($"INPUT = {input} {t.target}");

                // Run solution program
                int[] result = Solve.TwoSum(t.nums, t.target);
                Console.WriteLine($"OUTPUT= [{result[0]},{result[1]}]");
            }
        }
    }
}