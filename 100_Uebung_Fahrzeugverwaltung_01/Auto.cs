using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeugverwaltung
{

    class Auto : BaseFahrzeuge
    { 
        public string anzAirBags;
        public string innenFarbe;
        public string klimaAnlage;

        public Auto ()
	    {
            fahrzeugArt = "AUTO";
            anzAirBags = userIn("Bitte geben Sie die Anzahl Air-Bags ein:", "");
            innenFarbe = userIn("Bitte geben Sie die Innenfarbe ein:", "");
           
            klimaAnlage = userIn("Hat dieses Fahrzeug eine Klimaanlage?:", "");        
        }

      
    }
}
