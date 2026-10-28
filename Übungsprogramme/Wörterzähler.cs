using System;

namespace Wörterzähler
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Bitte geben Sie Ihren Text ein: ");

          string text = Console.ReadLine(); // Deklarieren und Initialisieren der Variable text für den nutzerspezifischen Text

          // Fehlerhandling einer leeren Eingabe
          if (text == null)
          {
            text = ""; 
          }

          text = text.Trim(); // Leerzeichen am Anfang  und Ende loswerden
          string[] wörter = text.Split(' '); // Eine Liste mit den Wörtern erstellen, getrennt mit " " Leerzeichen
          int wortzahl = 0; // Zählvariable definieren
          foreach (string wort in wörter) // Schleife die die Wörter zählt
          {
            if (wort != "")
            {
              wortzahl += 1;
            }
          }
          Console.WriteLine("Dein Text hat " + wortzahl + " Wörter."); // Ausgabe der Wörter
        }
    }
}
