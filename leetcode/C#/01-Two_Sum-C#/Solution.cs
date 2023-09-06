public class Solution {
    // <summary>
    // Given an array of integers, nums, and an integer, target, return 
    //      indeces of the two numbers such that they add up to target.
    // </summary>
    // <param name="nums">Array of integers.</param>
    // <param name="target">Target value to find matching indeces.</param>
    // <return>A two index array with indeces from nums that correspond to a sum equalling target.</returns>
    public int[] TwoSum(int[] nums, int target) {
        // int i; array index.
        // int diff; Difference between target and index.
        int i, diff;

        // Dictionary hashmap; Hash table of seen values.
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        for(i = 0; i < nums.Length; i++) {
            diff = target -  nums[i];

            // Search the hash table for the remainder value from previously seen indeces
            if(hashmap.ContainsKey(diff)) {
                return new int[] {hashmap[diff], i};
            } 
            else {
                // Load hash table with new seen value.
                hashmap[nums[i]] = i;
            }
        }

        // Base case. Return invalid index values.
        return new int[] {-1,-1};
    }
}