using System.Diagnostics;

namespace MathLab;

public static class Menu
{
    public static void Show()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("[1] Pi");
            Console.WriteLine("[2] Sqrt");
            Console.WriteLine("[c] Exit");
            run = Selection();
        }
    }

    private static bool Selection()
    {
        Stopwatch sp = new Stopwatch();
        decimal startValue;
        long rounds;
        
        Console.Write("Enter selection:");
        char selection = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (selection)
        {
            case '1':
                Pi.Show();
                break;
            case '2':
                startValue = EnterDecimalNumber();
                rounds = EnterFullNumber();
                sp.Start();
                decimal value = Algebra.Sqrt(startValue, rounds);
                sp.Stop();
                PrintResult("Sqrt", value, sp.ElapsedMilliseconds);
                break;
            case 'c':
                return false;
            default:
                Console.WriteLine("Wrong selection");
                break;
        }
        return true;
    }
    
    
    
    public static long EnterFullNumber()
    {
        while (true)
        {
            Console.Write("Enter full number: ");
            long number;
            if (!long.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter a full number e.g. 5");
            }
            else
            {
                if (number <= 0)
                {
                    Console.WriteLine("Enter a number bigger than zero");
                }
                else
                {
                    return number;
                }
            }
        }
    }

    public static decimal EnterDecimalNumber()
    {
        while (true)
        {
            Console.Write("Enter number: ");
            decimal number;
            if (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter a number e.g. 5.435");
            }
            else
            {
                if (number <= 0)
                {
                    Console.WriteLine("Enter a number bigger than zero");
                }
                else
                {
                    return number;
                }
            }
        }
    }
    
    public static void PrintResult(string name, decimal value, long time)
    {
        Console.WriteLine($"{name}; Time: {time}ms; Value: {value}");
    }
}