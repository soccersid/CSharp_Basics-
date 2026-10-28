using System;

namespace Zahlensortierer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          //Dieses Programm nutzt den Bubble-Sort Algorithmus zum Sortieren einer Liste von Zahlen
          Console.WriteLine($"Geben Sie Ihre Zahlenliste ein. Bitte trennen Sie mit einem ',' Komma.\nz.B.: (9,3,5,6,1)"); 

          // Nutzereingabe speichern und in einen int-Array umwandeln
          string[] teile = Console.ReadLine().Split(','); 
          int[] zahlen = Array.ConvertAll(teile, s => int.Parse(s.Trim()));

          // Bubble-Sort Algorithmus
          // 4. Klassischer Bubble-Sort
          for (int i = 0; i < zahlen.Length - 1; i++)
          {
              for (int j = 0; j < zahlen.Length - i - 1; j++)
              {
                  if (zahlen[j] > zahlen[j + 1])
                  {
                      // Elemente tauschen
                      int temp = zahlen[j];
                      zahlen[j] = zahlen[j + 1];
                      zahlen[j + 1] = temp;
                  }
              }
          }
          // Sortierte Liste sauber ausgeben
          Console.WriteLine("\nSortierte Liste:");
          Console.WriteLine(string.Join(", ", zahlen));        
        }
    }
}
