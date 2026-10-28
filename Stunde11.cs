using System;
using System.Collections.Generic; // WICHTIG: Das wird für Listen benötigt!

namespace CSharpKurs
{
    internal class Programm11
    {
        public static void Main(string[] args)
        {
            // 1. Eine dynamische Liste erstellen
            List<string> einkaufsliste = new List<string> { "Äpfel", "Milch" };

            // Elemente hinzufügen (.Add)
            einkaufsliste.Add("Brot");
            einkaufsliste.Add("Kaffee");

            // Anzahl der Elemente abfragen (.Count)
            Console.WriteLine($"Einträge in der Liste: {einkaufsliste.Count}");

            // Ausgabe aller Elemente mit string.Join
            Console.WriteLine(string.Join(", ", einkaufsliste));

            // Ein Element entfernen (.Remove)
            einkaufsliste.Remove("Milch");

            // Die Liste umdrehen (.Reverse)
            einkaufsliste.Reverse();
            Console.WriteLine($"Nach dem Umdrehen: {string.Join(", ", einkaufsliste)}");
        }
    }
}
