public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int min, mid, max, n, t;
        min = 0;
        max = numbers.Length-1;
        Console.WriteLine($"[{String.Join(',',numbers)}]");
        for(mid=max/2;min<=max; mid=min+(max-min)/2) {
            t = target - numbers[mid];
            n = t > numbers[mid] ? BinarySearch(numbers, t, mid+1, max) : BinarySearch(numbers, t, min, mid-1);
            Console.WriteLine($"n={n}, t={t}, mid={mid}");
            if(numbers[n] == t) {
                return n < mid ? new int[] {n+1, mid+1} : new int[] {mid+1, n+1};
            }
            else if(numbers[n] < t)
                max = mid-1;
            else
                min = mid+1;
        }
        
        return new int[] {-1,-1};
    }
    
    public int BinarySearch(int[] numbers, int target, int min, int max) {
        int mid;
        for(mid=max/2; min<=max;mid=min+(max-min)/2)
            if(numbers[mid] <= target)
                min = mid+1;
            else
                max = mid-1;
        
        return min;
    }
}