using System;

class Program
{
    static void Main()
    {
        Console.Write("Gib einen Text ein: ");
        string text = Console.ReadLine();

        string rueckwaerts = "";

        // Schleife läuft vom letzten Index bis 0
        for (int i = text.Length - 1; i >= 0; i--)
        {
            rueckwaerts += text[i];
        }

        Console.WriteLine("Spiegelverkehrt: " + rueckwaerts);
    }
}