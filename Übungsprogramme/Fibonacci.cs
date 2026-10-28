using System;

namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ziel des Programms ist es, die Anzahl der gewünschten Fibonacci-Zahlen vom Benutzer einzulesen.
            Console.WriteLine("Geben Sie an, wie viele Zahlen der Fibonacci-Folge ausgegeben werden sollen "); // ab 47 ist die Zahl zu groß für int

            // Wir deklarieren und initialisieren die Variablen mit den ersten beiden Basiszahlen der Fibonacci-Folge
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;

            /*
            Jetzt führen wir den Fibonacci-Code aus
            Wir benutzen eine For-Schleife, um n viele Zahlen zu ermitteln
            Wir benutzen temp als Zwischenvariable
            */
            for (int i=0; i<n;i++)
            {
                Console.Write(a + " ");
                // Nächsten Wert ermitteln und Variablen für die nächste Iteration verschieben
                temp = a + b;
                a = b;
                b = temp;
            }
        }
    }
}
