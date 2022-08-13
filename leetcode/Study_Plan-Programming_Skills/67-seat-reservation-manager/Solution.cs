/*
File Name: 
    67-seat-reservation-manager/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 13, 2022, 16:29

Description:
    Design a system that manages the reservation state of n seats that are
    numbered from 1 to n.

    Implement the SeatManager class:
    * SeatManager(int n) Initializes a SeatManager object that will manage n
    seats numbered from 1 to n. All seats are initially available.
    * int reserve() Fetches the smallest-numbered unreserved seat, reserves it,
    and returns its number.
    * void unreserve(int seatNumber) Unreserves the seat with the given
    seatNumber.

Constraints:
    * 1 <= n <= 105
    * 1 <= seatNumber <= n
    * For each call to reserve, it is guaranteed that there will be at least one
    unreserved seat.
    * For each call to unreserve, it is guaranteed that seatNumber will be
    reserved.
    * At most 105 calls in total will be made to reserve and unreserve.
*/
public class SeatManager {
    PriorityQueue<int,int> _seats;
    public SeatManager(int n) {
        _seats = new PriorityQueue<int,int>(n);
        for(int i = 1; i <= n; i++)
            _seats.Enqueue(i,i);
    }
    
    public int Reserve() {
        return _seats.Dequeue();
    }
    
    public void Unreserve(int seatNumber) {
        _seats.Enqueue(seatNumber, seatNumber);
    }
}