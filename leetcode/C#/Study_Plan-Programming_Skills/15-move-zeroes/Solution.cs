/*
File Name: 
    15-move-zeroes/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 21, 2022, 18:47:32

Description:
    Given an integer array nums, move all 0's to the end of it while maintaining
     the relative order of the non-zero elements.

    Note that you must do this in-place without making a copy of the array.
*/
namespace Scanner {
    public class Solution {
        public void MoveZeroes(int[] nums) {

            int zeroes = 0;
            for(int i = 0; i < nums.Length-zeroes; i++) {
                if(nums[i] == 0)
                    // Swap with the next non 0 number
                    for(int j = i+1+zeroes; j < nums.Length; j++){
                        if(nums[j] == 0)
                            zeroes++;
                        else {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            break;
                        }
                    }
            }

            return;   
        }
    }
}

namespace Counter {
    public class Solution {
        public void MoveZeroes(int[] nums) {

            int zeroes = 0;
            for(int i = 0; i < nums.Length; i++) {
                if(nums[i] == 0)
                    zeroes++;
                else if(zeroes > 0){
                    nums[i-zeroes] = nums[i];
                    nums[i] = 0;
                }
            }

            return;   
        }
    }
}