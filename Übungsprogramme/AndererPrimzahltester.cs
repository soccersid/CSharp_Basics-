using System;

class Program
{
    static void Main()
    {
        Console.Write("Gib eine Zahl ein: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool istPrim = true;

        if (n <= 1)
        {
            istPrim = false; // 0 und 1 sind keine Primzahlen
        }
        else
        {
            // Wir prüfen bis zur Quadratwurzel von n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) // Wenn ohne Rest teilbar
                {
                    istPrim = false;
                    break; // Wir können aufhören, wenn ein Teiler gefunden wurde
                }
            }
        }

        if (istPrim)
            Console.WriteLine($"{n} ist eine Primzahl.");
        else
            Console.WriteLine($"{n} ist keine Primzahl.");
    }
}