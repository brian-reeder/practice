/*
File Name: 
    09-first-bad-version/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 20, 2022, 14:06

Description:
    You are a product manager and currently leading a team to develop a new
    product. Unfortunately, the latest version of your product fails the
    quality check. Since each version is developed based on the previous
    version, all the versions after a bad version are also bad.

    Suppose you have n versions [1, 2, ..., n] and you want to find out the
    first bad one, which causes all the following ones to be bad.

    You are given an API bool isBadVersion(version) which returns whether
    version is bad. Implement a function to find the first bad version. You
    should minimize the number of calls to the API.

Constraints:
    * 1 <= bad <= n <= 2^31 - 1
*/
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int ans, min, mid, max;
        min = 1;
        max = n;
        ans = 1;
        for(mid = max/2; min <= max;mid = min+(max-min)/2)
            if(IsBadVersion(mid)) {
                max = mid-1;
                ans = mid;
            }
            else
                min = mid+1;
        
        return ans;
    }
}