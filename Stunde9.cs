using System;

namespace CSharpKurs
{
    internal class Programm9
    {
        public static void Main(string[] args)
        {
            // Aufbau einer for-Schleife: (Startvariable; Abbruchbedingung; Schrittgröße)
            Console.WriteLine("Countdown:");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"{i}...");
            }
            Console.WriteLine("Start!");

            // Man kann auch in 2er-Schritten zählen
            Console.WriteLine("\nGerade Zahlen bis 10:");
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
