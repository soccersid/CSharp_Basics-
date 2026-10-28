namespace MeinProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Es wird die Größte von 4 Zahlen ermittelt
            Als erstes werden die Zahlen eingespeichert
            */
            
            Console.Write("Gebe die 1. Zahl ein: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe die 2. Zahl ein: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe die 3. Zahl ein: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gebe die 4. Zahl ein: ");
            int d = Convert.ToInt32(Console.ReadLine());

            /*
            Jetzt wird die Variable max deklariert
            Es werden die einzelnen Zahlen verglichen
            Die größte Zahl wird immer für Max eingersetzt
            Dann wird die max Variable Ausgeben
            */

            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;    
            if (d > max)
                max = d;
            
            Console.WriteLine($"{max} ist die größte der vier Zahlen");
        }
    }
}