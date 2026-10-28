using System;

namespace CSharpKurs
{
    internal class Programm4
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            // Grundrechenarten
            int summe = a + b;       // 13
            int differenz = a - b;   // 7
            int produkt = a * b;     // 30
            int division = a / b;    // 3 (Ganzzahldivision, Rest fällt weg!)
            
            // Modulo (%) - Gibt den Rest einer Division zurück
            int rest = a % b;        // 10 geteilt durch 3 ist 3, Rest 1. (Perfekt um gerade/ungerade zu prüfen!)

            Console.WriteLine($"Summe: {summe}, Produkt: {produkt}, Rest (Modulo): {rest}");

            // Inkrement & Dekrement (Erhöhen / Verringern um 1)
            int zähler = 5;
            zähler++; // zähler ist jetzt 6
            zähler--; // zähler ist wieder 5
            Console.WriteLine($"Zähler nach ++ und --: {zähler}");

            // --- DIE MATH-KLASSE ---
            double zahl = 25.0;
            double wurzel = Math.Sqrt(zahl);     // Quadratwurzel (Square Root) -> 5
            double hoch = Math.Pow(2, 3);        // 2 hoch 3 (2 * 2 * 2) -> 8
            double abgerundet = Math.Floor(4.9); // Abrunden -> 4

            Console.WriteLine($"\nMath-Operationen:");
            Console.WriteLine($"Wurzel aus 25: {wurzel}");
            Console.WriteLine($"2 hoch 3: {hoch}");
        }
    }
}
