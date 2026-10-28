using System;

namespace Primzahlentest 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie Ihre zu überprüfende Zahl ein: "); // Nutzereingabe Leiten
            int zahl; // Dekleration der Variable "zahl"
            zahl = Convert.ToInt32(Console.ReadLine()); // Initialisieren der Variable "zahl"

            int teiler; // Dekleration der Variable "teiler"
            teiler = 2; // Initialisierung der Variable "teiler"

            bool ist_prim; // Deklerieren der Variable ist_prim
            ist_prim = true; // Ansatz: jede Zahl ist prim, bis man einen Teiler findet

            while ((long)teiler*teiler <= zahl) // Erstellen einer Schleife; Abbruch wenn "teiler" größer als Quadratwurzel von "zahl" wird
            {
                if (zahl % teiler == 0) // Wenn "teiler" "zahl" restlos teilt, kann es keine Primzahl mehr sein
                {
                    ist_prim = false;
                } 
                    

                teiler += 1; // "teiler" wird die nächstgröße natürliche Zahl
            }

            // Ausnahmefälle handeln

            if (zahl == 2)
            {
                ist_prim = true; // Zwei wird direkt auf false gesetzt, da zwei der Start-Teiler ist, obwohl es eine Primzahl ist
            }
            else if (zahl < 2 )
            {
                ist_prim = false; // Es gibt keine Primzahlen kleiner als 2
            }

            Console.WriteLine("Die Zahl ist eine Primzahl: " + ist_prim);
        }
    }
}