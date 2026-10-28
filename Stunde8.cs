using System;

namespace CSharpKurs
{
    internal class Programm8
    {
        public static void Main(string[] args)
        {
            int zähler = 1;

            Console.WriteLine("Zähle von 1 bis 5 mit einer while-Schleife:");
            
            // Läuft, solange zähler kleiner oder gleich 5 ist
            while (zähler <= 5)
            {
                Console.WriteLine($"Aktueller Zählerstand: {zähler}");
                zähler++; // Sehr wichtig, sonst läuft die Schleife unendlich (Endlosschleife)!
            }

            // Beispiel: Wiederholen, bis der Nutzer das richtige Passwort eingibt
            string passwort = "";
            while (passwort != "geheim")
            {
                Console.Write("\nGib das Passwort ein ('geheim'): ");
                passwort = Console.ReadLine();
            }
            Console.WriteLine("Zugriff erfolgreich!");
        }
    }
}
