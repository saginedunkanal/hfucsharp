using System;
using System.Collections.Generic;

namespace Fahrzeugverwaltung
{

    class Program
    {

        static void Main(string[] args)
        {
            List<BaseFahrzeuge> autoStamm = new List<BaseFahrzeuge>();
            List<BaseFahrzeuge> motorradStamm = new List<BaseFahrzeuge>();
            List<BaseFahrzeuge> lieferwagenStamm = new List<BaseFahrzeuge>();

            string input = "0";

            const string doExit = "9";
            while (input != doExit) // Magische Zahl "9" mit einer sprechenden Konstanten zu ersetzen macht den Code leichter verständlich
                                    // Siehe http://de.wikipedia.org/wiki/Magische_Zahl_%28Informatik%29#Magische_Zahlen_in_Code
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion:\n");
                Console.WriteLine(" [1]= Auto ");
                Console.WriteLine(" [2]= Motorrad");
                Console.WriteLine(" [3]= Lieferwagen");
                Console.WriteLine(" [8]= Alle anzeigen");
                Console.WriteLine(" [9]= Beenden");
                Console.WriteLine("**************************************************");

                input = Console.ReadLine();

                switch (input)
                {
                    //Auto
                    case "1":
                        Console.WriteLine("AUTO erfassen\n");
                        BaseFahrzeuge auto = new Auto();
                        autoStamm.Add(auto);
                        break;

                    //Motorrad
                    case "2":
                        Console.WriteLine("MOTORRAD erfassen\n");
                        BaseFahrzeuge motorrad = new Motorrad();
                        motorradStamm.Add(motorrad);
                        break;

                    //Lieferwagen
                    case "3":
                        Console.WriteLine("LIEFERWAGEN erfassen\n");
                        BaseFahrzeuge lieferwagen = new Lieferwagen();
                        lieferwagenStamm.Add(lieferwagen);
                        break;

                    case "8":
                        // Den ganzen Code, den du hier unter case "8" hattest, habe ich in eine Methode AlleFahrzeugeAnzeigen ausgelagert
                        // Jetzt sieht man auf einem Blick, was case "8" eigentlich genau macht
                        // Vorher musste ich den ganze Code-Block durchlesen, um zu verstehen, was eigentlich genau gemacht wurde
                        // Generell ist das Ziel möglichst kleine Code-Häppchen zu haben und keine langen Code-Blöcke und Methoden
                        AlleFahrzeugeAnzeigen(autoStamm, motorradStamm, lieferwagenStamm);
                        break;
                }
            }
        }

        // Ich habe diese Methode unterhalb von der Main-Methode platziert, so kann der Code-Leser oben beginnen und nach unten lesen
        // Die Main-Methode ruft die BaseText-Methode auf, also würde ich den Code auch in dieser Reihenfolge platzieren
        static void BaseText(BaseFahrzeuge s)
        {
            Console.WriteLine("\tFahrzeug Art :\t {0}", s.FahrzeugArt);
            Console.WriteLine("\tFahrzeug-ID  :\t {0}", s.FahrzeugId);
            Console.WriteLine("\tMarke        :\t {0}", s.Marke);
            Console.WriteLine("\tModell       :\t {0}", s.Modell);
            Console.WriteLine("\tFarbe        :\t {0}", s.Farbe);
            Console.WriteLine("\tHubraum [ccm]:\t {0}", s.HubRaum);
            Console.WriteLine("\tPreis   [CHF]:\t {0}", s.Preis);
            Console.WriteLine("\tJahr         :\t {0}", s.JahrGang);
            Console.WriteLine("\tTreibstoff   :\t {0}", s.TreibStoff);
        }

        static void AlleFahrzeugeAnzeigen(List<BaseFahrzeuge> autoStamm, List<BaseFahrzeuge> motorradStamm, List<BaseFahrzeuge> lieferwagenStamm)
        {
            int datenSatz = 0;

            foreach (Auto a in autoStamm)
            {
                datenSatz++;
                Console.WriteLine("\n+DATENSATZ [{0}]--------------", datenSatz);
                BaseText(a);
                Console.WriteLine("\tAirbag       :\t {0}", a.AnzAirBags);
                Console.WriteLine("\tInnen Farbe  :\t {0}", a.InnenFarbe);
                Console.WriteLine("\tKlima        :\t {0}", a.KlimaAnlage);
            }

            foreach (Motorrad m in motorradStamm)
            {
                datenSatz++;
                Console.WriteLine("\n+DATENSATZ [{0}]--------------", datenSatz);
                BaseText(m);
                Console.WriteLine("\tExtras       :\t {0}", m.Extras);
                Console.WriteLine("\tTank  [Liter]:\t {0}", m.TankVolumen);
            }

            foreach (Lieferwagen l in lieferwagenStamm)
            {
                datenSatz++;
                Console.WriteLine("\n+DATENSATZ [{0}]--------------", datenSatz);
                BaseText(l);
                Console.WriteLine("\tPlaetze      :\t {0}", l.AnzSeats);
                Console.WriteLine("\tLadung       :\t {0}", l.MaxLoad);
            }

            Console.WriteLine("\n------------ENDE-------------", datenSatz);
            // Console.WriteLine("AUTO= {0}",autoStamm.Length);
        }
    }
}