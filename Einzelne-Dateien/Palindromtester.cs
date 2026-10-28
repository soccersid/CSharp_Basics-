using System;
using System.Linq;

namespace Menü
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Dies ist ein Palindromtester. Ein Palindromtester testet, ob das Wort oder die Zahl von vorne dasselbe wie von Hinten ist.

            //Wir erstellen das Intro

            Console.WriteLine("Dies ist ein Palindromtester. Bitte geben sie ihre Zeichenkette ein.");

            // wir deklarieren die variable
            string eingabe;

            // wir vergeben die eingabe als variable

            eingabe = Console.ReadLine();

            // mögliche Änderung: Text in Kleinbuchstaben umwandeln und Leerzeichen entfernen
            //string bereinigteEingabe = eingabe.Replace(" ", "").ToLower();
            //Hier muss eingabe durch bereinigte Eingabe unten überall ersetzt werden
            //Jetzt konvertieren wir die eingabe zu einem array

            char[] liste;

            liste = eingabe.ToCharArray();

            Array.Reverse(liste);

            string reversed = new string(liste);

            //Jetzt vergelichen wir und geben mit Dollarzeichen aus

            if (eingabe == reversed)
            {
                Console.WriteLine($"{eingabe} ist ein Palindrom");
            }
            else
            {
                Console.WriteLine($"{eingabe} ist nicht dasselbe wie {reversed}");
            }
        }
    }
}