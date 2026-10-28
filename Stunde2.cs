using System;

namespace CSharpKurs
{
    internal class Programm2
    {
        public static void Main(string[] args)
        {
            // 1. Ganze Zahlen (Ganzzahlen ohne Komma)
            int alter = 25;
            long weltbevoelkerung = 8000000000L; // Für sehr große Zahlen

            // 2. Kommazahlen (Fließkommazahlen)
            double koerpergroesse = 1.82; // Standard für Kommazahlen
            float gewicht = 75.5f;        // Etwas ungenauer, braucht ein 'f' am Ende

            // 3. Wahrheitswerte (Entweder true oder false)
            bool istOnline = true;
            bool hatGeregnet = false;

            // 4. Einzelne Zeichen (Müssen in einfache Anführungszeichen '')
            char note = 'A';
            char währungssymbol = '€';

            // Ausgabe aller Werte
            Console.WriteLine($"Alter: {alter} Jahre");
            Console.WriteLine($"Größe: {koerpergroesse}m | Gewicht: {gewicht}kg");
            Console.WriteLine($"Ist online? {istOnline}");
            Console.WriteLine($"Note: {note} | Währung: {währungssymbol}");
        }
    }
}
