public class Sequences
{
    public static int FibonacciSequence(int range)
    {
        if (range == 0) return 0;
        if (range == 1) return 1;

        int prev1 = 0;
        int prev2 = 1;
        int newFiboVal = 0;
        for (int i = 2; i < range; i++)
        {
            newFiboVal = prev1 + prev2;
            prev1 = prev2;
            prev2 = newFiboVal;
        }
        return newFiboVal;
    }

    


}
