
namespace AddTwoNumbers {
    class Program {
        static void Main(string[] args) {
            ListNode h1;
            h1 = new ListNode(3);
            h1 = new ListNode(4, h1);
            h1 = new ListNode(2, h1);

            ListNode h2;
            h2 = new ListNode(4);
            h2 = new ListNode(6, h2);
            h2 = new ListNode(5, h2);

            Solution solve = new Solution();
            ListNode? x;
            for(x = solve.AddTwoNumbers(h1, h2);x != null; x = x.next) {
                Console.Write($"{x.val}");
            }
        }
    }
}