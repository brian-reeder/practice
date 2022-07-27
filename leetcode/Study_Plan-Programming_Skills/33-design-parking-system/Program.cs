/*
File Name: 
    33-design-parking-system/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 27, 2022, 15:46:17

Description:
    Design a parking system for a parking lot. The parking lot has three kinds
    of parking spaces: big, medium, and small, with a fixed number of slots for
    each size.

    Implement the ParkingSystem class:
        ParkingSystem(int big, int medium, int small) Initializes object of the
        ParkingSystem class. The number of slots for each parking space are
        given as part of the constructor.
        
        bool addCar(int carType) Checks whether there is a parking space of
        carType for the car that wants to get into the parking lot. carType can
        be of three kinds: big, medium, or small, which are represented by
        1, 2, and 3 respectively. A car can only park in a parking space of its
        carType. If there is no space available, return false, else park the
        car in that size space and return true.
*/
namespace DesignParkingSystem {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string[], int[][], string[])[] {
                 
                 (new string[] {"ParkingSystem", "addCar", "addCar", "addCar", "addCar"},
                    new int[][] {
                         new int[] {1, 1, 0}
                        ,new int[] {1}
                        ,new int[] {2}
                        ,new int[] {3}
                        ,new int[] {1}
                    },
                    new string[] {"null", "true", "true", "false", "false"})
            };

            foreach((string[], int[][], string[]) t in testcases) {
                Console.WriteLine($"Input:\n [{String.Join(',', t.Item1)}]");
                var x = new string[t.Item1.Length];
                var parkingLot = new ParkingSystem(0,0,0);
                for(int i = 0; i < t.Item1.Length; i++) {
                    switch(t.Item1[i]) {
                        case "ParkingSystem":
                            parkingLot = new ParkingSystem(t.Item2[i][0], t.Item2[i][1], t.Item2[i][2]);
                            x[i] = "null";
                            break;

                        case "addCar":
                            x[i] = $"{parkingLot.AddCar(t.Item2[i][0])}".ToLower();
                            break;
                    }
                }
                Console.WriteLine($"Output: {String.Join(',',x)}");
                Console.WriteLine($"Pass: {t.Item3.SequenceEqual(x)}\n");
            }
        }
    }
}