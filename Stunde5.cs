using System;

namespace CSharpKurs
{
    internal class Programm5
    {
        public static void Main(string[] args)
        {
            string text = "   C#-Programmierung macht großen Spaß!   ";

            // 1. Leerzeichen am Anfang und Ende entfernen (.Trim())
            string sauber = text.Trim();

            // 2. Groß- und Kleinbuchstaben
            string gross = sauber.ToUpper();
            string klein = sauber.ToLower();

            // 3. Einen Teilstring ausschneiden (.Substring(Startindex, Länge))
            string wort = sauber.Substring(0, 11); // Schneidet "C#-Programmi" ab

            // 4. Wörter ersetzen (.Replace())
            string neu = sauber.Replace("großen Spaß", "super viel Freude");

            // 5. Länge des Strings herausfinden (.Length)
            int laenge = sauber.Length;

            Console.WriteLine($"Original: '{text}'");
            Console.WriteLine($"Sauber:   '{sauber}' (Länge: {laenge} Zeichen)");
            Console.WriteLine($"Groß:     {gross}");
            Console.WriteLine($"Teil:     {wort}");
            Console.WriteLine($"Ersetzt:  {neu}");
        }
    }
}
