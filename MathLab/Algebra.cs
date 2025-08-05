namespace MathLab;

public static class Algebra
{
    public static decimal Sqrt(decimal number, long rounds)
    {
        decimal x = number;

        for (long i = 0; i < rounds; i++)
        {
            x = (x + number / x) / 2;
        }

        return x;
    }
}