using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        //For this program we used the Stopwatch class
        static void Main(string[] args)
        {
            /// <summary>
            /// These are the instances created from the Stopwatch class
            /// They have different states like IsRunning or ElapsedMilliseconds
            /// You change their state by calling one of its methods
            /// </summary>
            /// <returns>They return a stopwatch</returns>
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
