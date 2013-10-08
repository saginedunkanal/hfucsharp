using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeugverwaltung
{
    
    class BaseFahrzeuge
      
    {   
        //Fields
        public string fahrzeugArt;
        public string fahrzeugId;
        public string marke;
        public string modell;
        public string farbe;
        public string hubRaum;
        public string preis;
        public string jahrGang;
        public string treibStoff;
        public bool accept = false;

        //Enum
        public enum FarbAuswahl { Rot, Gruen, Gelb, Weiss, Schwarz, Blau, Braun, Silber, Pink, Violett }


        //Constructor
        public BaseFahrzeuge()
        {        
            //Ask the user for inputs
            fahrzeugId = userIn("Bitte geben Sie eine Fahrzeug ID ein:", "");
            marke = userIn("Bitte geben Sie die Marke ein:", "");
            modell = userIn("Bitte geben Sie das Modell ein:", "");
            
            //Accept only values from enumm FarbAuswahl!
            string auswahl = auswahlMenue("Farbe");
            while (accept == false)
            {
            farbe = userIn("Bitte geben Sie die Farbe ein:", auswahl);
                int colNumber;
                if (Int32.TryParse(farbe, out colNumber)) //if the input of the user can convert to int32 then choose the enum word
                {
                    farbe = Enum.GetName(typeof(FarbAuswahl), colNumber);
                    if (farbe != null)
                    { accept = true; }
                }
                else
                {
                    Console.WriteLine("sie müssen eine Zahl eingeben");
                }
            }

            hubRaum = userIn("Bitte geben Sie den Hubraum ein:", "");
            preis = userIn("Bitte geben Sie den Preis ein:", "");
            jahrGang = userIn("Bitte geben Sie den Jahrgang ein:", "");
            treibStoff = userIn("Bitte geben Sie den Treibstoff ein:", "");
        }
   
    //handle the in/output to console
    public string userIn(string outText,  string auswahl)
    {
        string userOut;
        Console.WriteLine("{0}",outText + "\t" + auswahl);
        userOut = Console.ReadLine();
        return userOut;
    }
    
    //This is to create a string of menue items of a enum Type
    public string auswahlMenue(string enumType )
    {
        string temp = "";
        switch (enumType)
        { 
        case "Farbe":
        foreach (int val in Enum.GetValues(typeof(FarbAuswahl)))
                {
                    temp += val + "=" + Enum.GetName(typeof(FarbAuswahl), val) + " | ";
                }
                break;
       }
        return temp;
    }

  
        
    }

}
