namespace Algorithmics
{
    public static class Fibonacci
    {
        public static long RecursiveGet(int n)
        {
            if (n <= 1)
                return n;            
            return RecursiveGet(n - 1) + RecursiveGet (n - 2);
        }

        public static long IterativeGet(int n)
        {
            long low = 0;
            long high = 1;
            
            for (int i = 2; i < n; i++)
            {
                var prevHigh = high;
                high = high + low;
                low = prevHigh;
            }

            return high;
        }
    }
}