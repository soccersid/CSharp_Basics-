using System;

namespace CSharpKurs
{
    internal class Programm3
    {
        public static void Main(string[] args)
        {
            // --- 1. IMPIZIZITES CASTING (Automatisch, kein Datenverlust) ---
            int kleineZahl = 100;
            double grosseZahl = kleineZahl; // int passt problemlos in ein double
            Console.WriteLine($"Implizit (int zu double): {grosseZahl}");

            // --- 2. EXPLIZITES CASTING (Manuell erzwingen, ACHTUNG: Datenverlust!) ---
            double pi = 3.14159;
            int piGanzzahl = (int)pi; // Schneidet die Nachkommastellen einfach ab!
            Console.WriteLine($"Explizit (double zu int): {pi} wird zu {piGanzzahl}");

            // --- 3. DIE CONVERT-KLASSE (Rundet sogar kaufmännisch) ---
            double wert = 4.7;
            int gerundet = Convert.ToInt32(wert); // Wird zu 5!
            Console.WriteLine($"Convert.ToInt32(4.7): {gerundet}");

            // --- 4. PARSE (Wandelt Text-Strings in Zahlen um) ---
            string zahlenText = "123";
            int umgewandelt = int.Parse(zahlenText);
            Console.WriteLine($"Parse von String zu int: {umgewandelt + 10}"); // Rechnerisch 133

            // --- 5. TRYPARSE (Die sichere Methode für Nutzereingaben) ---
            Console.Write("\nGib eine Zahl ein (oder irgendwas ungültiges): ");
            string eingabe = Console.ReadLine();

            // Versucht umzuwandeln. Wenn es klappt -> true und speichert es in 'ergebnis'. Wenn nicht -> false.
            if (int.TryParse(eingabe, out int ergebnis))
            {
                Console.WriteLine($"Erfolgreich eingelesen! Das Doppelte ist: {ergebnis * 2}");
            }
            else
            {
                Console.WriteLine("Das war keine gültige ganze Zahl!");
            }
        }
    }
}
