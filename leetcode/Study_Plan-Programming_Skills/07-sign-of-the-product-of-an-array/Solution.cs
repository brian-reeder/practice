/*
File Name: 
    06-find-nearest-point-that-has-the-same-x-or-y-coordinate/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    Tuesday, July 19, 2022, 16:30:51

Description:
    There is a function signFunc(x) that returns:
        1 if x is positive.
        -1 if x is negative.
        0 if x is equal to 0.

    You are given an integer array nums. Let product be the product of all values in the array nums.

    Return signFunc(product).
*/
namespace BitsignProduct {
    public class Solution {
        public int ArraySign(int[] nums) {
            var sign = 1;
            foreach(int n in nums) {
                // Base case, early terminate if 0 is in set.
                if(n == 0)
                    return 0;

                // If the negative bit isn't set, multiply by 1
                // else multiply by -1
                sign = (n & Int32.MinValue) == 0 ? sign * 1 : sign * -1;
            }
            return sign;
        }
    }
}

namespace BitsignAdder {
    public class Solution {
        public int ArraySign(int[] nums) {
            var negative = 0;
            foreach(int n in nums) {
                // Base case, early terminate if 0 is in set.
                if(n == 0)
                    return 0;

                // If the negative bit is set add 1
                if((n & Int32.MinValue) == Int32.MinValue)
                    negative++;
            }

            if((negative % 2) == 0)
                return 1;
            else
                return -1;
        }
    }
}

namespace BitwiseXOR {
    public class Solution {
        public int ArraySign(int[] nums) {
            var XORbuffer = 0;
            foreach(int n in nums) {
                // Base case, early terminate if 0 is in set.
                if(n == 0) return 0;
                
                // Track negative bit if only 1 entry has it set.
                XORbuffer ^= n;
            }

            // Check the negative bit
            return (XORbuffer & Int32.MinValue) == 0 ? 1:-1;
        }
    }
}