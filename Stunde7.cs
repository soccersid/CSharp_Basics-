using System;

namespace CSharpKurs
{
    internal class Programm7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wähle einen Wochentag (1-3):");
            Console.WriteLine("1 = Montag");
            Console.WriteLine("2 = Mittwoch");
            Console.WriteLine("3 = Freitag");
            Console.Write("Deine Wahl: ");
            
            int auswahl = int.Parse(Console.ReadLine());

            // Switch-Anweisung als elegante Alternative zu vielen if-else-Abfragen
            switch (auswahl)
            {
                case 1:
                    Console.WriteLine("Uff, der Start in die Woche. Kaffee trinken!");
                    break; // Beendet den jeweiligen Case
                case 2:
                    Console.WriteLine("Bergfest! Die Woche ist bald geschafft.");
                    break;
                case 3:
                    Console.WriteLine("Endlich Freitag! Das Wochenende steht vor der Tür.");
                    break;
                default:
                    Console.WriteLine("Ungültige Wahl! Bitte gib 1, 2 oder 3 ein.");
                    break; // Wird ausgeführt, wenn kein Case zutrifft
            }
        }
    }
}
