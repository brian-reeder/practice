/*
File Name: 
    30-implement-queue-using-stacks/Program.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 26, 2022, 16:55:11

Description:
    Implement a first in first out (FIFO) queue using only two stacks. The
    implemented queue should support all the functions of a normal queue
    (push, peek, pop, and empty).

    Implement the MyQueue class:
        void push(int x) Pushes element x to the back of the queue.
        int pop() Removes the element from the front of the queue and returns it.
        int peek() Returns the element at the front of the queue.
        boolean empty() Returns true if the queue is empty, false otherwise.
*/
namespace ImplementQueueUsingStacks {
    public class Program {
        public static void Main(string[] args) {
            // Load test cases
            var testcases = new (string[], string[], string[])[] {
                (new string[] {"MyQueue", "push", "push", "peek", "pop", "empty"}
                    ,new string[] {"", "1", "2", "", "", ""}
                    ,new string[] {"null", "null", "null", "1", "1", "false"})
            };

            foreach((string[], string[], string[]) t in testcases) {
                Console.Write($"Input:\n[{String.Join(',', t.Item1)}]");
                Console.WriteLine($"\n[{String.Join(',', t.Item2)}]");
                var x = new string[t.Item1.Length];
                MyQueue tQueue = new MyQueue();
                for(int i = 0; i < t.Item1.Length; i++) {
                    switch(t.Item1[i]) {
                        case "MyQueue":
                            tQueue = new MyQueue();
                            x[i] = "null";
                        break;

                        case "push":
                            tQueue.Push(int.Parse(t.Item2[i]));
                            x[i] = "null";
                        break;

                        case "pop":
                            x[i] = $"{tQueue.Pop()}";
                        break;

                        case "peek":
                            x[i] = $"{tQueue.Peek()}";
                        break;

                        case "empty":
                            x[i] = $"{tQueue.Empty()}".ToLower();
                        break;
                    }
                }
                Console.WriteLine($"Output: {String.Join(',', x)}");
                Console.WriteLine($"Pass: {t.Item3.SequenceEqual(x)}\n");
            }
        }
    }
}