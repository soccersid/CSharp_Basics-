using System;
using System.Linq;

namespace wortdreher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          // Dieses Programm dreht ein Wort um. 

          // Holen des Wortes vom Nutzer
          Console.Write("Bitte geben Sie Ihr Wort ein: ");
          string wort = Console.ReadLine();

          // Erstellen einer Liste aus den einzelnen Buchstaben und Umdrehen der Liste
          char[] buchstaben = wort.ToCharArray();
          Array.Reverse(buchstaben);

          // Umwandeln der Liste in einen String
          string umgedreht = new string(buchstaben);

          // Ausgabe des umgedrehten Wortes
          Console.WriteLine("\nIhr Wort umgedreht lautet: " + umgedreht);
        }
    }
}
