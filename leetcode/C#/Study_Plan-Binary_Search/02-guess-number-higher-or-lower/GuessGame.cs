public class GuessGame {
    private int val;
    protected GuessGame(int n) {
        this.val = n;
    }

    protected int guess(int n) {
        if(this.val == n)
            return 0;
        else if(this.val < n) {
            return -1;
        }
        else {
            return 1;
        }
    }
}