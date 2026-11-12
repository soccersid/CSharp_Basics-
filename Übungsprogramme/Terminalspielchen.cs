using System;

namespace Konsolenbilder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int stars = 4;
            int end = 8;
            int stamm;
            int stammdicke = 0;
            int starsize = 4;
            Console.WriteLine("Wieviele Stufen wollen sie?");
            end = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= end; i++)
            {
                if (i % 2 == 1)
                {
                    stars += 4;
                }
                
                Console.WriteLine(new string('*', stars));
            }
            
            //Tannenbaum
            Console.WriteLine("Wieviele Blätter wollen sie?");
            end = Convert.ToInt32(Console.ReadLine());
            stamm = Convert.ToInt32(end * 4.5 / 13);
            // int stammdicke = (int)Math.Round(end * 1/3.0, MidpointRounding.AwayFromZero);
            for (int i = 1; i <= end; i++)
            {
                Console.Write(new string(' ', end - i));
                Console.Write(new string('*', i));
                Console.WriteLine(new string('*', i));
                
            }
            stammdicke = Convert.ToInt32(2 * (end * 1/3));
            //Console.WriteLine(stammdicke);
            for (int i = 0; i < stamm; i++)
            {
                Console.Write(new string(' ', stammdicke));
                Console.WriteLine(new string('*', stammdicke));
            }
            
            //Stern
            Console.WriteLine("Wie groß soll der Stern sein?");
            starsize = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= starsize; i++)
            {
                Console.Write(new string(' ', starsize * 3 - i));
                Console.WriteLine(new string('*', 2*i));
            }
            for (int i = 0; i <= Convert.ToInt32(starsize * 0.75); i++)
            {
                Console.Write(new string(' ', 2*i));
                Console.Write(new string('*', starsize * 3 - i*2));
                Console.WriteLine(new string('*', starsize * 3 - i*2));
            }

            for (int i = 0; i <= starsize; i++)
            {
                Console.Write(new string(' ', (int)(starsize * 1.75)));
                Console.Write(new string('*', starsize - i));
                Console.Write(new string(' ', (int)(i*2+(starsize * 0.5))));
                Console.WriteLine(new string('*', starsize - i));
            }
                
                
            
            /*
            while (true)
            {
                if (stars % 2 == 1)
                    {
                    stars += 4;
                    }
                else
                {
                    Console.WriteLine(new string('*', stars));
                    stars += 4;
                }

                zähler++;
                if (zähler == end)
                    break;
                
            }
            */
        }
    }
}