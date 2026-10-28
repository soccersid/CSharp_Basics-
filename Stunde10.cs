using System;

namespace CSharpKurs
{
    internal class Programm10
    {
        public static void Main(string[] args)
        {
            // 1. Ein int-Array mit 5 festen Zahlen erstellen
            int[] zahlen = { 10, 20, 30, 40, 50 };

            // Zugriff auf ein einzelnes Element (Achtung: Zählung beginnt bei Index 0!)
            Console.WriteLine($"Erste Zahl im Array: {zahlen[0]}"); // 10
            Console.WriteLine($"Letzte Zahl im Array: {zahlen[4]}"); // 50

            // Wert an einer bestimmten Stelle ändern
            zahlen[1] = 99; 
            Console.WriteLine($"Zweite Zahl nach Änderung: {zahlen[1]}");

            // 2. Ein String-Array für Namen
            string[] wochentage = { "Montag", "Dienstag", "Mittwoch" };

            // Array mit einer for-Schleife komplett durchlaufen
            Console.WriteLine("\nAlle Wochentage im Array:");
            for (int i = 0; i < wochentage.Length; i++)
            {
                Console.WriteLine($"- {wochentage[i]}");
            }
        }
    }
}
