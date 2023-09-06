public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        
        int min, mid, max;
        
        // i <= nums.Length <= 100
        min = 1;
        max = 100;
        
        // Binary search on range of possible lengths
        for(mid=max/2; min <= max; mid=min+(max-min)/2) {
            // Binary search to find the first index with num greater than target
            // Then calculate the subarray length
            int size = nums.Length - MinGreater(nums, mid);
            
            if(size == mid)
                return mid;
            else if(size > mid)
                min = mid+1;
            else
                max = mid-1;
        }
        
        return -1;
    }
    
    // Binary Search for min index with greater value
    int MinGreater(int[] nums, int target) {
        int min, mid, max;
        min = 0;
        max = nums.Length-1;
        for(mid=max/2; min<=max; mid=min+(max-min)/2)
            if(nums[mid] >= target)
                max = mid-1;
            else
                min = mid+1;
        
        return min;
    }
}