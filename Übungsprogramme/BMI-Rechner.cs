using System;

namespace BMI_Rechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Nutzerdaten werden abgefragt
            double körpergröße;
            double gewicht;
            int alter;
            char geschlecht;
            double BMI;
            char antwort;
            bool fett;
            double fetta = 0;
            
            Console.WriteLine("BMI Rechner");
            Console.WriteLine("Dieser Rechner wird ihren BMI-Wert berechnen und ihnen eine Einschätzung geben");
            Console.WriteLine("Geben Sie ihre Körpergröße in Metern an");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out körpergröße))
                {
                    if (körpergröße >= 0)
                    {
                        //Console.WriteLine(körpergröße);
                        körpergröße = Math.Round(körpergröße, 2);
                        break;
                    }
                    else
                        Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
                }
                else
                    Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
            }
            Console.WriteLine("Geben Sie ihr Gewicht in kg an");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out gewicht))
                {
                    if (gewicht >= 0)
                    {
                        gewicht = Math.Round(gewicht, 2);
                        break;
                    }
                    else
                        Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
                }
                else
                    Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
            }
            Console.WriteLine("Geben Sie ihr Alter an");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out alter))
                {
                    if (alter >= 0 && alter <= 20000)
                    break;
                    else
                        Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
                }
                else
                    Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
            }
            Console.WriteLine("Geben Sie ihr Geschlecht an. M für männlich und W für weiblich");
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out geschlecht))
                {
                    geschlecht = char.ToLower(geschlecht);
                    if (geschlecht == 'm' || geschlecht == 'w')
                        break;
                    else
                        Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
                }
                else
                    Console.Write("Wert ungültig. Bitte probieren Sie es erneut: ");
            }
            
            //Berechnung des BMIs
            BMI = Math.Round((gewicht / Math.Pow(körpergröße, 2)),2);
            Console.WriteLine("Ihr BMI beträgt: " + BMI);
            
            //Abfrage Körperfettanteil
            Console.Write("Wenn Sie Angaben zu ihrem Körperfettanteil haben, antworten sie mit y, ansonten mit n: ");
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out antwort))
                {
                    if (antwort == 'y' || antwort == 'n')
                        if (antwort == 'y')
                        {
                            fett = true;
                            break;
                        }
                        else
                        {
                            fett = false;
                            break;
                        }
                }
                else
                    Console.Write("Eingabe ungültig. Bitte probieren sie es erneut");
            }
            if (fett)
            {
                while (true)
                {
                    Console.Write("Geben sie ihren Körperfettanteil an in Prozent an: ");
                    if (double.TryParse(Console.ReadLine(), out fetta))
                        break;
                }

            }
            string bmi_catergory(double bmi)
            {
                if (bmi < 18.5)
                    return "untergewicht";
                else if (bmi < 25.0)
                    return "normal";
                else if (bmi < 30.0)
                    return "uebergewicht";
                else
                    return "adipositas";
            }
            
            string kfa_category(double kfa, char geschlecht2, int alter2)
            {
                // Grenzwerte: [sehr_niedrig | normal | leicht_erhoht | erhoht]
                // Quelle: Jackson & Pollock / ACE Health & Fitness Standards
                double[] grenzen;

                if (geschlecht2 == 'm')
                {
                    if (alter2 <= 20)       grenzen = new double[] { 7,   14,   20.5 };
                    else if (alter2 <= 25)  grenzen = new double[] { 9,   16,   22   };
                    else if (alter2 <= 30)  grenzen = new double[] { 10,  17,   23   };
                    else if (alter2 <= 35)  grenzen = new double[] { 12,  19,   24   };
                    else if (alter2 <= 40)  grenzen = new double[] { 13.5, 20.5, 25.5 };
                    else if (alter2 <= 45)  grenzen = new double[] { 15,  22,   27   };
                    else if (alter2 <= 50)  grenzen = new double[] { 16,  23,   28   };
                    else if (alter2 <= 55)  grenzen = new double[] { 17,  24,   29   };
                    else if (alter2 <= 60)  grenzen = new double[] { 18,  25,   30   };
                    else if (alter2 <= 70)  grenzen = new double[] { 19,  26,   31   };
                    else                    grenzen = new double[] { 20,  27,   32   };
                }
                else // weiblich
                {
                    if (alter2 <= 20)       grenzen = new double[] { 19,   24,   30.5 };
                    else if (alter2 <= 25)  grenzen = new double[] { 19.5, 25,   31.5 };
                    else if (alter2 <= 30)  grenzen = new double[] { 20,   26,   32   };
                    else if (alter2 <= 35)  grenzen = new double[] { 21,   27,   33   };
                    else if (alter2 <= 40)  grenzen = new double[] { 22,   28,   34   };
                    else if (alter2 <= 45)  grenzen = new double[] { 23,   29,   35   };
                    else if (alter2 <= 50)  grenzen = new double[] { 24,   30,   36   };
                    else if (alter2 <= 55)  grenzen = new double[] { 25,   31,   37   };
                    else if (alter2 <= 60)  grenzen = new double[] { 26,   32,   38   };
                    else if (alter2 <= 70)  grenzen = new double[] { 27,   33,   39   };
                    else                    grenzen = new double[] { 28,   34,   40   };
                }

                if (kfa < grenzen[0])
                    return "sehr_niedrig";
                else if (kfa < grenzen[1])
                    return "normal";
                else if (kfa < grenzen[2])
                    return "leicht_erhoht";
                else
                    return "erhoht";
            }   
