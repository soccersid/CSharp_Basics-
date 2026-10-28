using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;

namespace Menü
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Auswahl variable für das Programmenü
            byte Auswahl = 0;
            
            //Menüausgabe
            Console.WriteLine("Bitte waählen sie aus den folgenden blablabla eine aus:");
            Console.WriteLine("(1):Addition von zwei Zahlen");
            Console.WriteLine("(2):Subtraktion von zwei Zahlen");
            Console.WriteLine("(3):Multiplikation von zwei Zahlen");
            Console.WriteLine("(4):Division von zwei Zahlen");
            Console.WriteLine("(5):Prüfen ob die Zahl gerade ist");
            Console.WriteLine("(6):Primzahltest");
            Console.WriteLine("(7):Die größte von vier zahlen");
            Console.WriteLine("(8):Wortzähler");
            Console.WriteLine("(9):Text Spiegelverkehrt");
            Console.WriteLine("(10):Palindromtest");
            Console.WriteLine("(11):Fibonacci Folge ausgeben bis eingegebenen Endwert");
            
            
            //Auswahl des Menü Punktes
            Console.WriteLine("Wählen sie eine der genannten blablabla");
            Auswahl = Convert.ToByte(Console.ReadLine());
            if (Auswahl > 11 && Auswahl < 1)
                Console.WriteLine("Bitte wählen Sie zwischen 1 - 11");
            //Ausführung der Verschiedenen Menüpunkte
            switch (Auswahl)
            {
                case 1:
                    int zahl1, zahl2, ergebnis;
                    
                    //Eingabe der Summanden
                    Console.WriteLine("Geben Sie einen Wert für Zahl 1 ein");
                    zahl1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Geben Sie eine Zahl für 2 ein");
                    zahl2= Convert.ToInt16(Console.ReadLine());
                    //Berechnung der Summe
                ergebnis = zahl1 + zahl2;
                    //Ausgabe
                Console.WriteLine("Das Ergebnis der Rechnung beträgt:"+ ergebnis);
                    break;
                case 2:
                    int zahl3, zahl4, ergebniss;
                    Console.WriteLine("Geben Sie einen Wert für Zahl 1 ein");
                    zahl3 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Geben Sie einen Wert für Zahl 2 ein");
                    zahl4 = Convert.ToInt16(Console.ReadLine());
                    ergebniss = zahl3 - zahl4;
                    Console.WriteLine("Das Ergebnis lautet:"+ ergebniss);
                    break;
                case 3:
                    int zahl5, zahl6, ergebnisss;
                    Console.WriteLine("Geben Sie einen Wert für Zahl 1 ein");
                    zahl5 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Geben Sie einen Wert für Zahl 2 ein");
                    zahl6 = Convert.ToInt16(Console.ReadLine());
                    ergebnisss = zahl5 * zahl6;
                    Console.WriteLine("Das Ergebnis lautet:"+ ergebnisss);
                    break;
                case 4:
                    int zahl7, zahl8, ergebnissss;
                    Console.WriteLine("Geben Sie einen Wert für Zahl 1 ein");
                    zahl7 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Geben Sie einen Wert für Zahl 2 ein");
                    zahl8 = Convert.ToInt16(Console.ReadLine());
                    ergebnissss = zahl7 / zahl8;
                    Console.WriteLine("Das Ergebnis lautet:"+ ergebnissss);
                    break;
                case 5:
                    Console.WriteLine("Bitte tippen Sie eine Zahl ein:");
                    Single Number;
                    Number = Convert.ToSingle(Console.ReadLine());
                    if (Number % 2 == 0)
                        Console.WriteLine("Die Zahl ist gerade");
                    else
                        Console.WriteLine("Die Zahl ist ungerade");
                    break;
                case 6:
                    int zahl10;
                    int faktor = 3;
                    bool antwort = true;
                   
                   
                    Console.WriteLine("Bitte geben Sie einen Zahl ein:");
                    zahl10=Convert.ToInt16(Console.ReadLine());
                   
                    if (zahl10 % 2 == 0)
                        antwort = false;


                    else
                    {
                        while ((faktor*faktor <= zahl10) && (antwort==true))
                            if (zahl10 % faktor == 0)
                                antwort=false;
                            else
                            {
                                faktor = faktor + 2;
                            }
                    }

                    if (antwort==true)
                        Console.WriteLine("Die Zahl ist eine Primzahl");
                    else
                    {
                        Console.WriteLine("Die Zahl ist keine Primzahl");
                    }
                   
                    break;
                case 7:
                    int zahl11, zahl12, zahl13, zahl14;
                    Console.WriteLine("Bitte geben Sie vier Zahlen ein:");
                    zahl11 = Convert.ToInt16(Console.ReadLine());
                    zahl12 = Convert.ToInt16(Console.ReadLine());
                    zahl13 = Convert.ToInt16(Console.ReadLine());
                    zahl14 = Convert.ToInt16(Console.ReadLine());

                    if (zahl11 >= zahl12 && zahl11 >= zahl13 && zahl11 >= zahl14)
                    {
                        Console.WriteLine("Größte Zahl: " + zahl11);
                    }
                    else if (zahl12 >= zahl13 && zahl12 >= zahl14)
                    {
                        Console.WriteLine("Größte Zahl: " + zahl12);
                    }
                    else if (zahl13 >= zahl14)
                    {
                        Console.WriteLine("Größte Zahl: " + zahl13);
                    }
                    else
                    {
                        Console.WriteLine("Größte Zahl: " + zahl14);
                    }
                    break;
                case 8:
                    string satz;
                    Console.WriteLine("Geben Sie bitte einen Satz ein:");
                    satz = Console.ReadLine();
                    string[] array;
                    array = satz.Split();
                    int num = array.Length;
                    Console.WriteLine("Wörteranzahl:"+num);
                    break;
                case 9:
                    string satz2;
                    Console.WriteLine("Bitte geben Sie einen Text ein:");
                    satz2 = Console.ReadLine();
                    char[] array2;
                    array2 = satz2.ToCharArray();
                    Array.Reverse(array2);
                    string umgedreht = new string(array2) ;
                    Console.WriteLine("Spiegelverkehrt:"+umgedreht);
                    break;
                case 10:
                    string eingabe;
                    Console.WriteLine("Bitte geben Sie etwas ein (Zahl, Wörter):");
                    eingabe = Console.ReadLine();
                    char[] array3;
                    array3 = eingabe.ToCharArray();
                    Array.Reverse(array3);
                    string nazzz = new string(array3);
                    if (eingabe != nazzz)
                        Console.WriteLine("Kein Palindrom");
                    else
                    Console.WriteLine("Es ist ein Palindrom");
                    break;
                    case 11:
                        string eingabe2;    
                        Console.WriteLine("Bitte geben Sie den gewünschten Endwert der Folge ein:");
                        eingabe2 = Console.ReadLine();
                        
                        break;
                        
                    {
                        
                    }

            }
   
              }       
        }
    }
