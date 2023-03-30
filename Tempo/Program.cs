using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();

            crono1.Start();

            Thread.Sleep(500);

            crono2.Start();

            Thread.Sleep(300);

            crono1.Stop();

            crono2.Stop();

            Console.WriteLine($"Crono1 time: {crono1.ElapsedMilliseconds / 1000.0:F2} seconds");
            Console.WriteLine($"Crono2 time: {crono2.ElapsedMilliseconds / 1000.0:F2} seconds");
        }
    }
}
