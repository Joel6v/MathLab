namespace MathLab;

public class Pi
{
    public static double CalculateRnd(long rounds)
    {
        Random rnd = new Random();

        long inCircle = 0;
        
        for (long i = 0; i < rounds; i++)
        {
            double rndX = rnd.NextDouble();
            double rndY = rnd.NextDouble();
            inCircle = (rndX * rndX + rndY * rndY <= 1) ? inCircle + 1 : inCircle;
        }
        
        return (double)inCircle * 4 / rounds;
    }

    public static double CalculateIntegral(int rectangels)
    {
        double area = 0;
        double xStep = (double)1 / rectangels;
        for (double x = xStep; x <= 1D; x+=xStep)
        {
            area += xStep * Math.Sqrt(4 - x * x);
        }
        return area;
    }
}