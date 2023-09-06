/*
File Name: 
    68-lemonade-change/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 13, 2022, 16:47

Description:
    At a lemonade stand, each lemonade costs $5. Customers are standing in a
    queue to buy from you and order one at a time (in the order specified by
    bills). Each customer will only buy one lemonade and pay with either a $5,
    $10, or $20 bill. You must provide the correct change to each customer so
    that the net transaction is that the customer pays $5.

    Note that you do not have any change in hand at first.

    Given an integer array bills where bills[i] is the bill the ith customer
    pays, return true if you can provide every customer with the correct
    change, or false otherwise.

Constraints:
    * 1 <= bills.length <= 10^5
    * bills[i] is either 5, 10, or 20.
*/
public class Solution {
    public bool LemonadeChange(int[] bills) {
        // 0 - $5
        // 1 - $10
        // 2 - $20
        int[] change = new int[3];
        
        foreach(var i in bills) {
            switch(i){
                case 5:
                    change[0] += 1;
                    break;
                    
                case 10:
                    if(change[0] == 0)
                        return false;
                    change[0] -= 1;
                    change[1] += 1;
                    break;
                    
                case 20:
                    if(change[0] > 0 && change[1] > 0) {
                        change[0] -= 1;
                        change[1] -= 1;
                    }
                    else if(change[0] > 2) {
                        change[0] -= 3;
                    }
                    else {
                        return false;
                    }
                    
                    change[2] += 1;
                    break;
            }
        }
        
        return true;
    }
}