/*
File Name: 
    02-guess-number-higher-or-lower/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 17, 2022, 16:16

Description:
    We are playing the Guess Game. The game is as follows:
    I pick a number from 1 to n. You have to guess which number I picked.
    Every time you guess wrong, I will tell you whether the number I picked is
        higher or lower than your guess.

    You call a pre-defined API int guess(int num), which returns three possible
        results:
    * -1: Your guess is higher than the number I picked (i.e. num > pick).
    * 1: Your guess is lower than the number I picked (i.e. num < pick).
    * 0: your guess is equal to the number I picked (i.e. num == pick).

    Return the number that I picked.

Constraints:
    * 1 <= n <= 2^31 - 1
    * 1 <= pick <= n
*/
public class Solution : GuessGame {
    public Solution(int n) : base(n) {}
    public int GuessNumber(int n) {
        int min, mid, max;
        
        min = 1;
        mid = n/2;
        max = n;
        
        for(int result = guess(mid); result != 0; result = guess(mid)) {
            if(result == -1)
                max = mid-1;
            else if(result == 1)
                min = mid+1;
            
            mid = min + (max-min)/2;
        }
        
        return mid;
    }
}