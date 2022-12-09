public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;

        int one = 2;
        int two = 1;
        int temp = 0;

        for (int i = 2; i < n; i++)
        {
            temp = one + two;
            two = one;
            one = temp;
        }
        return temp;

    }
}