using System;

namespace CSharpKurs
{
    internal class Programm12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== DER PALINDROM-TESTER ===");
            Console.Write("Gib ein Wort ein: ");
            
            // Eingabe holen, Leerzeichen entfernen und alles in Kleinbuchstaben umwandeln
            string original = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrEmpty(original))
            {
                Console.WriteLine("Du hast kein Wort eingegeben!");
                return; // Programm beenden
            }

            // In ein char-Array umwandeln
            char[] buchstaben = original.ToCharArray();

            // Das Array umdrehen (wie in deinem allerersten Code-Snippet!)
            Array.Reverse(buchstaben);

            // Das umgedrehte Array wieder in einen String umwandeln
            string umgedreht = new string(buchstaben);

            // Vergleichen: Ist das Original gleich dem umgedrehten Wort?
            if (original == umgedreht)
            {
                Console.WriteLine($"\nJuhu! '{original}' ist ein Palindrom (vorwärts wie rückwärts gleich)!");
            }
            else
            {
                Console.WriteLine($"\nSchade! '{original}' rückwärts gelesen ist '{umgedreht}' – kein Palindrom.");
            }
        }
    }
}
