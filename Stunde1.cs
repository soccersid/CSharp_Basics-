using System;

namespace CSharpKurs
{
    internal class Programm1
    {
        public static void Main(string[] args)
        {
            // EINZEILIGER KOMMENTAR: Dieser Code wird vom Computer ignoriert.
            /* 
               MEHRZEILIGER KOMMENTAR:
               Hier kann man längere Erklärungen oder Notizen hinterlassen.
            */

            string vorname = "Max";
            string nachname = "Mustermann";

            // 1. Standard-Ausgabe mit WriteLine (macht automatisch einen Zeilenumbruch am Ende)
            Console.WriteLine("=== Willkommen zum Kurs! ===");

            // 2. Escape-Sequenzen:
            // \n = Neuer Zeilenumbruch
            // \t = Tabulator (Einrückung)
            // \" = Ermöglicht Anführungszeichen im String
            Console.WriteLine("\nHier kommt eine neue Zeile.\n\tHier ist ein Tabulator-Abstand.");
            Console.WriteLine("Er sagte: \"C# macht unglaublich viel Spaß!\"");

            // 3. String-Interpolation ($): Variablen direkt in den Text einbetten
            Console.WriteLine($"\nVollständiger Name: {vorname} {nachname}");
        }
    }
}
