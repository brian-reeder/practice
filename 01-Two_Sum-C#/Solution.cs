public class Solution {
    // <summary>
    // Given an array of integers, nums, and an integer, target, return 
    //      indeces of the two numbers such that they add up to target.
    // </summary>
    // <param name="nums">Array of integers.</param>
    // <param name="target">Target value to find matching indeces.</param>
    // <return>A two index array with indeces from nums that correspond to a sum equalling target.</returns>
    public int[] TwoSum(int[] nums, int target) {
        int i, n, difference;
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        for(i = 0; i < nums.Length; i++) {
            n = nums[i];
            difference = target -  n;
            if(hashmap.ContainsKey(difference)) {
                return new int[] {hashmap[difference], i};
            } 
            else {
                hashmap[n] = i;
            }
        }

        return new int[2];
    }
}