/*
            string kfa_category(double kfa, char geschlecht2)
            {
                if (geschlecht2 == 'm')
                {
                    if (kfa < 8)
                        return "sehr_niedrig";
                    else if (kfa < 20)
                        return "normal";
                    else if (kfa < 25)
                        return "leicht_erhoht";
                    else
                        return "erhoht";
                }        
                else // "F"
                {
                    if (kfa < 18)
                        return "sehr_niedrig";
                    else if (kfa < 29)
                        return "normal";
                    else if (kfa < 34)
                        return "leicht_erhoht";
                    else
                        return "erhoht";
                }
            }
*/  

            if (alter < 20)
            {
                Console.WriteLine($"Hinweis: Für Personen unter 20 Jahren wird der BMI über alters- und geschlechtsspezifische Perzentile (CDC-Wachstumskurven) eingestuft. Bitte wenden Sie sich an einen Kinderarzt für eine genaue Einordnung.");
            }
            else
            {
                string bmi_ergebnis = bmi_catergory(BMI);
                if (fett)
                {
                    string kfa_ergebnis = kfa_category(fetta, geschlecht, alter);

                    if (bmi_ergebnis == "normal" && kfa_ergebnis == "normal")
                        Console.WriteLine($"Ihre Werte (BMI {BMI}, KFA {fetta} %) liegen im gesunden Bereich. Es besteht kein Handlungsbedarf. Wir empfehlen, Ihren aktuellen Lebensstil mit ausgewogener Ernährung und regelmäßiger Bewegung beizubehalten.");
                    else if (bmi_ergebnis == "normal" && kfa_ergebnis == "erhoht" || kfa_ergebnis == "leicht_erhoht")
                        Console.WriteLine($"Ihr BMI ({BMI}) liegt im Normalbereich. Ihr Körperfettanteil von {fetta} % ist jedoch für ein {(geschlecht == 'm' ? "Mann" : "Weib")} leicht erhöht, was auf einen relativen Mangel an Muskelmasse hindeuten kann. Wir empfehlen gezieltes Krafttraining und eine proteinreiche Ernährung, um die Körperzusammensetzung zu verbessern.");
                    else if (bmi_ergebnis == "normal" && kfa_ergebnis == "sehr_niedrig")
                        Console.WriteLine($"Ihr BMI ({BMI}) ist im Normalbereich, Ihr Körperfettanteil von {fetta} % liegt jedoch am unteren Ende bzw. darunter. Bitte stellen Sie sicher, dass Sie ausreichend Energie und Nährstoffe zu sich nehmen. Bei anhaltend niedrigen Werten empfehlen wir eine ärztliche Abklärung.");
                    else if (bmi_ergebnis == "uebergewicht" && kfa_ergebnis == "normal")
                        Console.WriteLine($"Ihr BMI ({BMI}) liegt im Bereich Übergewicht, Ihr Körperfettanteil von {fetta} % ist jedoch im gesunden Bereich. Dies deutet auf eine hohe Muskelmasse hin. Ihr Körperbau ist metabolisch gut; eine Gewichtsreduktion ist nicht zwingend erforderlich. Regelmäßige Bewegung zur Erhaltung der Muskelmasse wird empfohlen.");
                    else if (bmi_ergebnis == "uebergewicht" && (kfa_ergebnis == "erhoht" || kfa_ergebnis == "leicht_erhoht"))
                        Console.WriteLine($"Ihr BMI ({BMI}) und Ihr Körperfettanteil ({fetta} %) deuten auf ein erhöhtes metabolisches Risiko hin. Wir empfehlen eine moderate Kalorienanpassung, regelmäßige Bewegung (mind. 150 Min./Woche) und ggf. eine Ernährungsberatung. Bitte vereinbaren Sie einen Termin zur Erstellung eines individuellen Plans.");
                    else if (bmi_ergebnis == "adipositas" && (kfa_ergebnis == "erhoht" || kfa_ergebnis == "leicht_erhoht"))
                        Console.WriteLine($"Ihr BMI ({BMI}) und Ihr Körperfettanteil ({fetta} %) liegen deutlich über den empfohlenen Werten. Diese Kombination ist mit einem erhöhten Risiko für Diabetes Typ 2, Bluthochdruck und Herz-Kreislauf-Erkrankungen assoziiert. Wir empfehlen eine umfassende Beratung und ggf. die Einbindung einer Ernährungsberatung oder eines Gewichtsmanagement-Programms.");
                    else if (bmi_ergebnis == "untergewicht" && (kfa_ergebnis == "normal" || kfa_ergebnis == "sehr_niedrig"))
                        Console.WriteLine($"Ihr BMI ({BMI}) deutet auf Untergewicht hin. Ihr Körperfettanteil ({fetta} %) liegt im {kfa_ergebnis} Bereich. Bitte achten Sie auf eine ausreichende Kalorien- und Nährstoffzufuhr. Bei anhaltendem Untergewicht oder ungewolltem Gewichtsverlust empfehlen wir eine ärztliche Abklärung.");
                    else if (bmi_ergebnis == "untergewicht" && (kfa_ergebnis == "erhoht" || kfa_ergebnis == "leicht_erhoht"))
                        Console.WriteLine($"Ihr BMI ({BMI}) deutet auf Untergewicht hin, während Ihr Körperfettanteil ({fetta} %) im oberen Bereich liegt. Diese Kombination kann auf einen Verlust an Muskelmasse (Sarkopenie) hindeuten. Wir empfehlen eine ärztliche Abklärung sowie gezieltes Muskelaufbautraining und eine proteinreiche Ernährung.");
                }
                else
                {
                    if (bmi_ergebnis == "normal")
                        Console.WriteLine($"Ihr BMI ({BMI}) liegt im Normalbereich. Für eine genauere Einordnung wäre zusätzlich der Körperfettanteil hilfreich.");
                    else if (bmi_ergebnis == "untergewicht")
                        Console.WriteLine($"Ihr BMI ({BMI}) deutet auf Untergewicht hin. Bitte achten Sie auf eine ausreichende Kalorien- und Nährstoffzufuhr. Bei anhaltendem Untergewicht empfehlen wir eine ärztliche Abklärung.");
                    else if (bmi_ergebnis == "uebergewicht")
                        Console.WriteLine($"Ihr BMI ({BMI}) liegt im Bereich Übergewicht. Regelmäßige Bewegung und ausgewogene Ernährung werden empfohlen.");
                    else
                        Console.WriteLine($"Ihr BMI ({BMI}) liegt im Bereich Adipositas. Wir empfehlen eine umfassende Beratung und ggf. ein Gewichtsmanagement-Programm.");
                }
            }   
        }
    }
}