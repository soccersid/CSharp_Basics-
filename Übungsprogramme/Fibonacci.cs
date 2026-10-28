using System;

namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Ziel des Programms ist es, die ersten n Fibonacci-Zahlen auszugeben.
            Console.WriteLine("Geben sie an, wie viele Zahlen der Fibonacci-Folge ausgegeben werden sollen "); // ab 47 ist die Zahl zu groß für int

            //Wir deklarieren und initialisieren die Variablen
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;

            /*
            Jetzt führen wir den Fibonacci-Code aus
            Wir benutzen eine For-Schleife, um n viele Zahlen zu ermitteln
            Wir benutzen temp als Zwischen-variable
            */
            for (int i=0; i<n;i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b;
                b = temp;
            }
        }
    }
}
