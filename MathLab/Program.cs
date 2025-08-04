using System;
using System.Diagnostics;

namespace MathLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch swRnd = new Stopwatch();
            double valueRnd;
            Stopwatch swIntegral = new Stopwatch();
            double valueIntegral;
            
            
            swRnd.Start();
            valueRnd = Pi.CalculateRnd(100000000);
            swRnd.Stop();
            swIntegral.Start();
            valueIntegral = Pi.CalculateIntegral(10000);
            swIntegral.Stop();
            Console.WriteLine($"Rnd Time: {swRnd.ElapsedMilliseconds}ms Value: {valueRnd} Diff: {Math.Abs(valueRnd - Math.PI)}");
            Console.WriteLine($"Integral Time: {swIntegral.ElapsedMilliseconds}ms Value {valueIntegral} Diff: {Math.Abs(valueIntegral - Math.PI)}");
        }
    }
}