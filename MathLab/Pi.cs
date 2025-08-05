using System.Diagnostics;

namespace MathLab;

public static class Pi
{
    public static decimal CalculateRnd(long rounds)
    {
        Random rnd = new Random();

        long inCircle = 0;
        
        for (long i = 0; i < rounds; i++)
        {
            double rndX = rnd.NextDouble();
            double rndY = rnd.NextDouble();
            inCircle = (rndX * rndX + rndY * rndY <= 1) ? inCircle + 1 : inCircle;
        }
        
        return (decimal)inCircle * 4 / rounds;
    }

    public static decimal CalculateIntegral(long rectangles)
    {
        decimal area = 0;
        decimal xStep = (decimal)1 / rectangles;
        decimal x;
        for (decimal i = xStep; i <= 1M; i+=xStep)
        {
            x = (i - xStep / 2);
            area += xStep * Algebra.Sqrt(4 - 4 * x * x, rectangles) / 2;
        }
        return area * 4;
    }

    public static void Show()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("Pi Calculator");
            Console.WriteLine("[1] Rnd");
            Console.WriteLine("[2] Integral");
            Console.WriteLine("[c] Exit");
            run = Selection();
        }
    }
    
    private static bool Selection()
    {
        Console.Write("Enter selection:");
        char selection = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        Stopwatch sp = new Stopwatch();
        decimal value;
        
        switch (selection)
        {
            case '1':
                sp.Start();
                value = CalculateRnd(Menu.EnterFullNumber());
                sp.Stop();
                Menu.PrintResult("Rnd", value, sp.ElapsedMilliseconds);
                break;
            case '2':
                sp.Start();
                value = CalculateRnd(Menu.EnterFullNumber());
                sp.Stop();
                Menu.PrintResult("Integral", value, sp.ElapsedMilliseconds);
                break;
            case 'c':
                return false;
            default:
                Console.WriteLine("Wrong selection");
                break;
        }
        return true;
    }
}