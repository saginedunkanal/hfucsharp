using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeugverwaltung
{
     
    class Program
    {

        static void baseTxt(BaseFahrzeuge s)
        {
            Console.WriteLine("\tFahrzeug Art :\t {0}", s.fahrzeugArt);
            Console.WriteLine("\tFahrzeug-ID  :\t {0}", s.fahrzeugId);
            Console.WriteLine("\tMarke        :\t {0}", s.marke);
            Console.WriteLine("\tModell       :\t {0}", s.modell);
            Console.WriteLine("\tFarbe        :\t {0}", s.farbe);
            Console.WriteLine("\tHubraum [ccm]:\t {0}", s.hubRaum);
            Console.WriteLine("\tPreis   [CHF]:\t {0}", s.preis);
            Console.WriteLine("\tJahr         :\t {0}", s.jahrGang);
            Console.WriteLine("\tTreibstoff   :\t {0}", s.treibStoff);
        } 

        static void Main(string[] args)
        {         
            List <BaseFahrzeuge> autoStamm = new List <BaseFahrzeuge>();
            List<BaseFahrzeuge> motorradStamm = new List<BaseFahrzeuge>();
            List<BaseFahrzeuge> lieferwagenStamm = new List<BaseFahrzeuge>();

            string input="0";

            while (input != "9")
            {
            Console.WriteLine("Bitte wählen Sie eine Aktion:\n"); 
            Console.WriteLine(" [1]= Auto ");
            Console.WriteLine(" [2]= Motorrad");
            Console.WriteLine(" [3]= Lieferwagen");
            Console.WriteLine(" [8]= Alle anzeigen");
            Console.WriteLine(" [9]= Beenden");
            Console.WriteLine("**************************************************");
                
            input = Console.ReadLine ();
      
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
                    
                    int datenSatz = 0;
                    
                    foreach (Auto a in autoStamm) 
                    {
                        datenSatz++;
                        Console.WriteLine("\n+DATENSATZ [{0}]--------------", datenSatz);
                        baseTxt(a);
                        Console.WriteLine("\tAirbag       :\t {0}", a.anzAirBags);
                        Console.WriteLine("\tInnen Farbe  :\t {0}", a.innenFarbe);
                        Console.WriteLine("\tKlima        :\t {0}", a.klimaAnlage);  
                    }

                    foreach (Motorrad m in motorradStamm)
                    {
                        datenSatz++;
                        Console.WriteLine("\n+DATENSATZ [{0}]--------------", datenSatz); 
                        baseTxt(m);
                        Console.WriteLine("\tExtras       :\t {0}", m.extras);
                        Console.WriteLine("\tTank  [Liter]:\t {0}", m.tankVolumen);
                    }

                    foreach (Lieferwagen l in lieferwagenStamm)
                    {
                        datenSatz++;
                        Console.WriteLine("\n+DATENSATZ [{0}]--------------", datenSatz);
                        baseTxt(l);
                        Console.WriteLine("\tPlaetze      :\t {0}", l.anzSeats);
                        Console.WriteLine("\tLadung       :\t {0}", l.maxLoad);
                    }

                    Console.WriteLine("\n------------ENDE-------------", datenSatz); 
                   // Console.WriteLine("AUTO= {0}",autoStamm.Length);
                    break;
            }
 
            }



        }

        
    }
}
