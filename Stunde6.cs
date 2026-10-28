using System;

namespace CSharpKurs
{
    internal class Programm6
    {
        public static void Main(string[] args)
        {
            Console.Write("Gib deine aktuelle Punktzahl ein (0-100): ");
            int punkte = int.Parse(Console.ReadLine());

            // Verzweigungen mit if, else if und else
            if (punkte >= 90)
            {
                Console.WriteLine("Note: Sehr gut! Ausgezeichnete Arbeit.");
            }
            else if (punkte >= 75)
            {
                Console.WriteLine("Note: Gut! Kann sich sehen lassen.");
            }
            else if (punkte >= 50)
            {
                Console.WriteLine("Note: Bestanden. Luft nach oben ist aber noch da.");
            }
            else
            {
                Console.WriteLine("Leider nicht bestanden. Beim nächsten Klappt's!");
            }

            // Logische Operatoren: && (Und) sowie || (Oder)
            int alter = 20;
            bool hatAusweis = true;

            if (alter >= 18 && hatAusweis)
            {
                Console.WriteLine("\nZugriff gewährt (Du bist volljährig und hast einen Ausweis).");
            }
        }
    }
}
